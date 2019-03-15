using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeofResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Chain c1 = new NegativeProcessor();
            Chain c2 = new ZeroProcessor();
            Chain c3 = new PositiveProcessor();
            c1.SetNext(c2);
            c2.SetNext(c3);

            c1.Process(new Number(90));
            c1.Process(new Number(-50));
            c1.Process(new Number(0));
            c1.Process(new Number(91));
        }


    }
    interface Chain
    {
          void SetNext(Chain NextInChain);
          void Process(Number request);
    }

    class Number
    {
        private int _number;
        public Number(int number)
        {
            _number = number;
        }

        public int getNumber()
        {
            return _number;
        }
    }

    class NegativeProcessor : Chain
    {
        private Chain _nextInChain;
        public void Process(Number request)
        {
            if (request.getNumber() < 0)
            {
                Console.WriteLine("NegativeProcessor : " + request.getNumber());
            }
            else
            {
                _nextInChain.Process(request);
            }
        }

        public void SetNext(Chain NextInChain)
        {
            _nextInChain = NextInChain;
        }
    }

    class PositiveProcessor : Chain
    {
        private Chain _nextInChain;
        public void Process(Number request)
        {
            if (request.getNumber() > 0)
            {
                Console.WriteLine("PositiveProcessor  : " + request.getNumber());
            }
            else
            {
                _nextInChain.Process(request);
            }
        }

        public void SetNext(Chain NextInChain)
        {
            _nextInChain = NextInChain;
        }
    }

    class ZeroProcessor : Chain
    {
        private Chain _nextInChain;
        public void Process(Number request)
        {
            if (request.getNumber() == 0)
            {
                Console.WriteLine("ZeroProcessor   : " + request.getNumber());
            }
            else
            {
                _nextInChain.Process(request);
            }
        }

        public void SetNext(Chain NextInChain)
        {
            _nextInChain = NextInChain;
        }
    }
}


