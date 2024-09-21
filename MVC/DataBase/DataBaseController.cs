using System.Data.SqlClient;

namespace MT_Kurs.MVC.DataBase
{
    public class DataBaseController
    {
        private readonly DataBaseModel _dataBaseModel;

        public DataBaseController()
        {
            _dataBaseModel = new DataBaseModel(@"Data Source=ST33ZY\SQLEXPRESS;Initial Catalog=MT_kurs;Integrated Security=True");
        }

        public void OpenConnection()
        {
            _dataBaseModel.OpenConnection();
        }
        public void CloseConnection()
        {
            _dataBaseModel.CloseConnection();
        }

        public SqlConnection GetConnection()
        {
            return _dataBaseModel.GetConnection();
        }

        public string GetStrConnection()
        {
            return _dataBaseModel.GetStrConnection();
        }
        public void DeleteUserOrder(string login)
        {
            _dataBaseModel.DeleteUserOrder(login);
        }
        public void DeleteUser(string login)
        {
            _dataBaseModel.DeleteUser(login);
        }

        public string FindUser(string login, string password)
        {
            return _dataBaseModel.FindUserInDataBase(login, password);
        }

        public string FindUserLogin(string login)
        {
            return _dataBaseModel.FindUserWithLoginInDataBase(login);
        }
        public void AddUser(string login, string password)
        {
            _dataBaseModel.AddUserInDataBase(login, password);
        }
        public void AddOrder(string login, string products, string name, string email, string adress, string sum)
        {
            _dataBaseModel.AddOrderInDataBase(login, products, name, email, adress, sum);
        }

    }
}
