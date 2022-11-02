using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 999999; i++)
            {
                int groupp1 = i / 1000;
                int groupp2 = i % 1000;
                groupp1 = Sum(groupp1);
                groupp2 = Sum(groupp2);

                if (groupp1 == groupp2)
                {
                    int sq1 = Rezult(i, groupp1);
                    if (sq1 > 0)
                    {
                        Console.WriteLine("Сумма первых трх цифр = {0}, степень ={2} номер билета: {1}", groupp1, i, sq1);
                        count++;
                    }
                    int sq2 = Rezult(i, groupp2);
                    if (sq2 > 0 && sq1 == 0)
                    {
                        Console.WriteLine("Сумма первых трх цифр = {0}, степень ={2} номер билета: {1}", groupp1, i, sq2);
                        count++;
                    }
                }
            }
            Console.WriteLine("Количество билетов = {0}", count);
        }
        static int Sum(int groupp)
        {
            int number1 = groupp / 100;
            int number2 = groupp / 10 - number1 * 10;
            int number3 = groupp % 10;
            return number1 + number2 + number3;
        }
        static int Rezult(int i, int groupp)
        {
            int grouppTop = groupp;
    
                int sq = 2;
                while (grouppTop <= i)
                {
                    grouppTop = grouppTop * groupp;
                    if (grouppTop == 1 || grouppTop == 0)  return 0;
                    //Console.WriteLine(grouppTop);
                    if (grouppTop == i)
                    {
                        
                        return sq;
                    }
                    sq++;
                }
                return 0;
     
        }

    }
}
