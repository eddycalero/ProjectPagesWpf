using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        public string password
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
            password = passwordBox.Password;
        }

    } 
}
