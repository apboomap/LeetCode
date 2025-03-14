using System.Security.Cryptography.X509Certificates;

namespace LeetCode._0001_0050;

public class _0007_Reverse_Integer{
    /// <summary>
    /// ค่า x เป็น int 32 bit ระหว่าง [-2^31, 2^31] หากอยู่นอกนี้ให้ เป็น 0
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public int  Reverse(int x) {
      int result = 0;
      while (x != 0)
      {
        int before = result;
        result = result * 10 + (x % 10);
        if (result / 10 != before) return 0;
        x /= 10;
      }

      return result;
    }

}