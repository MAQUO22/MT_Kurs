using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_Kurs.MVC.Cart
{
    public class CartModel
    {
        private double sum;
        public CartModel()
        {
            sum = 0;
        }
        public double GetSum() => sum;
        public void SetSum(double num) => sum = num;
        public void AddToSum(double num) => sum += num;
    }
}
