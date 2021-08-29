using System;

namespace PrintTable
{
    class Program
    {
        static void Main(string[] args)
        {
            TablePrint tp = new TablePrint();
            tp.AccNum();
            tp.TableCalculation();
        }
    }
    public class TablePrint
    {
        int i, num, res;
        public void AccNum()
        {
            Console.WriteLine("Enter the number :");
            num = Convert.ToInt32(Console.ReadLine());
        }
        public void TableCalculation()
        {
            for (i = 1; i <= 10; i++)
            {
                
                res = num * i;
                Console.WriteLine(num + " X " + i + " = " + res);
            }
            
        }
    }
}
