using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresProject
{
    public class Circle : IFigure
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }
        public double CalculateSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
