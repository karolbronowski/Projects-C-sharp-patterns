using System;
namespace Restauracja
{
    public class Ogórek : ZestawDecorator
    {
        public Ogórek(Zestaw zestaw) : base(zestaw)
        {

        }
        public override double ObliczKoszt()
        {
            return base.ObliczKoszt() + 1.99;
        }

        public override string PobierzNazwe()
        {
            return base.PobierzNazwe() + ", ogórek";
        }
    }
}