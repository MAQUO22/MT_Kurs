using System;
using System.Data;
using System.Windows.Forms;
using MT_Kurs.MVC.DataBase;
using System.Data.SqlClient;

namespace MT_Kurs.MVC.Admin
{
    public partial class AdminView : Form
    {
        private readonly DataBaseController _dataBaseController = new DataBaseController();
        public AdminView()
        {
            InitializeComponent();
            GetUsersFromDataBase();
        }
        private void ReadSingleRow(IDataRecord dataRecord)
        {
            UsersList.AppendText(dataRecord[0] + Environment.NewLine);

        }
        private void EnterInDataGrid(IDataRecord dataRecord)
        {
            dataGridView1.Rows.Add(dataRecord[0], dataRecord[1], dataRecord[2], dataRecord[3], dataRecord[4], dataRecord[5], dataRecord[6]);
        }

        private void GetUsersFromDataBase()
        {
            string queryString = "select Login from UsersInfo;";
            SqlCommand command = new SqlCommand(queryString, _dataBaseController.GetConnection());
            _dataBaseController.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();

            UsersList.Text = "";
            while (reader.Read())
            {
                ReadSingleRow((IDataRecord)reader);
            }
            reader.Close();
        }

        private void GetOrdersFromDataBase()
        {
            string queryString = $"select * from Orders where Login = '{UserLogin.Text}';";

            SqlCommand command = new SqlCommand(queryString, _dataBaseController.GetConnection());
            _dataBaseController.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                EnterInDataGrid((IDataRecord)reader);
            }

            reader.Close();
        }

        private void GetOrders_Click(object sender, EventArgs e)
        {
            var nick = UserLogin.Text;
            if (_dataBaseController.FindUserLogin(nick) != "")
            {
                GetOrdersFromDataBase();
            }
            else
            {
                MessageBox.Show("Поле пустое или такого пользователя не существует");
            }
        }

        private void DeleteOrders_Click(object sender, EventArgs e)
        {
            if (_dataBaseController.FindUserLogin(UserLogin.Text) != "")
            {
                _dataBaseController.DeleteUserOrder(UserLogin.Text);
                MessageBox.Show($"Заказ(ы) пользователя {UserLogin.Text} удален(ы)");
            }
            else
            {
                MessageBox.Show("Поле пустое или такого пользователя не существует");
            }
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            if(_dataBaseController.FindUserLogin(UserLogin.Text) != "")
            {
                _dataBaseController.DeleteUser(UserLogin.Text);
                MessageBox.Show($"Пользователь {UserLogin.Text} удален");
                GetUsersFromDataBase();
            }
            else
            {
                MessageBox.Show("Поле пустое или такого пользователя не существует");
            }
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
