using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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

namespace WPF.Basics.UserControls
{
    /// <summary>
    /// Interaction logic for BindablePasswordBox.xaml
    /// To keep the Password safe as a <see cref="SecureString"/> and Keep the MVVM Pattern, use this PasswordBox Extension
    /// https://stackoverflow.com/questions/15390727/passwordbox-and-mvvm/15391318#15391318
    /// </summary>
    public partial class BindablePasswordBox : UserControl
    {

        public SecureString Password
        {
            get { return (SecureString)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register(nameof(Password), typeof(SecureString), typeof(BindablePasswordBox),
                new PropertyMetadata(default(SecureString)));

        public BindablePasswordBox()
        {
            InitializeComponent();

            // Update DependencyProperty whenever the password changes
            PasswordBox.PasswordChanged += (sender, args) => {
                Password = ((PasswordBox)sender).SecurePassword;
            };
        }
    }
}
