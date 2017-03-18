namespace Cascade.Logic
{
    enum FormulaSymbol
    {
        False,           //     truth       value
        True,            //     truth       value
        Predicate,       //     placeholder symbol
        OpenBracket,     // (   open        bracket
        CloseBracket,    // )   close       bracket
        Not,             // !   unary       operator
        And,             // &   binary      operator
        Or,              // |   binary      operator
        Xor,             // ^   binary      operator
        CoversAllCases,  // @   unary       comparator
        Implies,         // =>  binary      comparator
        Iff,             // <=> binary      comparator
        Excludes         // $   binary      comparator
    }
}