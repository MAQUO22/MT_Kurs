
namespace MT_Kurs.MVC.Login
{
    public class LoginModel
    {
        private string login;
        private string password;
        public LoginModel()
        {
            login = "";
            password = "";
        }

        public void SetLogin(string login) => this.login = login;
        public string GetLogin() => this.login;
        public void SetPassword(string password) => this.password = password;
        public string GetPasword() => this.password;
    }
}
