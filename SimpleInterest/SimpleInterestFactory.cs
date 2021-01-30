using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleInterest
{
    class SimpleInterestFactory: InterestFactory
    {
        public override MasterInterest GetInterest()
        {
            return new SimpleInterest();
        }
    }
}
