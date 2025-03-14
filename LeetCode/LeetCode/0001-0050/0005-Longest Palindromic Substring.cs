namespace LeetCode._0001_0050
{
    public class _0005_Longest_Palindromic_Substring
    {
        /// <summary>
        /// ตาราง dp
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        //    b a b a d b
        // b [T,F,T,F,F,F]
        // a [ ,T,F,T,F,F]
        // b [ , ,T,F,F,F]
        // a [ , , ,T,F,F]
        // d [ , , , ,T,F]
        // b [ , , , , ,T]
        public string LongestPalindrome(string s) 
        {
            int n = s.Length;
            string longestPalindrome  = "";
            bool[,] dp = new bool[n,n];
            // หาตัวอักษรยาว length
            for (int length = 1; length <= n; length++)
            {
                //i = ตัวอักษรเเนวยาว,
                for (int i=0; i <= n-length; i++){
                    // j ค่าเเนวตั้งก่อนหน้า
                    int j = i + length - 1;

                    if 
                    (
                        s[i] == s[j]
                        && 
                        (
                            length <= 2 // เช่น bb lenght = 2, i = 0, j = 1
                            || dp[i + 1, j - 1] // เช่น bab lenght = 3, i = 0, j = 2
                        )
                    )
                    {
                        dp[i, j] = true;
                        if (length > longestPalindrome.Length)
                        {
                            longestPalindrome = s.Substring(i, length);
                        }
                    }
                }
            }
            return longestPalindrome;
        }

        
      
    }
}