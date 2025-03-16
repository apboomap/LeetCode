using System.Globalization;

namespace LeetCode._0001_0050;

public class _0012_Integer_to_Roman
{
    private Dictionary<int, char> dic;
    public _0012_Integer_to_Roman()
    {
        dic = new();
        dic[1] = 'I';
        dic[5] = 'V';
        dic[10] = 'X';
        dic[50] = 'L';
        dic[100] = 'C';
        dic[500] = 'D';
        dic[1000] = 'M';

    }
    public string IntToRoman(int num) 
    {
        if (num < 1 || num > 3999) throw new ArgumentException("1 <= Input(num) <= 3999");
        string result = "";
        int divide =  (int)Math.Pow(10 , num.ToString().Length -1);
        while (divide != 0)
        {
            int mutiple = num / divide;

            if (mutiple < 4) // 1-3
            {
                result += new string(dic[divide], mutiple);
            }
            else if (mutiple == 4)
            {
                result += dic[divide].ToString() + dic[divide * 5].ToString();
            }
            else if (mutiple == 9)
            {
                result += dic[divide].ToString() + dic[divide * 10].ToString();
            }
            else //5-8
            {
                result += dic[divide * 5].ToString() + new string(dic[divide], mutiple - 5);
            }

            num -= mutiple * divide;
            divide /= 10;
        }

        return result;
    }

    // public string IntToRoman(int num)
    // {
    //     if (num < 1 || num > 3999)
    //         throw new ArgumentException("Input must be between 1 and 3999");

    //     // Define Roman numeral symbols and their values in descending order
    //     var romanValues = new[]
    //     {
    //         (1000, "M"),
    //         (900, "CM"),
    //         (500, "D"),
    //         (400, "CD"),
    //         (100, "C"),
    //         (90, "XC"),
    //         (50, "L"),
    //         (40, "XL"),
    //         (10, "X"),
    //         (9, "IX"),
    //         (5, "V"),
    //         (4, "IV"),
    //         (1, "I")
    //     };

    //     string result = "";
        
    //     // Iterate through value-symbol pairs
    //     foreach (var (value, symbol) in romanValues)
    //     {
    //         // While the number is greater than or equal to current value
    //         while (num >= value)
    //         {
    //             result += symbol;
    //             num -= value;
    //         }
    //     }

    //     return result;
    // }
}