using System;
namespace Restauracja
{
    public class Marchweka : ZestawDecorator
    {
        public Marchweka(Zestaw zestaw) : base(zestaw)
        {

        }
        public override double ObliczKoszt()
        {
            return base.ObliczKoszt() + 2.90;
        }

        public override string PobierzNazwe()
        {
            return base.PobierzNazwe() + ", marchewka";
        }
    }
}