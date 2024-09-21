using Castle.Core.Internal;
using MT_Kurs.MVC.DataBase;

namespace MT_Kurs.MVC.Login
{
    public class LoginController
    {
        private readonly DataBaseController _dataBaseController;
        private readonly LoginModel _loginModel;
        public LoginController()
        {
            _loginModel = new LoginModel();
            _dataBaseController = new DataBaseController();
        }

        public bool IsUserExists(string login, string password)
        {
            if (_dataBaseController.FindUser(login, password).IsNullOrEmpty())
                return false;
            else
                return true;
        }
        public int GetStatus(string login, string password)
        {
            if (IsAdmin(_dataBaseController.FindUser(login, password)))
            {
                _loginModel.SetLogin(login);
                _loginModel.SetPassword(password);
                return 2;
            }
            else if (IsCustomer(_dataBaseController.FindUser(login, password)))
            {
                _loginModel.SetLogin(login);
                _loginModel.SetPassword(password);
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public bool IsCustomer(string login)
        {
            if (login.IsNullOrEmpty())
                return false;
            else
                return true;
        }

        public string GetLogin()
        {
            return _loginModel.GetLogin();
        }
        public bool IsAdmin(string login)
        {
            if (login == "root" || login == "admin")
                return true;
            else
                return false;
        }

    }
}
