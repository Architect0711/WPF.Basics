using EventAggregator.Interfaces;
using log4net;
using System.ComponentModel;

namespace WPF.Basics.MVVM
{
    /// <summary>
    /// BaseClass for all ViewModels. 
    /// Provides <see cref="INotifyPropertyChanged"/> functionality through <see cref="ObservableObject"/>
    /// Provides an <see cref="IEventAggregator"/>
    /// Provides a log4net Logger <see cref="ILog"/>
    /// </summary>
    public class BaseViewModel : ObservableObject
    {
        protected IEventAggregator EventAggregator;
        protected ILog Log;

        /// <summary>
        /// Give the View a Possibility to get a Reference to the EventAggregator
        /// </summary>
        public IEventAggregator GetEventAggregator
        {
            get
            {
                return EventAggregator;
            }
        }

        public BaseViewModel(IEventAggregator eventAggregator, ILog log)
        {
            EventAggregator = eventAggregator;
            Log = log;
            SubscribeToAllEvents();
        }
        
        /// <summary>
        /// Override this Method to subscribe to all <see cref="IEvent"/> Implementations this ViewModel is interested in
        /// </summary>
        protected virtual void SubscribeToAllEvents()
        {

        }
    }
}
