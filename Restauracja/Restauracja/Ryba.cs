using System;
namespace Restauracja
{
    public class Ryba : ZestawDecorator
    {
        public Ryba(Zestaw zestaw) : base(zestaw)
        {

        }

        public override double ObliczKoszt()
        {
            return base.ObliczKoszt() + 9.90;
        }

        public override string PobierzNazwe()
        {
            return base.PobierzNazwe() + ", ryba";
        }
    }
}