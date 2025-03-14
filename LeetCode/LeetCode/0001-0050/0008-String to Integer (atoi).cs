namespace LeetCode._0001_0050;

public class _0008_String_to_Integer_atoi
{
    public int MyAtoi(string s) 
    {
        s = s.TrimStart();
        int startIndex = 0;
        int mutiple = 1;
        int lenght = s.Length;
        if (lenght > 0)
        {
            if (s[0] == '-')
            {
                mutiple *= -1;
                startIndex = 1;
            }

            if (s[0] == '+')
            {
                mutiple *= 1;
                startIndex = 1;
            }
        }
        int result = 0;
        for (int i = startIndex; i<s.Length; i++) 
        {

            if (int.TryParse(s[i].ToString(), out int value))
            {
                int before = result;
                result =  (result * 10) + value;
                if (result/10 != before) return mutiple == 1 ? int.MaxValue : int.MinValue; // check overflow int
            }
            else
            {
                break;
            }
        }

        return result * mutiple;
    }
}