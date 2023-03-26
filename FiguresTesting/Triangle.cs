using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresProject
{
    public class Triangle : IFigure
    {
        private double[] _sides;

        public Triangle(double side1, double side2, double side3)
        {
            _sides = new double[3] { side1, side2,side3 };
            Array.Sort(_sides);
        }

        /// <summary>
        /// Method calculate square of triangle. Method dont throw exception if triangle with such sides not exists.
        /// </summary>
        public double CalculateSquare()
        {
            if(isRight())
            {
                return (_sides[1] * _sides[0]) / 2;
            }
            else
            {
                double p = _sides.Sum() / 2;
                return Math.Sqrt(p * (p - _sides[0]) * (p - _sides[1]) * (p - _sides[2]));

            }
        }

        public bool IsExist()
        {
            return _sides[0] < _sides[1] + _sides[2] &&
                _sides[1] < _sides[2] + _sides[0] &&
                _sides[2] < _sides[1] + _sides[0];
        }

        public bool isRight()
        {
            return Math.Pow(_sides[2], 2) == (Math.Pow(_sides[1], 2) + Math.Pow(_sides[0], 2)); 
        }


    }
}
