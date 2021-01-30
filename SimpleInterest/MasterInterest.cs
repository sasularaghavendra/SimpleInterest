using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleInterest
{
    abstract class MasterInterest
    {
        public abstract string InterestType { get; }
        public abstract double Amount { get; set; }
        public abstract double Interest { get; set; }
        public abstract double Years { get; set; }
        public abstract double TotalAmount { get; set; }

    }
}
