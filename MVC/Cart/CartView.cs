using System;
using System.Windows.Forms;
using MT_Kurs.MVC.Cart;
using MT_Kurs.MVC.DataBase;

namespace MT_Kurs
{
    public partial class CartView : Form
    {
        private readonly CartController cartController;
        private readonly DataBaseController _controllerDataBase;
        private string Login = "";
        public CartView(string str,string login, double sum)
        {
            _controllerDataBase = new DataBaseController();
            cartController = new CartController();
            InitializeComponent();
            Login = login;
            CartList.Text = str;
            Sum.Text = sum.ToString() + "р.";

        }
        private void Order_Click(object sender, EventArgs e)
        {
            
            if (cartController.IsAllFlagsActivated(FirstAndLastName.Text, adress.Text, mail.Text))
            {
                _controllerDataBase.AddOrder(Login, CartList.Text, FirstAndLastName.Text, mail.Text, adress.Text, Sum.Text);
                this.Close();
                MessageBox.Show("Ваш заказ успешно оформлен. Спасибо что заказали у нас!");
                cartController.SetSum(0);
            }
            else
            {
                if (!cartController.IsMailCorrect(mail.Text))
                    MessageBox.Show("Поле email заполнено неверно.");
                if (!cartController.IsAdressCorrect(adress.Text))
                    MessageBox.Show("Поле адрес заполнено неверно.");
                if (!cartController.IsNameCorrect(FirstAndLastName.Text))
                    MessageBox.Show("Поле имя заполнено неверно.");
            }
        }
    }
}
