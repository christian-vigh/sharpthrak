/**************************************************************************************************************

    NAME
        Expression.cs

    DESCRIPTION
        Expression evaluator.

    AUTHOR
        Christian Vigh, 11/2007.

    HISTORY
    [Version : 1.0]    [Date : 2007/11/05]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using  System ;
using  System. Diagnostics ;
using  System. Globalization ;
using  System. IO ;
using  System. Reflection ;
using  System. Text. RegularExpressions ;
using  System. Windows. Forms ;


using  Thrak. Core ;
using  Thrak. Structures ;


namespace Thrak
   {
	public static partial class  Math
	   {

		# region Expression class
		/// <summary>
		/// class for evaluating expressions.
		/// </summary>
		public class  Expression
		   {
			# region Delegates
			/// <summary>
			/// Delegate for a user-defined function evaluator that is called when
			/// the expression contains a non-built in function.
			/// </summary>
			/// <param name="name">Function name.</param>
			/// <param name="args">Function argument.</param>
			/// <returns>The result of the evaluation.</returns>
			public delegate Symbol FunctionEvaluatorFunction ( String  name, params Object []  args ) ;


			/// <summary>
			/// Delegate for a user-defined variable evaluator that is called when the
			/// expression contains an undefined variable.
			/// </summary>
			/// <param name="name">Variable name.</param>
			/// <returns>The variable contents.</returns>
			public delegate Symbol VariableEvaluatorFunction ( String  name ) ;
			# endregion


			# region SymbolType enum
			/// <summary>
			/// Defines the possible types of a symbol within an expression.
			/// </summary>
			public enum  SymbolType
			   {
				/// <summary>
				/// Symbol is a variable.
				/// </summary>
				Variable,

				/// <summary>
				/// Symbol is a value.
				/// </summary>
				Value,

				/// <summary>
				/// Symbol is an operator.
				/// </summary>
				Operator,

				/// <summary>
				/// Symbol is a function call.
				/// </summary>
				Function,

				/// <summary>
				/// Symbol is a result.
				/// </summary>
				Result,

				/// <summary>
				/// Symbol is a grouping bracket.
				/// </summary>
				Bracket,

				/// <summary>
				/// Symbol is a comma.
				/// </summary>
				Comma,

				/// <summary>
				/// Unary operator.
				/// </summary>
				Unary,

				/// <summary>
				/// Special symbol type for signalling a syntax error.
				/// </summary>
				Error
			    }
			# endregion


			# region Symbol class
			public class  Symbol
			   {
				# region Private data members
				// Symbol name
				private String		p_Name		=  null ;
				// Symbol value
				private double		p_Value ;
				// Symbol type
				private SymbolType	p_Type		=  SymbolType. Error ;
				# endregion


				# region Constructors
				/// <summary>
				/// Default constructor ; creates an empty Symbol object.
				/// </summary>
				public  Symbol ( )
				   { }


				/// <summary>
				/// Creates a Symbol object using the specified values.
				/// </summary>
				/// <param name="name">Symbol name.</param>
				/// <param name="value">Symbol value.</param>
				/// <param name="type">Symbol type.</param>
				public  Symbol ( String  name, double  value, SymbolType  type )
				   {
					p_Name	=  name ;
					p_Value =  value ;
					p_Type  =  type ;
				    }
				# endregion


				# region Properties
				/// <summary>
				/// Gets/sets the name of the symbol.
				/// </summary>
				public String  Name
				   {
					get { return ( p_Name ) ; }
					set { p_Name = value ; }
				    }


				/// <summary>
				/// Gets/sets the value of the symbol.
				/// </summary>
				public double  Value
				   {
					get { return ( p_Value ) ; }
					set { p_Value = value ; }
				    }


				/// <summary>
				/// Gets/sets the type of the symbol.
				/// </summary>
				public SymbolType  Type
				   {
					get { return ( p_Type ) ; }
					set { p_Type = value ; }
				    }
				# endregion


				# region ToString method
				/// <summary>
				/// Returns a string representation of the symbol.
				/// </summary>
				public override string ToString ( )
				   {
					return ( String. Format (
						"{1}(\"{0}\")",
							p_Name, p_Type. ToString ( ) ) ) ;
				    }
				# endregion
			    }
			# endregion


			# region Private data members
			// Expression to evaluate
			private String				p_Expression		=  null ;
			// Stack holding the symbols found in the equation
			private Stack<Symbol>			p_Equation ;
			// Same stack, in postfix notation
			private Stack<Symbol>			p_PostfixEquation ;
			// User-defined function evaluator
			private FunctionEvaluatorFunction	p_FunctionEvaluator	=  null ;
			// User-defined variable evaluator
			private VariableEvaluatorFunction	p_VariableEvaluator	=  null ; 
			// Expression result
			private double				p_Result ;
			// Error flag
			private bool				p_Error	;
			// Error description message
			private String				p_ErrorDescription ;
			# endregion


			# region Constructors
			/// <summary>
			/// Default constructor. Creates an empty Expression object (use the
			/// Expression.Parse() method to later parse
			/// </summary>
			public Expression ( )
			   { }


			/// <summary>
			/// Builds an expression object and parses the specified expression.
			/// </summary>
			/// <param name="expression"></param>
			public  Expression ( String  expression ) 
			   { p_Expression = expression ; }
			# endregion


			# region Properties
			/// <summary>
			/// Returns the list of equation symbols.
			/// </summary>
			public Stack<Symbol>  Equation
			   {
				get { return ( p_Equation ) ; }
			    }


			/// <summary>
			/// Returns the flag indicating if the parsed expression contains an error.
			/// </summary>
			public bool  Error 
			   {
				get { return ( p_Error ) ; }
			    }


			/// <summary>
			/// Returns the description of the parse error, if any.
			/// </summary>
			public String  ErrorDescription
			   {
				get { return ( p_ErrorDescription ) ; }
			    }


			/// <summary>
			/// Gets/sets the expression to parse.
			/// </summary>
			public String  Text
			   {
				get { return ( p_Expression ) ; }
				set { p_Expression = value ; }
			    }


			/// <summary>
			/// Gets/sets the callback to be used for evaluating non built-in functions.
			/// </summary>
			public FunctionEvaluatorFunction FunctionEvaluator
			   {
				get { return ( p_FunctionEvaluator ) ; }
				set { p_FunctionEvaluator = value ; }
			    }


			/// <summary>
			/// Returns the list of equation symbols in postfix notation.
			/// </summary>
			public Stack<Symbol>  PostfixEquation
			   {
				get { return ( p_PostfixEquation ) ; }
			    }


			/// <summary>
			/// Gets the result of the evaluated expression.
			/// </summary>
			public double  Result
			   {
				get { return ( p_Result ) ; }
			    }


			/// <summary>
			/// Gets the list or defined variables or set the variable values.
			/// </summary>
			public Stack<Symbol>  Variables
			   {
				get 
				   {
					// Returned list
					Stack<Symbol>	vars  = new Stack<Symbol> ( ) ;

					// Loop through the symbols of the equation
					foreach ( Symbol  sym  in  p_Equation )
					   {
						// If a variable is found and is not already present in
						// the variable list that will be returned, then add it to the list
						if  ( sym. Type  ==  SymbolType. Variable  &&
						      ! ( vars. Contains ( sym ) ) )
							vars. Push ( sym ) ;
					     }

					// All done, return the variables that have been found
					return ( vars ) ;
				     }
				set
				   {
					// Loop through the list of variable values
					foreach ( Symbol  sym  in  value )
					   {
						// Try to find all occurrences of the specified variable
						foreach  ( Symbol  postsym  in  p_PostfixEquation )
						   {
							// If found, set its value to the one supplied by the caller
							if  ( postsym. Type  ==  SymbolType. Variable  &&
							      postsym. Name  ==  sym. Name )
								postsym. Value = sym. Value ;
						    }
					     }
				    }
			    }


			/// <summary>
			/// Gets/sets the callback to be used for evaluating variables.
			/// </summary>
			public VariableEvaluatorFunction  VariableEvaluator
			   {
				get { return ( p_VariableEvaluator ) ; }
				set { p_VariableEvaluator = value ; }
			    }
			# endregion


			# region Expression parser
			protected void  Parse ( String  expression )
			   {
				// Paranoid checks
				if  ( String. IsNullOrEmpty ( expression ) )
				   {
					SetError ( Resources. Localization. Classes. Math. XMathExprEmpty ) ;
					return ;
				    }

				// Expression object initialization
				SetSuccess ( ) ;				// Consider that there is no error for the moment
				p_Expression	  = expression ;
				p_Result	  = 0 ;				// No result for the moment
				p_Equation	  = new Stack<Symbol> ( ) ;	// (re-)Create the equation stack
				p_PostfixEquation = new Stack<Symbol> ( ) ;	// (re-)Create the postfix equation

				// Local variables
				int		length		=  expression. Length ;

				// Get the regex expression (incorporated as a resource)
				Stream		Input		=  Assembly. GetExecutingAssembly ( ). GetManifestResourceStream ( "Thrak.Resources.Math.Expression.regex" ) ;
				String		Contents	=  new StreamReader ( Input ). ReadToEnd ( ) ;
				Regex		regex		=  new Regex ( Contents, RegexOptions. IgnorePatternWhitespace ) ;
				Match		match		=  regex. Match ( expression ) ;


				// The incorporated regex expression ensures that tokens are parsed individually ;
				// loop through them
				while  ( match. Success )
				   {
					String		token	=  match. Value ;	// Input token
					String		name ;
					double		value	=  0 ;			// Token value
					SymbolType	type ;				// Input token type


					// Ignore spaces
					if  ( String. IsNullOrEmpty ( token ) )
					   {
						match = match. NextMatch ( ) ;
						continue ;
					    }

					// Integer token with a radix ?
					if  ( ! String. IsNullOrEmpty ( match. Groups [ "integer" ]. Value ) )
					    { 
						name		=  token ;
						value		=  TokenAsInteger ( token ) ;
						type		=  SymbolType. Value ;
					     }
					// Float token (include radix-less integers as well)
					else if  ( ! String. IsNullOrEmpty ( match. Groups [ "float" ]. Value ) )
					    { 
						name		=  token ;
						value		=  TokenAsFloat ( token ) ;
						type		=  SymbolType. Value ;
					     }
					// Delimiter token ?
					else if  ( ! String. IsNullOrEmpty ( match. Groups [ "delimiter" ]. Value ) )
					    { 
						name		=  token ;
						type		=  SymbolType. Comma ;
					     }
					// Bracket token ?
					else if  ( ! String. IsNullOrEmpty ( match. Groups [ "bracket" ]. Value ) )
					    { 
						name		=  token ;
						type		=  SymbolType. Bracket ;
					     }
					// Operator token ? pay attention, because this may be a unary operator
					else if  ( ! String. IsNullOrEmpty ( match. Groups [ "operator" ]. Value ) )
					    {
						name		=  token ;
						type		=  SymbolType. Operator ;
					     }
					// Variable token ?
					else if  ( ! String. IsNullOrEmpty ( match. Groups [ "variable" ]. Value ) )
					    { 
						name		=  match. Groups [ "variable" ]. Value ;
						type		=  SymbolType. Variable ;
					     }
					// Name token ?
					else if  ( ! String. IsNullOrEmpty ( match. Groups [ "name" ]. Value ) )
					    { 
						value = 0 ;

						// Check if this name is not a predefined constant name
						if  ( ConstantEvaluator ( token, out value ) )
						   {
							name		=  token ;
							type		=  SymbolType. Value ;
						    }
						// No, this is a function call
						else
						   {
							name		=  token ;
							type		=  SymbolType. Function ;
						    }
					     }
					// Unknown token
					else
					    {
						SetError ( Resources. Localization. Classes. Math. XMathExprUnexpectedToken, token ) ;
						return ;
					     }

					// If an error has been encountered, stop here
					if  ( Error )
						return ;

					// Add the current symbol to the stack
					if  ( name  !=  null )
						p_Equation. Push ( new Symbol ( name, value, type ) ) ;

					// Proceed with next match
					match = match. NextMatch ( ) ;
				    }

				// All done, process unary operators
				p_Equation = ProcessUnaries ( p_Equation ) ;
			    }
			# endregion


			# region Evaluate method
			/// <summary>
			/// Evaluates the expression contained in the Text property of this object.
			/// </summary>
			public void  Evaluate ( )
			   {
				if  ( String. IsNullOrEmpty ( p_Expression ) )
				   {
					SetError ( Resources. Localization. Classes. Math.XMathExprNothingToEval ) ;
					return ;
				    }

				Evaluate ( p_Expression ) ;
			     }


			/// <summary>
			/// Evaluates the specified expression.
			/// </summary>
			/// <param name="expression">Expression to evaluate.</param>
			public void  Evaluate ( String  expression )
			   {
				// Parse the expression
				Parse ( expression ) ;

				if  ( p_Error )
					return ;

				// Convert the equation stack to postfix notation
				InfixToPostfix ( ) ;

				if  ( p_Error )
					return ;

				// Local variables
				Symbol		a, b, result ;
				Stack<Symbol>	local_stack		= new Stack<Symbol> ( ) ;
				Stack<Symbol>	function_parameters	= new Stack<Symbol> ( ) ;


				// Loop through the postfix stack elements
				foreach ( Symbol  symbol  in  p_PostfixEquation )
				   {
					// Push any value symbol onto the local stack
					if  ( symbol. Type  ==  SymbolType. Value     ||
					      symbol. Type  ==  SymbolType. Variable  ||
					      symbol. Type  ==  SymbolType. Comma     ||
					      symbol. Type  ==  SymbolType. Result )
						local_stack. Push ( symbol ) ;
					// Unary operator : apply it to the last pushed value or result
					else if  ( symbol. Type  ==  SymbolType. Unary )
					   {
						Symbol		previous  =  local_stack [ local_stack. Count - 1 ] ;

						if  ( previous. Type  ==  SymbolType. Value  ||  previous. Type  ==  SymbolType. Result )
						   {
							if  ( symbol. Name  ==  "-" )
								previous. Value = - previous. Value ;
						    }
					    }
					// If an operator is found, apply it on the next two symbols
					// that are on the local stack
					else if  ( symbol. Type  ==  SymbolType. Operator )
					   {
						a = local_stack. Pop ( ) ;
						b = local_stack. Pop ( ) ;
						result = BinaryOperation ( b, symbol, a ) ;

						// Check for possible errors
						if  ( result. Type  ==  SymbolType. Error )
						   {
							SetError ( result. Name ) ;
							return ;
						    }

						// Push the result back to the local stack
						local_stack. Push ( result ) ;
					    }
					// Function call encountered
					else if  ( symbol. Type  ==  SymbolType. Function )
					   {
						// Clear the parameter stack and get the next symbol from the
						// local stack
						function_parameters. Clear ( ) ;
						a = local_stack. Pop ( ) ;

						// The stack does not contain a comma, only a value : 
						// this means that the function has only one parameter
						if  ( a. Type  ==  SymbolType. Value     ||
						      a. Type  ==  SymbolType. Variable  ||
						      a. Type  ==  SymbolType. Result )
						   {
							// Call the function
							result = BuiltInFunctionEvaluator ( symbol. Name, a ) ;

							// Check for possible errors
							if  ( result. Type  ==  SymbolType. Error )
								return ; 

							// Push the result back to the local stack
							local_stack. Push ( result ) ;
						    }
						// A comma means that the function call has several parameters
						else if  ( a. Type  ==  SymbolType. Comma )
						   {
							// Collect the function parameters
							while  ( a. Type  ==  SymbolType. Comma )
							   {
								a = local_stack. Pop ( ) ;
								function_parameters. Push ( a ) ;
								a = local_stack. Pop ( ) ;
							    }

							// Don't forget the last one
							function_parameters. Push ( a ) ;

							// Call the function but invert the parameter stack before
							Symbol []	argv	=  new Symbol [ function_parameters. Count ] ;

							for  ( int  i = 0 ; i < argv. Length ; i ++ )
								argv [i] = function_parameters. Pop ( ) ;

							result = BuiltInFunctionEvaluator ( symbol. Name,
									argv ) ;

							// Check for possible errors
							if  ( result. Type  ==  SymbolType. Error )
								return ;

							// Push the result back to the local stack
							local_stack. Push ( result ) ;
						    }
						// Function call with no argument
						else
						   {
							// Push back the symbol that has been popped.
							// It will be used at next iteration
							local_stack. Push ( a ) ;

							// Call the function
							result = BuiltInFunctionEvaluator ( symbol. Name ) ;

							// Check for possible errors
							if  ( result. Type  ==  SymbolType. Error )
								return ;

							// Push the result back to the local stack.
							local_stack. Push ( result ) ;
						    }
					    }
				    }

				// At the end of the loop, we should have only one symbol on the local stack :
				// the final result of the evaluation
				if  ( local_stack. Count  ==  1 )
				   {
					result = local_stack. Pop ( ) ;
					p_Result = result. Value ;
				    }
			    }
			# endregion


			# region Helper methods for parsing

			# region Operator precedence
			/// <summary>
			/// Returns the precedence of the specified symbol or operator.
			/// </summary>
			protected int  Precedence  ( Symbol  symbol )
			   {
				switch  ( symbol. Type )
				   {
					case SymbolType. Bracket	: return ( 100 ) ;
					case SymbolType. Function	: return ( 80 ) ;
					case SymbolType. Comma		: return ( 0 ) ;
					case SymbolType. Operator	:
						switch ( symbol. Name )
						   {
							case  "^"	: 
							case  "**"	:
								return ( 60 ) ;
							case  "*"	:
							case  "/"	:
							case  "\\"	:
							case  "%"	:
								return ( 40 ) ;
							case  "|"	:
							case  "&"	:
								return ( 30 ) ;
							case  "+"	:
							case  "-"	:
							case  "~"	:
							case  "!"	:
								return ( 20 ) ;
							case  "<"	:
							case  "<="	:
							case  ">"	:
							case  ">="	:
							case  "=="	:
								return ( 10 ) ;
							default :
								return ( -1 ) ;
						    }
					default :
						return ( -1 ) ;
				     }
			    }
			# endregion


			# region Built-in function evaluator

			# region Function table
			private static Object [,]	BuiltInFunctionTable  = new Object [,]
			   {
				{ "System.Math.Abs"			, "abs"		, new Type   [] { typeof ( double ) } },
				{ "Thrak.Math.Acos"			, "acos"	, new Type   [] { typeof ( double ) } },
				{ "Thrak.Math.Asin"			, "asin"	, new Type   [] { typeof ( double ) } },
				{ "Thrak.Math.Atan"			, "atan"	, new Type   [] { typeof ( double ) } },
				{ "Thrak.Math.Atan2"			, "atan2"	, new Type   [] { typeof ( double ), typeof ( double ) } },
				{ "System.Math.Ceiling"			, "ceil"	, new Type   [] { typeof ( double ) } },
				{ "Thrak.Math.Cos"			, "cos"		, new Type   [] { typeof ( double ) } },
				{ "Toyxbox.Math.Cosh"			, "cosh"	, new Type   [] { typeof ( double ) } },
				{ "System.Math.Exp"			, "exp"		, new Type   [] { typeof ( double ) } },
				{ "System.Math.Floor"			, "floor"	, new Type   [] { typeof ( double ) } },
				{ "System.Math.Log"			, "logn"	, new Type   [] { typeof ( double ), typeof ( double ) } },
				{ "System.Math.Log10"			, "log10"	, new Type   [] { typeof ( double ) } },
				{ "System.Math.Max"			, "max"		, new Type   [] { typeof ( double ) } },
				{ "System.Math.Min"			, "min"		, new Type   [] { typeof ( double ) } },
				{ "System.Math.Pow"			, "pow"		, new Type   [] { typeof ( double ) } },
				{ "System.Math.Round"			, "round"	, new Type   [] { typeof ( double ) } },
				{ "System.Math.Sign"			, "sign"	, new Type   [] { typeof ( double ) } },
				{ "Thrak.Math.Sin"			, "sin"		, new Type   [] { typeof ( double ) } },
				{ "Thrak.Math.Sinh"			, "sinh"	, new Type   [] { typeof ( double ) } },
				{ "System.Math.Sqrt"			, "sqrt"	, new Type   [] { typeof ( double ) } },
				{ "Thrak.Math.Tan"			, "tan"		, new Type   [] { typeof ( double ) } },
				{ "Thrak.Math.Tanh"			, "tanh"	, new Type   [] { typeof ( double ) } },
				{ "System.Math.Truncate"		, "trunc"	, new Type   [] { typeof ( double ) } },

				{ "Thrak.Math.Factorial"		, "fact"	, new Type   [] { typeof ( int    ) } },
				{ "Thrak.Math.Ln"			, "ln"		, new Type   [] { typeof ( double ) } },
				{ "Thrak.Math.Permutations"		, "A"		, new Type   [] { typeof ( int    ), typeof ( int ) } },
				{ "Thrak.Math.Combinations"		, "C"		, new Type   [] { typeof ( int    ), typeof ( int ) } },
				{ "Thrak.Math.Sigma"			, "sigma"	, new Type   [] { typeof ( int    ), typeof ( int ) } },
				{ "Thrak.Math.Sigma"			, "sigma"	, new Type   [] { typeof ( int    ) } },
			    } ;
			# endregion
		
			
			/// <summary>
			/// Evaluates a built-in function, or call the FunctionEvaluator delegate if the function
			/// does not exist.
			/// </summary>
			/// <param name="name">Function name.</param>
			/// <param name="argv">Function arguments/</param>
			/// <returns>Function result.</returns>
			public Symbol  BuiltInFunctionEvaluator ( String  name, params Symbol []  argv )
			   {
				// Result symbol
				Symbol			result		=  new Symbol ( "", 0.0, SymbolType. Result ) ;

				// Fully qualified name of the C# function corresponding to the called function "name"
				String			csharp_function =  null ;
				Type []			argtypes	=  null ;


				// Try to locate the function in the built-in function table
				for  ( int  i = 0 ; i < BuiltInFunctionTable. GetLength ( 0 ) ; i ++ )
				    {
					argtypes  = ( Type [] ) BuiltInFunctionTable [i,2] ;

					// Check that both names and argument count match.
					if  ( ( String ) BuiltInFunctionTable [i,1]  ==  name  &&
					       argv. Length  ==  argtypes. Length )
					    {
						csharp_function = ( String ) BuiltInFunctionTable  [i,0] ;
						break ;
					     }
				     }

				// If not found, set an error and leave
				if  ( csharp_function  ==  null )
				   {
					SetError ( Resources. Localization. Classes. Math. XMathExprInvalidFunction,
							name, argv. Length. ToString ( ) ) ;

					result. Type	=  SymbolType. Error ;
					return ( result ) ;
				    }

				// If argument count differ, also set an error and leave
				if  ( argtypes. Length  !=  argv. Length )
				   {
					SetError ( Resources. Localization. Classes. Math. XMathExprIncorrectArgc,
							name, 
							argtypes. Length. ToString ( ),
							argv. Length. ToString ( ) ) ;

					result. Type	=  SymbolType. Error ;
					return ( result ) ;
				    }


				// Isolate the namespace/class and method names
				char []			sep		=  new char [] { '.' } ;
				String []		elements	=  csharp_function. Split ( sep ) ;
				String			typename,
							function ;

				// If a namespace/class are specified, use it
				if  ( elements. Length > 1 )
					typename = String. Join ( ".", elements, 0, elements. Length - 1 ) ;
				// Otherwise assume the function is in this class
				else
					typename = this. GetType ( ). Name ;

				function = elements [ elements. Length - 1 ] ;	// Last element is function name


				// Get type and method information using the argument type array declared
				// in the built-in function table
				Type			type		=  Type. GetType ( typename, true ) ;
				MethodInfo		method		=  type. GetMethod ( function, 
											BindingFlags. NonPublic		|
											BindingFlags. Public		|
											BindingFlags. Static,
											null, argtypes, null ) ;

				// Check that the method is defined
				if  ( method  ==  null )
				    {
					SetError ( Resources. Localization. Classes. Math. XMathExprCorruptedFunctionTable,
							function, typename ) ;

					result. Type	=  SymbolType. Error ;
					return ( result ) ;
				     }

				// Create an array of values for function arguments
				object []		arguments	=  new object [ argv. Length ] ;

				for  ( int  i = 0 ; i < argv. Length ; i ++ )
					arguments [i] = Convert. ChangeType ( argv [i]. Value, argtypes [i] ) ;

				// Invoke the method
				try   { result. Value = ( double ) method. Invoke ( null, arguments ) ; }
				catch { throw ; }
				//catch ( Exception  x )
				//   { SetError ( "Invalid call to function '" + function + "' : " + x. Message ) ; }

				// Last try : call the user-defined callback
				if  ( Error  &&  p_FunctionEvaluator  !=  null ) 
					result = p_FunctionEvaluator ( name, argv ) ;

				// All done, return the result
				return ( result ) ;
			    }
			# endregion


			# region Built-in constants

			# region Constant table
			/// <summary>
			/// List of predefined math constants.
			/// </summary>
			private Object [,]		ConstantTable	=  new Object [,]
			   {
				{ "e"		, System. Math. E		},
				{ "pi"		, System. Math. PI		}
			    } ;
			# endregion


			/// <summary>
			/// Retrieves the value of a math constant.
			/// </summary>
			/// <param name="name">Constant name.</param>
			/// <param name="value">On output, this parameter is set to the specified constant value.</param>
			/// <returns>True if the constant has been found, false otherwise.</returns>
			/// <remarks>If the constant does not exist, the contents of the 
			/// <paramref name="value"/> parameter remain unchanged.</remarks>
			protected bool	ConstantEvaluator ( String  name, out double  value )
			   {
				value = 0 ;

				for  ( int  i = 0 ; i < ConstantTable. GetLength ( 0 ) ; i ++ )
				   {
					if  ( ( String ) ConstantTable [i,0]  ==  name )
					   {
						value = ( double ) ConstantTable [i,1] ;
						return ( true ) ;
					    }
				    }

				return ( false ) ;
			    }
			# endregion


			# region Binary operator evaluation
			/// <summary>
			/// Evaluates the expression : [left] [op] [right].
			/// <para>
			/// If <paramref name="left"/> or <paramref name="right"/> is not numeric, then
			/// the expression is evaluated as a string.
			/// </para>
			/// </summary>
			/// <param name="left">Left operand.</param>
			/// <param name="op">Binary operator.</param>
			/// <param name="right">Right operand.</param>
			/// <returns>The result of the binary operator <paramref name="op"/> applied to its operands.</returns>
			protected Symbol  BinaryOperation ( Symbol  left, Symbol  op, Symbol  right )
			   {
				// Result value
				Symbol		result	=  new  Symbol ( "(result)", 0, SymbolType. Result ) ;

				result. Value = BinaryOperation ( left. Value, op. Name, right. Value ) ; 

				// If the evaluation led to an error, then the resulting symbol will
				// be an error as well...
				if  ( Error )
					result. Type  =  SymbolType. Error ;

				// All done, return the result symbol
				return ( result ) ;
			    }


			/// <summary>
			/// Performs the specified operation between two numeric operands.
			/// </summary>
			/// <param name="left">Left operand.</param>
			/// <param name="op">Binary operator.</param>
			/// <param name="right">Right operand.</param>
			/// <returns>The result of the operation : left op right.</returns>		
			protected double  BinaryOperation ( double  left, String  op, double  right )
			   {
				long		lleft, lright ;


				switch ( op )
				   {
					// Operator "^" or "**" : compute [left] power [right]
					case  "**"	:
						return ( System. Math. Pow ( left, right ) ) ;

					// Operator "/" : Divide [left] by [right]
					case  "/"	:
						if  ( right  ==  0 )
						   {
							SetError ( Resources. Localization. Classes. Math. XMathDividByZero ) ;
							return ( double. NaN ) ;
						    }
						return ( left / right ) ;

					// Operator "\" : Integer division of [left] by [right]
					case  "\\"	:
						left   =  System. Math. Floor ( left ) ;
						right  =  System. Math. Floor ( right ) ;

						if  ( right  ==  0 )
						   {
							SetError ( Resources. Localization. Classes. Math. XMathDividByZero ) ;
							return ( double. NaN ) ;
						    }
						return ( System. Math. Floor ( left / right ) ) ;
			
				
					// Operator "*" : multiply [left] by [right]
					case  "*"	:
						return ( left * right ) ;

					// Operator "%" : compute the modulo of [left] divided by [right]
					case  "%"	: 
						return ( left % right ) ; 
								
					// Operator "+" : returns [left] plus [right]
					case  "+"	:
						return ( left + right ) ;

					// Operator "-" : returns [left] minus [right]
					case  "-"	:
						return ( left - right ) ;

					// Boolean operator "||" : returns [left] || [right]
					case  "||"	:
						return ( ( left  !=  0  ||  right  !=  0  ) ? 1 : 0 ) ;				

					// Boolean operator "&&" : returns [left] && [right]
					case  "&&"	:
						return ( ( left  !=  0  &&  right  !=  0  ) ? 1 : 0 ) ;				

					// Boolean operator "==" : returns [left] == [right]
					case  "=="	:
						return ( ( left  ==  right ) ? 1 : 0 ) ;				

					// Boolean operator "!=" : returns [left] != [right]
					case  "!="	:
						return ( ( left  !=  right ) ? 1 : 0 ) ;				

					// Boolean operator "<" : returns [left] < [right]
					case  "<"	:
						return ( ( left  <  right ) ? 1 : 0 ) ;				

					// Boolean operator "<=" : returns [left] <= [right]
					case  "<="	:
						return ( ( left  <=  right ) ? 1 : 0 ) ;				

					// Boolean operator ">=" : returns [left] >= [right]
					case  ">="	:
						return ( ( left  >=  right ) ? 1 : 0 ) ;				

					// Boolean operator ">" : returns [left] > [right]
					case  ">"	:
						return ( ( left  >  right ) ? 1 : 0 ) ;				

					// Bitwise operator "&" : returns [left] & [right]
					case  "&" :
						lleft	= ( long ) left ;
						lright  = ( long ) right ;
						return ( ( double ) ( lleft  &  lright ) ) ;

					// Bitwise operator "|" : returns [left] | [right]
					case  "|" :
						lleft	= ( long ) left ;
						lright  = ( long ) right ;
						return ( ( double ) ( lleft  &  lright ) ) ;

					// Bitwise operator "^" : returns [left] ^ [right] (XOR)
					case  "^" :
						lleft	= ( long ) left ;
						lright  = ( long ) right ;
						return ( ( double ) ( lleft  ^  lright ) ) ;

					// Default : unexpected operator
					default		:
						SetError ( Resources. Localization. Classes. Math. XMathExprInvalidOperator , op ) ;
						return ( double. NaN ) ;
				    }
			    }
			# endregion


			# region Infix to Postfix related methods
			/// <summary>
			/// Converts the infix expression into postfix notation.
			/// </summary>
			protected void  InfixToPostfix ( )
			   {
				Symbol			stack_symbol		=  null ;
				Stack<Symbol>		symbol_stack		=  new Stack<Symbol> ( ) ;


				// Check if the first symbol is a sign
			
				// Loop through the parsed symbols
				for  ( int  symindex = 0 ; symindex < p_Equation. Count ; symindex ++ )
				   {
					Symbol		symbol	= p_Equation [symindex] ;

					// Push every literal, variable name or unary operator
					if  ( symbol. Type  ==  SymbolType. Value    ||
					      symbol. Type  ==  SymbolType. Variable ||
					      symbol. Type  ==  SymbolType. Unary )
						p_PostfixEquation. Push ( symbol ) ;
					// If an opening parenthesis is found, we start to push symbols
					// on the local stack from here
					else if  ( symbol. Name  ==  "(" )
						symbol_stack. Push ( symbol ) ;
					// End of parenthized group : push parenthized group in reverse order
					else if  ( symbol. Name  ==  ")" )
					   {
						if  ( symbol_stack. Count  >  0 )
						   {
							stack_symbol = symbol_stack. Pop ( ) ;

							while  ( stack_symbol. Name  !=  "(" )
							   {
								p_PostfixEquation. Push ( stack_symbol ) ;
								stack_symbol = symbol_stack. Pop ( ) ;
							    }
						    }
					    }
					// Other kind of symbol
					else
					   {
						if  ( symbol_stack. Count  >  0 )
						   {
							stack_symbol = symbol_stack. Pop ( ) ;

							while  ( ( symbol_stack. Count  !=  0 )  &&
									( stack_symbol. Type  ==  SymbolType. Operator  ||
									  stack_symbol. Type  ==  SymbolType. Function  ||
									  stack_symbol. Type  ==  SymbolType. Comma )  &&
									( Precedence( stack_symbol ) >= Precedence ( symbol ) ) )
							   {
								p_PostfixEquation. Push ( stack_symbol ) ;
								stack_symbol = symbol_stack. Pop ( ) ;
							    }

							if  ( ( stack_symbol. Type  ==  SymbolType. Operator  ||
								stack_symbol. Type  ==  SymbolType. Function  ||
								stack_symbol. Type  ==  SymbolType. Comma )  &&
								( Precedence( stack_symbol ) >= Precedence ( symbol ) ) )
								p_PostfixEquation. Push ( stack_symbol ) ;
							else
								symbol_stack. Push ( stack_symbol ) ;
						    }

						symbol_stack. Push ( symbol ) ;

					    }
				    }

				// Symbols are remaining on the local stack : push them to the postfix stack
				while  ( symbol_stack. Count > 0 )
				   {
					stack_symbol = symbol_stack. Pop ( ) ;
					p_PostfixEquation. Push ( stack_symbol ) ;
				    }
			    }


			/// <summary>
			/// Preprocesses unary operators.
			/// </summary>
			/// <param name="input">Input stack.</param>
			/// <param name="output">Output stack.</param>
			private Stack<Symbol>  ProcessUnaries ( Stack<Symbol>  stack )
			   {
				// Paranoid checks
				if  ( stack. Count  ==  0 )
					return ( stack ) ;

				// Local variables
				Stack<Symbol>	output		=  new Stack<Symbol> ( ) ;
				int		index		=  0 ;

				// Main loop
				while  ( index  <  stack. Count )
					index = ProcessUnary ( output, stack, index ) ;

				// Return the preprocess stack
				return ( output ) ;
			    }


			/// <summary>
			/// Preprocess subexpressions.
			/// </summary>
			/// <param name="output">Output stack.</param>
			/// <param name="input">Input stack.</param>
			/// <param name="index">Starting index in input stack.</param>
			/// <returns>New current index.</returns>
			private int  ProcessUnary ( Stack<Symbol>  output, Stack<Symbol>  input, int  index )
			   {
				// If we reached the end of stack, return
				if  ( index  >=  input. Count )
					return ( 0 ) ;

				// Current and previous symbols ; comparing the current and previous allows us
				// to determine if an operator is a unary operator or not
				Symbol		current		=  input [index] ;
				Symbol		previous	=  ( index  ==  0 ) ?  null : input [index - 1] ;

				// If we find a unary operator...
				if  ( IsUnary ( current, previous ) )
				   {
					// Keep it in mind and process next sub-expression
					index  = ProcessUnary ( output, input, index + 1 ) ;

					// If the unary operator is the negative operator, push the Negate operation
					// onto the stack
					if  ( current. Name  ==  "-" )
						output. Push ( new Symbol ( "-", -1, SymbolType. Unary ) ) ;

					// Return the index of the next sub-expression
					return ( index ) ;
				    }
				  
				// If the current symbol is neither a function nor a block enclosed in
				// parentheses then add it to the output stack and return
				if  ( current. Type  !=  SymbolType. Function  &&
				      current. Name  !=  "(" )
				   {
					output. Push ( current ) ;
					return ( index + 1 ) ;
				    }

				// If the current symbol is a function, push the symbol to the output stack
				if  ( current. Type  ==  SymbolType. Function )
				   {
					output. Push ( current ) ;
					index ++ ; 

					// Return if we met the end of the input stack ; it means that the input
					// expression ends with a zero-parameter function call
					if  ( index >= input. Count )
						return ( index ) ;

					// Otherwise, proceed with next symbol
					current = input [index] ;
				    }

				// If we find the beginning of a block enclosed in parentheses, then we will
				// have to recursively process its inner elements
				if  ( current. Name  ==  "(" )
				   {
					// Whatever happens, push the current symbol to the output stack
					output. Push ( current ) ;
					index ++ ;

					// Proceed with the input stack until we find a closing parenthesis
					while  ( index  <  input. Count )
					   {
						current  =  input [index] ;

						// Closing parenthesis found : return
						if  ( current. Name  ==  ")" )
						   {
							output. Push ( current ) ;
							return ( index + 1 ) ;
						    }
						// Otherwise, recursively process the block inner elements
						else
							index  =  ProcessUnary ( output, input, index ) ;
					    }

					return ( index ) ;
				     }
				// We should never arrive here but who knows ?
				else
				   {
					output. Push ( current ) ;
					return ( index + 1 ) ;
				    }
			    }

			private bool  IsUnary ( Symbol  current, Symbol  previous )
			   {
				if  ( current. Type  ==  SymbolType. Operator )
				   {
					if  ( previous  ==  null ) 
						return ( true ) ;
					if  ( previous. Type  ==  SymbolType. Operator  ||
					      previous. Type  ==  SymbolType. Comma     ||
					      previous. Name  ==  "(" )
						return ( true ) ;
				    }
				return ( false ) ;
			    }
			# endregion

			# endregion


			# region Helper methods
			/// <summary>
			/// Sets the Error property to true, and the ErrorDescription property
			/// to the specified message.
			/// </summary>
			/// <param name="message">Error message.</param>
			protected void  SetError ( String  message, params Object []  argv )
			   {
				p_Error			= true ;
				p_ErrorDescription	= String. Format ( message, argv ) ;
			    }


			/// <summary>
			/// Sets the Error property to false, and the ErrorDescription property
			/// to "Success".
			/// </summary>
			protected void  SetSuccess ( )
			   { 
				p_Error			= false ;
				p_ErrorDescription	= "Success" ;
			    }


			/// <summary>
			/// Converts an unsigned float token to a double value.
			/// </summary>
			/// <param name="value">String token to convert.</param>
			/// <returns>The converted value.</returns>
			private double  TokenAsFloat ( String  value )
			   {
				// Default return value is NaN
				Double		result		=  Double. NaN ;
				// Get a copy of the current culture info, because I don't want to bother
				// with decimal points written as "," or as "."
				CultureInfo	culture		=  ( CultureInfo ) CultureInfo. InstalledUICulture. Clone ( )  ;


				// Set the decimal point for string to double conversions
				culture. NumberFormat. NumberDecimalSeparator = "." ;
				// Replace any comma in the input string with a real decimal point
				value. Replace ( ',', '.' ) ;

				// Convert the value
				try { result = Double. Parse ( value, culture ) ; }
				catch { SetError ( Resources. Localization. Classes. Math. XMathExprInvalidFloat , value ) ; }

				// Returns the result
				return ( result ) ;
			     }


			/// <summary>
			/// Converts an unsigned integer token to a double value. The integer
			/// token can be expressed in hexadecimal (prefixed by "0x"), in decimal
			/// (prefixed by "0d" or nothing), octal (prefixed by "0o") or binary
			/// (prefixed by "0b").
			/// </summary>
			/// <param name="value">Integer token to convert.</param>
			/// <returns>The converted value.</returns>
			private double  TokenAsInteger ( String  value )
			   {
				int		nbase	=  10 ;
				int		start	=  0 ;
				long		result  =  0 ;

					
				// If the token value is at least 2 characters, then there may be 
				// a base specified in it (0x, 0d, 0o or 0b)
				if  ( value. Length  >  1 )
				   {
					// It starts with a zero...
					if  ( value [0]  ==  '0' )
					    {
						// And may be followed by a character indicating the base
						switch ( Char. ToLower ( value [1] ) )
						   {
							case 'd'	: nbase = 10 ; start = 2 ; break ;
							case 'x'	: nbase = 16 ; start = 2 ; break ;
							case 'o'	: nbase = 8  ; start = 2 ; break ;
							case 'b'	: nbase = 2  ; start = 2 ; break ;
						    }
					    }
				    }

				// Convert the input value
				for  ( int  i = start ; i < value. Length ; i ++ )
				   {
					Char	Ch	=  value [i] ;
					long    Digit	=  ( Ch  >=  '0'  &&  Ch  <=  '9' ) ? 
								Ch - '0' :
								Ch - 'A' + 10 ;

					result = ( result * nbase ) + Digit ;
				    }

				// All done, return the converted value
				return ( ( double ) result ) ;
			    }
			# endregion
		    }
		# endregion
	    }
    }