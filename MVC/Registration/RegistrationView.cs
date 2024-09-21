using System;
using System.Windows.Forms;
using MT_Kurs.MVC.Registration;

namespace MT_Kurs
{
    public partial class RegistrationView : Form
    {

        public RegistrationView()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationController registrationController = new RegistrationController();
            if (registrationController.RegistrateUser(RegLoginText.Text, RegPasswordText.Text))
            {
                MessageBox.Show("Пользователь зарегистрирован.");
                MarketView marketView = new MarketView(1, registrationController.GetRegLogin());
                this.Hide();
                marketView.ShowDialog();
            }
            else if (!registrationController.IsCorrectInfo(RegLoginText.Text, RegPasswordText.Text))
            {
                MessageBox.Show("Введены некорректные данные");
            }
            else
            {
                MessageBox.Show("Такой пользователь уже существует.");
            }
                

            RegLoginText.Text = "";
            RegPasswordText.Text = "";

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
