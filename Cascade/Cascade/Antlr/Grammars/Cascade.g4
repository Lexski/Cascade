grammar Cascade;

import Logic;

/*
 * Parser Rules
 */

// Call this to parse fully
command: declare | assert | generate | save;


// Commands
declare: KW_Declare predicateName=Identifier aliasClause? KW_As? TP_Predicate				#DeclarePredicateNoFormula
| KW_Declare predicateName=Identifier aliasClause? KW_As? TP_Predicate expressionClause		#DeclarePredicateWithFormula
| KW_Declare testName=Identifier aliasClause? KW_As? TP_Test expressionClause				#DeclareTest
;

assert: KW_Assert rule;

generate: KW_Generate;

save: KW_Save FilePath;


// Clauses
aliasClause: '(' KW_Alias alias=Identifier ')';
expressionClause: '(' expression ')';


/*
 * Lexer Rules
 */

// Comments
Comment: '--'.* -> channel(HIDDEN);

// Keywords
KW_Declare: 'declare';
KW_Assert: 'assert';
KW_Generate: 'generate';
KW_Save:  'save';
KW_Alias: 'alias';
KW_As: 'as';

// Cascade data types
TP_Predicate: 'predicate';
TP_Test: 'test';

// General
Identifier: [a-zA-Z_]+ [a-zA-Z_0-9]*;
FilePath: '"'[a-zA-Z_0-9:/.\\ ]+'"';

// White space
WS
	:	[ \r\n\t] -> channel(HIDDEN)
	;
