using System;
namespace Restauracja
{
    public class ZestawDecorator : Zestaw
    {
        protected Zestaw _zestaw;        //obiekt który będzie dekorowany

        public ZestawDecorator(Zestaw zestaw)
        {
            _zestaw = zestaw;
        }
        public override double ObliczKoszt()
        {
            return _zestaw.ObliczKoszt();
        }

        public override string PobierzNazwe()
        {
            return _zestaw.PobierzNazwe();
        }
    }
}