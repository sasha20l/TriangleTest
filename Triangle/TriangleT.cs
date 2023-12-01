using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    internal class TriangleT
    {
        public string triangleType(double sideA, double sideB, double sideC)
        {
            double maxSide = 0;
            double sidesToDegree = 0;

            if (sideA > sideB)
            {
                if (sideA >= sideC)
                {
                    maxSide = sideA * sideA;
                    sidesToDegree = ((sideB * sideB) + (sideC * sideC));
                }
                else if (sideA < sideC)
                {
                    maxSide = sideC * sideC;
                    sidesToDegree = ((sideB * sideB) + (sideA * sideA));
                }

            }
            else if (sideB >= sideC)
            {
                maxSide = sideB * sideB;
                sidesToDegree = ((sideA * sideA) + (sideC * sideC));
            }
            else if (sideB < sideC)
            {
                maxSide = sideC * sideC;
                sidesToDegree = ((sideB * sideB) + (sideA * sideA));
            }
            else if ((sideA == sideB) && (sideB != sideC))
            {
                if (sideA > sideC)
                {
                    maxSide = sideA * sideA;
                    sidesToDegree = ((sideB * sideB) + (sideC * sideC));
                }
                else
                {
                    maxSide = sideB * sideB;
                    sidesToDegree = ((sideA * sideA) + (sideC * sideC));
                }
            }
            else return "Прямоугольный";

            if (maxSide == sidesToDegree) return "Прямоугольный";
            else if (maxSide < sidesToDegree) return "Остроугольный";
            else return "Тупоугольный";
        }
    }
}
