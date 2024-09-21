using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MT_Kurs.MVC.Cart;

namespace MT_Kurs
{
    public partial class MarketView : Form
    {
        private List<Button> buttons = new List<Button>();
        private readonly CartController _cartController;
        private string Login = "";
        public MarketView(int status,string login)
        {
            _cartController = new CartController();
            InitializeComponent();
            Login = login;
            AddAllButtonsInList(buttons);
            SetStatusSettings(status, buttons);
        }
        private void AddAllButtonsInList(List<Button> list)
        {
            list.Add(InCart);
            list.Add(InCart1);
            list.Add(InCart2);
            list.Add(InCart3);
            list.Add(InCart4);
            list.Add(InCart5);
            list.Add(InCart6);
            list.Add(InCart7);
            list.Add(InCart8);
            list.Add(InCart9);
            list.Add(InCart10);
            list.Add(InCart11);
            list.Add(InCart12);
            list.Add(Buy);
        }
        public void SetStatusSettings(int status, List<Button> ButtonsList)
        {
            switch (status)
            {
                case 1:
                    for (int i = 0; i <= ButtonsList.Count-1; i++)
                    {
                        ButtonsList[i].Enabled = true;
                    }
                    groupBox14.Enabled = true;
                    break;
                case 2:
                    for (int i = 0; i <= ButtonsList.Count-1; i++)
                    {
                        ButtonsList[i].Enabled = true;
                    }
                    groupBox14.Enabled = true;

                    ///// еще фичи админа
                    ///
                    break;
            }
        }

        #region GOVNOKOD
        private void InCart_Click_1(object sender, EventArgs e)
        {
            CartList.AppendText(groupBox1.Text + " - " + _cartController.FindNum(label14.Text) + "р." + Environment.NewLine);
            _cartController.AddToSum(_cartController.FindNum(label14.Text));
        }
        private void InCart1_Click(object sender, EventArgs e)
        {
            CartList.AppendText(groupBox2.Text + " - " + _cartController.FindNum(label15.Text) + "р." + Environment.NewLine);
            _cartController.AddToSum(_cartController.FindNum(label15.Text));
        }
        private void InCart2_Click(object sender, EventArgs e)
        {
            CartList.AppendText(groupBox3.Text + " - " + _cartController.FindNum(label16.Text) + "р." + Environment.NewLine);
            _cartController.AddToSum(_cartController.FindNum(label16.Text));
        }
        private void InCart3_Click(object sender, EventArgs e)
        {
            CartList.AppendText(groupBox4.Text + " - " + _cartController.FindNum(label26.Text) + "р." + Environment.NewLine);
            _cartController.AddToSum(_cartController.FindNum(label26.Text));
        }
        private void InCart4_Click(object sender, EventArgs e)
        {
            CartList.AppendText(groupBox5.Text + " - " + _cartController.FindNum(label17.Text) + "р." + Environment.NewLine);
            _cartController.AddToSum(_cartController.FindNum(label17.Text));
        }
        private void InCart5_Click(object sender, EventArgs e)
        {
            CartList.AppendText(groupBox6.Text + " - " + _cartController.FindNum(label18.Text) + "р." + Environment.NewLine);
            _cartController.AddToSum(_cartController.FindNum(label18.Text));
        }
        private void InCart6_Click(object sender, EventArgs e)
        {
            CartList.AppendText(groupBox7.Text + " - " + _cartController.FindNum(label19.Text) + "р." + Environment.NewLine);
            _cartController.AddToSum(_cartController.FindNum(label19.Text));
        }
        private void InCart7_Click(object sender, EventArgs e)
        {
            CartList.AppendText(groupBox8.Text + " - " + _cartController.FindNum(label20.Text) + "р." + Environment.NewLine);
            _cartController.AddToSum(_cartController.FindNum(label20.Text));
        }
        private void InCart8_Click(object sender, EventArgs e)
        {
            CartList.AppendText(groupBox9.Text + " - " + _cartController.FindNum(label21.Text) + "р." + Environment.NewLine);
            _cartController.AddToSum(_cartController.FindNum(label21.Text));
        }
        private void InCart9_Click(object sender, EventArgs e)
        {
            CartList.AppendText(groupBox10.Text + " - " + _cartController.FindNum(label22.Text) + "р." + Environment.NewLine);
            _cartController.AddToSum(_cartController.FindNum(label22.Text));
        }
        private void InCart10_Click(object sender, EventArgs e)
        {
            CartList.AppendText(groupBox11.Text + " - " + _cartController.FindNum(label23.Text) + "р." + Environment.NewLine);
            _cartController.AddToSum(_cartController.FindNum(label23.Text));
        }
        private void InCart11_Click(object sender, EventArgs e)
        {
            CartList.AppendText(groupBox12.Text + " - " + _cartController.FindNum(label24.Text) + "р." + Environment.NewLine);
            _cartController.AddToSum(_cartController.FindNum(label24.Text));
        }
        private void InCart12_Click(object sender, EventArgs e)
        {
            CartList.AppendText(groupBox13.Text + " - " + _cartController.FindNum(label25.Text) + "р." + Environment.NewLine);
            _cartController.AddToSum(_cartController.FindNum(label25.Text));
        }
        #endregion

        private void Buy_Click(object sender, EventArgs e)
        {
            if(CartList.Text != "")
            {
                
                CartView cartWindow = new CartView(CartList.Text, Login, _cartController.GetSum());
                cartWindow.ShowDialog();
                CartList.Text = "";
            }
            else
            {
                MessageBox.Show("Корзина пуста!");
            }
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
