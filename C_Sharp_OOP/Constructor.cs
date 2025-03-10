using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP
{
    class Constructor
    {
        int num1;
        int num2;
        int num3;

        public Constructor(int num1, int num2, int num3)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }

        public Constructor(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public void display()
        {
            Console.WriteLine(num1 + " " + num2 + " " + num3);
        }
    }
}
