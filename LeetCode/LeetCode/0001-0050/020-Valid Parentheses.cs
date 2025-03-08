namespace LeetCode._0001_0050
{
    public class _020_Valid_Parentheses
    {
        public Dictionary<char, char> open = new Dictionary<char, char>
        {
            ['('] = ')',
            ['{'] = '}',
            ['['] = ']'
        };

        public Dictionary<char, char> close = new Dictionary<char, char>
        {
            
            [')'] = '(',
            ['}'] = '{',
            [']'] = '['
        };
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                stack.TryPeek(out char tmpParenthese);
                if (open.TryGetValue(c, out _))
                {
                    stack.Push(c);
                }
                else if (close.TryGetValue(c, out var value))
                {
                    if (value != tmpParenthese) return false;
                    stack.Pop();
                }
                else 
                {
                    return false;
                }
            }
            return !stack.Any();
        }

    }
}
