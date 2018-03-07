using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRASDemo
{
    public class CurrencyConverter
    {
        RateProvider rp;

        public CurrencyConverter(RateProvider r)
        {
            rp = r;
        }

        public double Convert(string from, double amount, string to)
        {
            return amount * rp.GetRate(from,to);
        }

    }

    public interface RateProvider
    {
        double GetRate(string from, string to);
    }
}
