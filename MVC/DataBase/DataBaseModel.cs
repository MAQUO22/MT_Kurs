using System;
using System.Data;
using System.Data.SqlClient;

namespace MT_Kurs.MVC.DataBase
{
    public class DataBaseModel
    {
        private readonly SqlConnection _SqlConnection;

        public DataBaseModel(string str)
        {
            _SqlConnection = new SqlConnection(str);
        }

        public string FindUserInDataBase(string login, string password)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string queryString = $"select Id,Login,Password from UsersInfo where Login = '{login}' and Password = '{password}'";

            SqlCommand sqlCommand = new SqlCommand(queryString, GetConnection());

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
                return login;
            else
                return "";
        }

        public string FindUserWithLoginInDataBase(string login)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string queryString = $"select Id,Login,Password from UsersInfo where Login = '{login}'";

            SqlCommand sqlCommand = new SqlCommand(queryString, GetConnection());

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
                return login;
            else
                return "";
        }

        public void DeleteUser(string login)
        {
            string queryString = $"delete from UsersInfo where Login = '{login}'";
            SqlCommand sqlCommand = new SqlCommand(queryString, GetConnection());
            OpenConnection();
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
        }

        public void DeleteUserOrder(string login)
        {
            string queryString = $"delete from Orders where Login = '{login}'";
            SqlCommand sqlCommand = new SqlCommand(queryString, GetConnection());
            OpenConnection();
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
        }

        public void AddOrderInDataBase(string login, string products, string name, string email, string adress, string sum)
        {
            string queryString = $"insert into Orders(Login,TimeOrder,Products,TotalSum,Name,Adress,Email) values('{login}','{DateTime.Now.ToString()}','{products}','{sum}','{name}','{adress}','{email}')";
            SqlCommand sqlCommand = new SqlCommand(queryString, GetConnection());
            OpenConnection();
            if (sqlCommand.ExecuteNonQuery() == 1)
                CloseConnection();

        }

        public void AddUserInDataBase(string regLogin, string regPassword)
        {
            string queryString = $"insert into UsersInfo(Login,Password) values('{regLogin}','{regPassword}')";
            SqlCommand sqlCommand = new SqlCommand(queryString, GetConnection());
            OpenConnection();
            if (sqlCommand.ExecuteNonQuery() == 1)
                CloseConnection();
        }

        public string GetStrConnection()
        {
            return @"Data Source=ST33ZY\SQLEXPRESS;Initial Catalog=MT_kurs;Integrated Security=True";
        }

        public void OpenConnection()
        {
            if (_SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                _SqlConnection.Open();
            }
        }
        public void CloseConnection()
        {
            if (_SqlConnection.State == System.Data.ConnectionState.Open)
            {
                _SqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return _SqlConnection;
        }
    }
}
