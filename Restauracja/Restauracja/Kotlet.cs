using System;
namespace Restauracja
{
    public class Kotlet : ZestawDecorator
    {
        public Kotlet(Zestaw zestaw) : base(zestaw)
        {

        }
        public override double ObliczKoszt()
        {
            return base.ObliczKoszt() + 8.90;
        }

        public override string PobierzNazwe()
        {
            return base.PobierzNazwe() + ", kotlet";
        }
    }
}