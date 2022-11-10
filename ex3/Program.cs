using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Program
    {
            static public void Linéarité(Point P1, Point P2, Point P3)
            {
                double a, b;
                if (P1.Abs != P2.Abs) //on va montrer d'abord que 2 point sont alignees
                {
                    a = (P1.Ord - P2.Ord) / (P1.Abs - P2.Abs);
                    b = P1.Ord + a * P1.Abs;   //determiner l'equation de la droite y=ax+b
                    if (a * P3.Abs + b == P3.Ord)//verifier l'appartenence du 3eme point a la droite (P1P2) 
                    {
                        Console.WriteLine("les 3 points sont lineaire");
                    }
                    else
                        Console.WriteLine("les 3 points ne sont pas lineaire");
                }
            }
    }
}
