using System.Diagnostics;

namespace SredArifm
{
    public class TestArifm
    {
        public double arifm()
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
                Console.WriteLine("Введите значение: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            double sred = sum / count;
            Debug.WriteLine(sred);
            return sred;
        }
    }
}
