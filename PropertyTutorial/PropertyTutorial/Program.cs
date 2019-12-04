using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTutorial
{
    public class Money
    {
        private float aud;

        public float Aud
        {
            get
            {
                return aud;
            }
            set
            {
                aud = value;
            }
        }
        public float Usd
        {
            get
            {
                return (1f/.68f) * aud;
            }
        }
    }

    class Program {
        static void Main(string[] args)
        {
            Money money = new Money();
            money.Aud = 100;
            Console.WriteLine("AUD = " + money.Aud);
            Console.WriteLine("USD = " + money.Usd);
            Console.ReadLine();
        }
    }
}
