
namespace MT_Kurs.MVC.Registration
{
    public class RegistrationModel
    {
        private string RegLogin;
        private string RegPassword;
        public RegistrationModel()
        {
            RegLogin = "";
            RegPassword = "";
        }

        public string GetRegLogin() => RegLogin;
        public void SetRegLogin(string login) => this.RegLogin = login;
        public string GetRegPassword() => RegPassword;
        public void SetRegPassword(string password) => this.RegPassword = password;

    }
}
