using System;
using System.Collections.Generic;
using System.Text;

namespace Day13GenericsAssg
{
    class UC2_Generics
    {
        public static double MaxFloatNum(double Num1, double Num2, double Num3)
        {
            if ((Num1).CompareTo(Num2) > 0 && (Num1).CompareTo(Num3) > 0)
            {
                return Num1;
            }
            if (Num2.CompareTo(Num1) > 0 && Num2.CompareTo(Num3) > 0)
            {
                return Num2;
            }
            if (Num3.CompareTo(Num1) > 0 && Num3.CompareTo(Num2) > 0)
            {
                return Num3;
            }
            throw new Exception("Num1, Num2, Num3 are same");
        }
    }
}
