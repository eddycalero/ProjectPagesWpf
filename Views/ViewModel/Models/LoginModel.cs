using ViewModel.configuration;

namespace ViewModel.Models
{
    public class LoginModel:ViewModelBase
    {
        private string _LoginName = "" ;
        private string _LoginPassword = "";
        private string _LoginMessage = "";
     
        public LoginModel()
        {

        }
         
        public string LoginName
        {
            get => _LoginName;
            set 
            {
                _LoginName = value;
                RaisePropertyChange("LoginName");
                LoginPassword = LoginName;
            }
        }

        public string LoginPassword
        {
            get => _LoginPassword;
            set
            {
                _LoginPassword = value;
                RaisePropertyChange("LoginPassword");
                LoginMessage = LoginPassword;
            }
        }

        public string LoginMessage
        {
            get => _LoginMessage;
            set
            {
                _LoginMessage = value;
                RaisePropertyChange("LoginMessage");
            }
        }

    }
}
