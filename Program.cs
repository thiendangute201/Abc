using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTbac2
{
    class Program
    {
        static void Main(string[] args)
        {
            double aNum, bNum, cNum;
            double delta;
            Console.OutputEncoding = Encoding.Unicode;
            do
            {
                Console.Write("Nhập số a: ");
            } while (Double.TryParse(Console.ReadLine(), out aNum) == false || aNum == 0);
            do
            {
                Console.Write("Nhập số b: ");
            } while (Double.TryParse(Console.ReadLine(), out bNum) == false);
            do
            {
                Console.Write("Nhập số c: ");
            } while (Double.TryParse(Console.ReadLine(), out cNum) == false);
            delta = bNum*bNum - 4*aNum * cNum;
            Console.WriteLine("(Dùng if else)  PT bậc 2: {0}x^2 + {1}x + {2} = 0", aNum, bNum, cNum);
            Console.WriteLine("Delta của PT: " + delta);
            #region
            if (delta < 0)
                Console.WriteLine("PT vô nghiệm");
            else if (delta == 0) {
                double x = -bNum /(2* aNum);
                Console.WriteLine("PT có nghiệm kép x1 = x2 = " + x);
            } else {
                double x1 = (-bNum - Math.Sqrt(delta))/(2*aNum);
                double x2 = (-bNum + Math.Sqrt(delta))/(2*aNum);
                Console.WriteLine("PT có 2 nghiệm: x1 = {0}, x2  = {1}", x1, x2);
            }
            #endregion
            do
            {
                Console.Write("Nhập số a: ");
            } while (Double.TryParse(Console.ReadLine(), out aNum) == false || aNum == 0);
            do
            {
                Console.Write("Nhập số b: ");
            } while (Double.TryParse(Console.ReadLine(), out bNum) == false);
            do
            {
                Console.Write("Nhập số c: ");
            } while (Double.TryParse(Console.ReadLine(), out cNum) == false);
            delta = bNum * bNum - 4 * aNum * cNum;
            Console.WriteLine("(Dùng switch case) PT bậc 2: {0}x^2 + {1}x + {2} = 0", aNum, bNum, cNum);
            Console.WriteLine("Delta của PT: " + delta);
            #region
            switch (delta < 0)
            {
                case true:
                    Console.WriteLine("PT vô nghiệm");
                    break;
                case false:
                    switch(delta == 0)
                    {
                        case true:
                            double x = -bNum / (2 * aNum);
                            Console.WriteLine("PT có nghiệm kép x1 = x2 = " + x);
                            break;
                        case false:
                            double x1 = (-bNum - Math.Sqrt(delta)) / (2 * aNum);
                            double x2 = (-bNum + Math.Sqrt(delta)) / (2 * aNum);
                            Console.WriteLine("PT có 2 nghiệm: x1 = {0}, x2  = {1}", x1, x2);
                            break;
                    }
                    break;
            }      
            #endregion
            Console.ReadKey(true);
        }
    }
}
