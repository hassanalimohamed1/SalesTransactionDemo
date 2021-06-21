using System;
using static System.Console;
namespace SalesTransactionDemo
{
    class SalesTransactionDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Sales Support Platform!");
            SalesTransaction s1 = new SalesTransaction("MNM", 2000, 0.50);
            Display(s1);
            SalesTransaction s2 = new SalesTransaction("QWERTY", 1000);
            Display(s2);
            SalesTransaction s3 = new SalesTransaction("ASDF");
            Display(s3);
        }

        public static void Display(SalesTransaction s)
        {
            WriteLine($"The sales person {s.Name} has acgived the target of {s.SalesAmount.ToString("C")}.");
            WriteLine($"The commission earned at the rate of {s.Rate} is {s.Commission.ToString("C")}.");
        }
    }

    class SalesTransaction {
        private string name;
        private double amount;
        private double commission;
        readonly double RATE;

        public string Name {
            set {
                name = value;
            }
            get {
                return name;
            }
        }

        public double SalesAmount
        {
            set
            {
                amount = value;
                CommissionCalc();
            }
            get
            {
                return amount;
            }

        }

        public double Rate {
            get
            {
                return RATE;
            }
        }

        public double Commission
        {
            get
            {
                return commission; ;
            }
        }

        public void CommissionCalc() {
            commission = amount * RATE;
        }

        public SalesTransaction() { }
        public SalesTransaction(string nm,  double amt, double rt) {
            Name = nm;
            RATE = rt;
            SalesAmount = amt;
        }

        public SalesTransaction(string nm, double amt)
        {
            Name = nm;
            RATE = 0;
            SalesAmount = amt;
        }

        public SalesTransaction(string nm)
        {
            Name = nm;
            RATE = 0;
            SalesAmount = 0;
        }

    }
}
