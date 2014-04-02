using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Calcul
    {
        protected double data;

        public Calcul()
        {
            data = 0;            
        }
        public double getData()
        {
            return data;
        }
        public void setData(double d)
        {
            data = d;
        }
    }
}
