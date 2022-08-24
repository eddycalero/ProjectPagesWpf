using System.Windows;
using System.Windows.Controls;

namespace Views.Controls
{
    /// <summary>
    /// Lógica de interacción para PasswordBoxBindig.xaml
    /// </summary>
    public partial class PasswordBoxBindig : UserControl
    {
        public PasswordBoxBindig()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(PasswordBoxBindig),
                new PropertyMetadata(string.Empty));

        public string Password
        {
            get
            {
             return (string)GetValue(PasswordProperty);
            }
            set
            {
             SetValue(PasswordProperty, value);
            }
        }

        private void passwordBoxPasswordChanged( object sander, RoutedEventArgs e)
        {
            Password = passwordBox.Password;
        }

    } 
}
