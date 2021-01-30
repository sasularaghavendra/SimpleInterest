using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleInterest
{
    class SimpleInterest : MasterInterest
    {
        private readonly string _interestType;
        private double _amount;
        private double _interest;
        private double _years;
        private double _totalAmount;
        private double _change;
        private double _simpleInterest;

        public SimpleInterest()
        {
            _interestType = "simple";
            Console.WriteLine("Enter Amount :");
            _amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Interest :");
            _interest = Convert.ToDouble(Console.ReadLine());
            _change = _amount / 100;
            //simple interest formula
            _simpleInterest = (_change * _interest);
            _totalAmount = _simpleInterest;
        }
        public override string InterestType
        {
            get { return _interestType; }
        }
        public override double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public override double Interest
        {
            get { return _interest; }
            set { _interest = value; }
        }
        public override double Years
        {
            get { return _years; }
            set { _years = value; }
        }
        public override double TotalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }
    }
}
