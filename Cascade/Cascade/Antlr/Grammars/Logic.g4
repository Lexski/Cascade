grammar Logic;

/*
 * Parser Rules
 */

rule: unaryComparator expression
| expression binaryComparator expression
;

expression: unaryOperator expression
| expression binaryOperator expression
| '(' expression ')'
| Identifier
;

binaryOperator: OP2_And | OP2_Or | OP2_Xor;

unaryOperator: OP1_Not;

binaryComparator: CP2_Implies | CP2_Iff | CP2_Excludes;

unaryComparator: CP1_CoversAllCases;


/*
 * Lexer Rules
 */

// Operators
OP2_And: '&';
OP2_Or: '|';
OP2_Xor: '^';
OP1_Not: '!';

// Comparators
CP2_Implies: '=>';
CP2_Iff: '<=>';
CP2_Excludes: '$';
CP1_CoversAllCases: '@';

// Numbers and identifiers
Identifier: [a-zA-Z_]+ [a-zA-Z_0-9]*;

WS
	:	[ \r\n\t] -> channel(HIDDEN)
	;
