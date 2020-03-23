using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var iterative = new Iterative(20);
            var iterativeFromBack = new IterativeFromBack(20);

            var iterativeThread = new Thread(new ThreadStart(iterative.Calculate));
            var iterativeFromBackThread = new Thread(new ThreadStart(iterativeFromBack.Calculate));
        }
    }

    public class IterativeFromBack
    {
        private int number;

        public IterativeFromBack(int _number)
        {
            number = _number;
        }

        public void Calculate()
        {
            for (int i = number - 1; i >= 1; i--)
            {
                if (isPrime(i))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        private bool isPrime(int number)
        {
            if (number == 1 || number == 2) return true;
            if (number == 0) return false;

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }

    public class Iterative
    {
        private int number;

        public Iterative(int _number)
        {
            number = _number;
        }

        public void Calculate()
        {
            var primeNumber = new List<int>();

            for (int i = 0; i < number; i++)
            {
                if (isPrime(i)) primeNumber.Add(i);
            }

            Console.WriteLine(primeNumber.Last());
        }

        private bool isPrime(int number)
        {
            if (number == 1 || number == 2) return true;
            if (number == 0) return false;

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
