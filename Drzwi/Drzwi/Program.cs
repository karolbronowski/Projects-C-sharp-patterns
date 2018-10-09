using System;

namespace Obrotowe
{
    public class Drzwi
    {
        public const int ZAMKNIETE = -1;
        public const int OTWIERANIE = -2;
        public const int OTWARTE = -3;
        public const int ZAMYKANIE = -4;
        public const int NADALOTWARTE = -5;

        //public ZmienObsluge
        private int _stan = ZAMKNIETE;

    public String Status()
    {
        switch (_stan)
        {
            case OTWIERANIE:
                return "Otwieranie";
            case OTWARTE:
                return "Otwarte";
            case ZAMYKANIE:
                return "Zamykanie";
            case NADALOTWARTE;
                return "Pozostają otwarte";
            default:
                return "Zamknięte";
        }
    }

    public void Touch()
    {
        if (_stan == ZAMKNIETE)
        {
            SetStan(OTWIERANIE);
        }
        else if (_stan == OTWIERANIE || _stan == NADALOTWARTE)
        {
            SetStan(ZAMYKANIE);
        }
        else if (_stan == OTWARTE)
        {
            SetStan(NADALOTWARTE);
        }
        else if (_stan == ZAMYKANIE)
        {
            SetStan(OTWIERANIE);
        }
    }

    private void SetStan(int stan)
    {
        this._stan = stan;
        if (Zmien != null) Zmien();
    }

    public void Uzupelnienie()
    {
        if (_stan == OTWIERANIE)
        {
            SetStan(ZAMKNIETE);
        }
    }

    public void Timeout()
    {
        SetStan(ZAMYKANIE);
    }
	}

    public class ZamykanieDrzwi : StanDrzwi
    {
        public ZamykanieDrzwi (Drzwi2 drzwi) : base (drzwi)
        {
            
        }
        public override void Touch()
        {
            _drzwi.SetStan(_drzwi.OTWIERANIE);
        }
        public override void Uzupelnienie()
        {
            _drzwi.SetStan(_drzwi.ZAMKNIETE);  
        }
    }

}