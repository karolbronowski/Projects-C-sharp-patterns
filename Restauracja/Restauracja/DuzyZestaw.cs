using System;
namespace Restauracja
{
    public class DuzyZestaw : Zestaw
    {
        public override double ObliczKoszt()
        {
            return 5.00;
        }

        public override string PobierzNazwe()
        {
            return "Duża zestaw zawiera: ";
        }
    }
}