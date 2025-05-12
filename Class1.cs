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
                    Debug.WriteLine("Новое число: " + num + ", Временнная сумма: " + sum);
                    Debug.WriteLine("Временное кол-во отрицательных чисел: " + count);
                    }
            }
                else
                {
                    break;
                }
            double sred = sum / count;
            Debug.WriteLine("Итоговая сумма: " + sum);
            Debug.WriteLine("Итоговое кол-во отрицательных чисел: " + count);
            Debug.WriteLine("Итоговое среднее значение: " + sred);
            return sred;
        }
    }
}
