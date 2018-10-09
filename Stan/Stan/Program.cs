using System;

namespace state
{
    class MainApp

    {
        static void Main()
        {
            Context c = new Context(new Skladniki());

            c.Zamowienie();
            c.Zamowienie();
            c.Zamowienie();
            c.Zamowienie();

            Console.ReadKey();
        }
    }

    abstract class Stan

    {
        public abstract void Uchwyt(Context context);
    }

    class Skladniki : Stan

    {
        public override void Uchwyt(Context context)
        {
            context.Stan = new Dodatki();
        }
    }

    class Dodatki : Stan

    {
        public override void Uchwyt(Context context)
        {
            context.Stan = new Skladniki();
        }
    }

    class Context

    {
        private Stan _stan;

        // Konstructor

        public Context(Stan stan)
        {
            this.Stan = stan;
        }

        public Stan Stan
        {
            get { return _stan; }
            set

            {
                _stan = value;
                Console.WriteLine("Stan zamówienia: " + _stan.GetType().Name);
            }
        }

        public void Zamowienie()
        {
            _stan.Uchwyt(this);
        }
    }
}