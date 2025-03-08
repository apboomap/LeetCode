namespace LeetCode._0001_0050
{
    public  class _014_Longest_Common_Prefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string result = "";
            int j = 0;
            if (!strs.Any()) return result;
            while (strs[0].Length  > j)
            {
                char _char = strs[0][j];
                for (int i = 1; i < strs.Length ; i++)
                {
                    if (j >= strs[i].Length) return result;
                    else if (strs[i][j] != _char)
                    { 
                        return result;
                    }
                }
                j++;
                result += _char;
            }
            return result;
        }
    }
}
