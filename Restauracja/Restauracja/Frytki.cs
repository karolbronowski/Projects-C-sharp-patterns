using System;
namespace Restauracja
{
    public class Frytki : ZestawDecorator
    {
        public Frytki(Zestaw zestaw) : base(zestaw)
        {

        }

        public override double ObliczKoszt()
        {
            return base.ObliczKoszt() + 4.90;
        }

        public override string PobierzNazwe()
        {
            return base.PobierzNazwe() + "frytki";
        }
    }
}