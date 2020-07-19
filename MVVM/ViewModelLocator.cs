using EventAggregator.Implementations.Nonstatic.Async;
using EventAggregator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace WPF.Basics.MVVM
{
    /// <summary>
    /// Inherit from this Class to gain a ViewModelLocator that provides access to the IoC Container for all ViewModels
    /// 
    /// Create a Property for every ViewModel that will call <see cref="UnityContainer.Resolve"/> and return the ViewModel
    /// Example:
    /// 
    /// public LoginViewModel Login
    /// {
    ///     get { return _container.Resolve<LoginViewModel>(); }
    /// }
    /// 
    /// Keep the Implementation as StaticResource in App.xaml
    /// 
    /// Access the ViewModels in the View's XAML like this: 
    /// DataContext="{Binding Source={StaticResource ViewModelLocator}, Path=*PATH*}"
    /// </summary>
    public abstract class ViewModelLocator
    {
        /// <summary>
        /// IoC Container
        /// </summary>
        public static readonly UnityContainer _container = new UnityContainer();

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ViewModelLocator()
        {

        }
    }
}
