using Castle.Core.Internal;
using MT_Kurs.MVC.Login;
using MT_Kurs.MVC.Admin;
using System;
using System.Windows.Forms;

namespace MT_Kurs
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            MarketView market = new MarketView(1,"kekes");
            this.Hide();
            market.ShowDialog();


            LoginController controller = new LoginController();
            if (controller.GetStatus(LoginText.Text, PasswordText.Text) < 0)
            {
                MessageBox.Show("Пользователь не найден");
            }
            else
            {

                if (controller.IsAdmin(controller.GetLogin()))
                {
                    MessageBox.Show("Вы вошли как Админ");
                    AdminView adminView = new AdminView();
                    this.Hide();
                    adminView.ShowDialog();
                }
                else
                {
                    MarketView marketView = new MarketView(1, controller.GetLogin());
                    this.Hide();
                    marketView.ShowDialog();
                }

            }
            LoginText.Text = "";
            PasswordText.Text = "";
        }

        private void RegWindowButton_Click(object sender, EventArgs e)
        {
            RegistrationView registrationWindow = new RegistrationView();
            this.Hide();
            registrationWindow.ShowDialog();
        }

        private void EnterAsStranger_Click(object sender, EventArgs e)
        {
            MarketView mainWindow = new MarketView(0,"");
            this.Hide();
            mainWindow.ShowDialog();
        }
    }
}
