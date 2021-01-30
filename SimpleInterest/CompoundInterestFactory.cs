using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleInterest
{
    //A concrete creator
    class CompoundInterestFactory : InterestFactory
    {

        public override MasterInterest GetInterest()
        {
            return new CompoundInterest();
        }

    }
}
