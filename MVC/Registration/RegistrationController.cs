using MT_Kurs.MVC.DataBase;
using Castle.Core.Internal;

namespace MT_Kurs.MVC.Registration
{
    public class RegistrationController
    {
        private readonly RegistrationModel _registrationModel;
        private readonly DataBaseController _dataBaseController;
        public RegistrationController()
        {
            _registrationModel = new RegistrationModel();
            _dataBaseController = new DataBaseController();
        }

        public bool RegistrateUser(string regLogin, string regPassword)
        {
            if (IsCorrectInfo(regLogin, regPassword))
            {
                if (IsUserUnique(regLogin))
                {
                    _dataBaseController.AddUser(regLogin, regPassword);
                    _registrationModel.SetRegLogin(regLogin);
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
        public bool IsCorrectInfo(string regLogin, string regPassword)
        {
            if (regLogin.Length > 3 && regPassword.Length >= 5)
                return true;
            else
                return false;
        }

        public bool IsUserUnique(string regLogin)
        {
            if (_dataBaseController.FindUserLogin(regLogin).IsNullOrEmpty())
                return true;
            else
                return false;
        }
        public string GetRegLogin() => _registrationModel.GetRegLogin();
    }
}
