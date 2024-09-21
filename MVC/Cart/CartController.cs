using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_Kurs.MVC.Cart
{
    public class CartController
    {
        private readonly CartModel _cartModel;
        public CartController()
        {
            _cartModel = new CartModel();
        }

        public bool IsAllFlagsActivated(string name, string adress, string email)
        {
            if(IsNameCorrect(name) && IsMailCorrect(email) && IsAdressCorrect(adress))
                return true;
            else
                return false;
        }

        public void AddToSum(double num) => _cartModel.AddToSum(num);
        public double GetSum() => _cartModel.GetSum();
        public void SetSum(double num) => _cartModel.SetSum(num);
        public bool IsMailCorrect(string mail)
        {
            if (mail.Length > 13)
            {
                if (mail.EndsWith("@gmail.com") || mail.EndsWith("@mail.ru"))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public bool IsAdressCorrect(string adress)
        {
            if (adress.Length > 5)
                return true;
            else
                return false;
        }

        public bool IsNameCorrect(string name)
        {
            if (name.Length >= 2)
                return true;
            else
                return false;
        }

        public double FindNum(string label)
        {
            string temp = "";
            for (int i = 0; i < label.Length; i++)
            {
                if (label[i] == '-')
                {
                    i++;
                    while (label[i] != 'р')
                    {
                        temp += label[i];
                        i++;
                    }
                }
            }
            return Convert.ToDouble(temp);
        }
    }
    
}
