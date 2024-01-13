namespace LeetCode
{
    public class _013_Roman_to_Integer
    {
        public int RomanToInt(string s)
        {
            var result = 0;
            if (s.Length < 1 || s.Length > 15) throw new ArgumentException("String input length 1 to 15.");
            var dic = new Dictionary<char, int>();
            dic['I'] = 1;
            dic['V'] = 5;
            dic['X'] = 10;
            dic['L'] = 50;
            dic['C'] = 100;
            dic['D'] = 500;
            dic['M'] = 1000;

            
            for (int i = 0; i<s.Length; i++)
            {
                if (!dic.TryGetValue(s[i], out _)) throw new ArgumentException("String input contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').");
                if (i != 0 && dic[s[i]] > dic[s[i - 1]])
                {
                    result = result + dic[s[i]] - (2 * dic[s[i - 1]]);
                }
                else
                {
                    result += dic[s[i]];
                }
            }

            return result;
        }
    }
}
