﻿using System;
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
        public Calcul(double d)
        {
            data = d;
        }
        public double getData()
        {
            return data;
        }
        public void setData(double d)
        {
            data = d;
        }
        public double plus(double number)
        {
            return data + number;
        }
        public double minus(double number)
        {
            return data - number;
        }
        public double multi(double number)
        {
            return data*number;
        }
        public double div(double number)
        {
            if (number == 0) return data;
            return data/number;
        }
        public double factorial(double number)
        {
            if (number == 0) return 1;
            else return number * factorial(number - 1);
        }
        public double cos()
        {
            return Math.Cos(data);
        }
        public double sin()
        {
            return Math.Sin(data);
        }
        public double tang()
        {
            return Math.Tan(data);
        }
        public double sqrt()
        {
            return Math.Sqrt(data);
        }
        public double exp()
        {
            return Math.Exp(data);
        }
        public double square()
        {
            return data*data;
        }
        public double log()
        {
            return Math.Log(data);
        }
        public double pow(double number)
        {
            return Math.Pow(data, number);
        }

    }
}
