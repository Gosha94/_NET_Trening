using System.ComponentModel.DataAnnotations.Schema;

namespace MaterialDesignWpf.Models
{    
    public class User
    {
        public int Id { get; set; }
        private string _login, _pass, _email;

        
        public string Login 
        {
            get => _login;
            set { _login = value; }
        }
        
        public string Pass
        {
            get => _pass;
            set { _pass = value; }
        }
        
        public string Email
        {
            get => _email;
            set { _email = value; }
        }

        public User() { }

        public User(string login, string pass,string email)
        {
            this._login = login;
            this._pass = pass;
            this._email = email;
        }

        public override string ToString()
        {
            return "Пользователь: " + Login + "Email: " + Email;
        }
    }
}
