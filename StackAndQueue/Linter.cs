using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Linter
    {
        private bool IsOpeningBrace(char ch)
        {
            switch (ch)
            {
                case '[':
                case '{':
                case '(':
                    return true;
                default:
                    return false;
            }
        }

        private bool IsClosingBrace(char ch)
        {
            switch (ch)
            {
                case ']':
                case '}':
                case ')':
                    return true;
                default:
                    return false;
            }
        }

        private bool IsCorrespondingBrace(char brace, char corresponding)
        {
            switch (brace)
            {
                case '[':
                    if (corresponding == ']') return true;
                    break;
                case '{':
                    if (corresponding == '}') return true;
                    break;
                case '(':
                    if (corresponding == ')') return true;
                    break;
            }

            return false;
        }

        public bool IsBraceSyntaxCorrect(string code)
        {
            var stack = new MyStack<char>(code.Length / 2 + 1);

            foreach (var ch in code)
            {
                if (IsOpeningBrace(ch))
                {
                    stack.Push(ch);
                    continue;
                }
                if (IsClosingBrace(ch))
                {
                    if (stack.IsEmpty())
                        return false;
                    if (!IsCorrespondingBrace(stack.Pop(), ch))
                        return false;
                }
            }

            if (!stack.IsEmpty())
                return false;

            return true;
        }
    }
}
