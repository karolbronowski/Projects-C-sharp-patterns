using System;

namespace Restauracja
{
    class Program
    {
        static void Main(string[] args)
        {
            Zestaw duzyZestaw = new DuzyZestaw();

            duzyZestaw = new Ziemniaki(duzyZestaw);
            duzyZestaw = new Kotlet(duzyZestaw);
            duzyZestaw = new Marchweka(duzyZestaw);
            duzyZestaw = new Ogórek(duzyZestaw);

            Zestaw malyZestaw = new MalyZestaw();

            malyZestaw = new Frytki(malyZestaw);
            malyZestaw = new Ryba(malyZestaw);
            malyZestaw = new Marchweka(malyZestaw);

            Console.WriteLine("Cena małego zestawu obiadowego: " + "{0:C2}", duzyZestaw.ObliczKoszt());
            Console.WriteLine("Zamówienie: \n" + duzyZestaw.PobierzNazwe());
            Console.WriteLine();

            Console.WriteLine("Cena małego zestawu obiadowegoi: " + "{0:C2}", malyZestaw.ObliczKoszt());
            Console.WriteLine("Zamówienie: \n" + malyZestaw.PobierzNazwe());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}