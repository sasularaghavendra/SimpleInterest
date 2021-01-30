using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleInterest
{
    abstract class InterestFactory
    {
        public abstract MasterInterest GetInterest();
    }
}
