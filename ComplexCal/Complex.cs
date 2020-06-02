using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    public class ComplexCal
    {
        float re, im;

        public ComplexCal() { re = 0; im = 0; }

        public ComplexCal(float r, float i) { re = r; im = i; } 

        public float Re
        {
            get { return re; }
            set { re = value; }
        }
        public float Im
        {
            get { return im; }
            set { im = value; }
        }
        public static ComplexCal operator +(ComplexCal a, float b)
            => new ComplexCal(a.Re + b, a.Im);
        public static ComplexCal operator -(ComplexCal a, float b)
            => new ComplexCal(a.Re - b, a.Im);
        public static ComplexCal operator *(ComplexCal a, float b)
            => new ComplexCal(a.Re * b, a.Im * b);
        public static ComplexCal operator /(ComplexCal a, float b)
            => new ComplexCal((a.Re * b) / (b * b),
                           (b * a.Im) / (b * b));
        public static ComplexCal operator +(float a, ComplexCal b)
            => new ComplexCal(a + b.Re, b.Im);
        public static ComplexCal operator -(float a, ComplexCal b)
            => new ComplexCal(a - b.Re, b.Im);
        public static ComplexCal operator *(float a, ComplexCal b)
            => new ComplexCal(a * b.Re, a * b.Im);
        public static ComplexCal operator /(float a, ComplexCal b)
            => new ComplexCal((a * b.Re) / (b.Re * b.Re + b.Im * b.Im),
                           (-a * b.Im) / (b.Re * b.Re + b.Im * b.Im));
        public static ComplexCal operator +(ComplexCal a, ComplexCal b)
            => new ComplexCal(a.Re + b.Re, a.Im + b.Im);
        public static ComplexCal operator -(ComplexCal a, ComplexCal b)
            => new ComplexCal(a.Re - b.Re, a.Im - b.Im);
        public static ComplexCal operator *(ComplexCal a, ComplexCal b)
            => new ComplexCal(a.Re * b.Re - a.Im * b.Im, a.Re * b.Im + b.Re * a.Im);
        public static ComplexCal operator /(ComplexCal a, ComplexCal b)
            => new ComplexCal((a.Re * b.Re + a.Im * b.Im) / (b.Re * b.Re + b.Im * b.Im),
                           (b.Re * a.Im - a.Re * b.Im) / (b.Re * b.Re + b.Im * b.Im));

        public float GetAbs()
        {
            float result = (float)System.Math.Sqrt(this.Re * this.Re + this.Im * this.Im);
            result -= result % 0.00001f;
            return result;
        }

        public float GetArg()
        {
            float result = (float)System.Math.Atan2(this.Im, this.Re);
            result -= result % 0.00001f;
            return result;
        }
    }
}
