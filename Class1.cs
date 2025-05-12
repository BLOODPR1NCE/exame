using System.Diagnostics;

namespace SredArifm
{
    public class TestArifm
    {
        public double arifm2(int[] nums)
        {
            int sum = 0;
            int count = 0;
            foreach (int num in nums)
            if (num != 0)
            {
                if (num < 0)
                {
                    sum = sum + num;
                    count++;
                    Debug.WriteLine(sum);
                }
            }
                else
                {
                    break;
                }
            double sred = sum / count;
            Debug.WriteLine(sred);
            return sred;
        }
    }
}
