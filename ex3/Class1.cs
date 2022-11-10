using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Point P1 = new Point();
            Point P2 = new Point();
            Point P3 = new Point();


            Console.WriteLine("Entrez l'abscisse de 1ere point");
            P1.Abs = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez l'ordonnee de 1ere point");
            P1.Ord = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez l'abscisse de 2eme point");
            P2.Abs = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez l'ordonnee de 2eme point");
            P2.Ord = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez l'abscisse de 3eme point");
            P3.Abs = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez l'ordonnee de 3eme point");
            P3.Ord = int.Parse(Console.ReadLine());
            //______Distance_____//
            // Console.WriteLine("la distance entre ces deux points est :" + Distance(P1, P2));
            //____Egalité____//
            //Egalité(P1, P2);
            //_____Translation___//
            //Translation(P1);
            //____Linéarité____//
            // Linéarité(P1, P2, P3);
        }
    }
}
