using System;
namespace Restauracja
{
    public class Ziemniaki : ZestawDecorator
    {
        public Ziemniaki(Zestaw zestaw) : base(zestaw)
        {

        }

        public override double ObliczKoszt()
        {
            return base.ObliczKoszt() + 3.90;
        }

        public override string PobierzNazwe()
        {
            return base.PobierzNazwe() + "ziemniaki";
        }
    }
}