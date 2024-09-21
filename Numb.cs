using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    public  class Numbers
    {
        public  double Max(double num1, double num2)
        {
            if (num1 > num2)

                return num1;
            else
                return num2;
        }
        public  double Max(double num1, double num2, double num3)
        {
            if((num1 > num2) && (num1>num3))
                return num1;
            if((num2 > num3) && (num2>num1))
                return num2;
            else return num3;
        }
        public  double Max(double num1, double num2, double num3, double num4)
        {
           if((num1 > num2)&&(num1>num3)&&(num1>num4))
                    return num1;
            if((num2 > num3)&&(num2>num4))
                return num2;
            if((num3 > num4) && (num3>num4))
                return num3;
            else return num4;
        }
        public  double Max(double num1, double num2, double num3, double num4, double num5)
        {
           if((num1<num2)&&(num1>num3)&&(num1>num4)&&(num1>num5))
                return num1;
            if ((num2 > num1) && (num2 > num3) && (num2 > num4) && (num2 > num5))
                return num2;
            if((num3 > num4) && (num3 > num5))
                return num3;
            if((num4 > num5) )
                return num4;
            else
            {
                return num5;
            }
        }
    }
}
