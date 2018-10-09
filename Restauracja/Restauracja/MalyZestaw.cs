using System;
namespace Restauracja
{
    public class MalyZestaw : Zestaw
    {
        public override double ObliczKoszt()
        {
            return 1.00;
        }

        public override string PobierzNazwe()
        {
            return "Mały zestaw zawiera: ";
        }
    }
}