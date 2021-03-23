using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaVlad
{
    public class FloatPower
    {
        private float first;

        public float First
        {
            get { return first; }
            set { first = value; }
        }

        private float second;

        public float Second
        {
            get { return second; }
            set { second = value; }
        }


        public FloatPower(float first, float second)
        {
            First = first;
            Second = second;
        }

        public double Power() => Math.Pow(First, Second);

        public static FloatPower operator ++(FloatPower floatPower)
        {
            return new FloatPower(floatPower.first, floatPower.second + 1);
        }

        public static FloatPower operator --(FloatPower floatPower)
        {
            return new FloatPower(floatPower.first, floatPower.second - 1);
        }

    }
}
