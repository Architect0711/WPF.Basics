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

namespace WPF.Basics.MVVM
{
    /// <summary>
    /// Interaction logic for UserControlHost.xaml
    /// Hosts two <see cref="BaseUserControl"/>s and enables them to be animated in & out 
    /// </summary>
    public partial class UserControlHost : UserControl
    {
        #region DependencyProperties

        /// <summary>
        /// Visible <see cref="BaseUserControl"/>
        /// </summary>
        public BaseUserControl CurrentUserControl
        {
            get { return (BaseUserControl)GetValue(CurrentUserControlProperty); }
            set { SetValue(CurrentUserControlProperty, value); }
        }

        /// <summary>
        /// Registers <see cref="CurrentUserControl"/> as a DependencyProperty
        /// </summary>
        public static readonly DependencyProperty CurrentUserControlProperty =
            DependencyProperty.Register(
                nameof(CurrentUserControl),
                typeof(BaseUserControl),
                typeof(UserControlHost),
                new UIPropertyMetadata(OnCurrentUserControlPropertyChanged));

        #endregion

        /// <summary>
        /// Default Constructor
        /// </summary>
        public UserControlHost()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event Handler that switches out the Views
        /// </summary>
        /// <param name="d">this <see cref="UserControlHost"/></param>
        /// <param name="e">Contains the new <see cref="BaseUserControl"/></param>
        private static void OnCurrentUserControlPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Get the ContentControls
            var newContentControl = (d as UserControlHost).NewContentControl;
            var oldContentControl = (d as UserControlHost).OldContentControl;

            // Store the current UserControl as oldUserControl
            var oldUserControl = newContentControl.Content;

            // Remove the current UserControl
            newContentControl.Content = null;

            // Move the previous UserControl to the oldContentControl
            oldContentControl.Content = oldUserControl;

            // Animate out the previous UserControl
            if(oldUserControl is BaseUserControl oldBaseUserControl)
            {
                oldBaseUserControl.ShouldAnimateOut = true;
            }

            if (e.NewValue is BaseUserControl newBaseUserControl)
            {
                // Animate in new UserControl
                newBaseUserControl.ShouldAnimateOut = false;
                newContentControl.Content = newBaseUserControl;
            }
        }
    }
}
