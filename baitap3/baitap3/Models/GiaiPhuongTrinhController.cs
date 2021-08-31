using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baitap3.Models
{
    public class GiaiPhuongTrinh
    {
        public double GiaiPT(double a, double b)
        {
            double x = 0;
            x = -b / a;
            return x;
        }
    }
}