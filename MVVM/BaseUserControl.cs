using EventAggregator.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WPF.Basics.Animation;
using WPF.Basics.Enums;

namespace WPF.Basics.MVVM
{
    /// <summary>
    /// Base Class for all <see cref="UserControl"/>s 
    /// </summary>
    public class BaseUserControl : UserControl, INotifyPropertyChanged
    {
        /// <summary>
        /// The UserControl may also want to react to an <see cref="IEvent"/>
        /// </summary>
        protected IEventAggregator EventAggregator;

        /// <summary>
        /// The time any Slide Animation takes to complete
        /// </summary>
        protected float SlideSeconds { get; set; } = 2f;

        /// <summary>
        /// The Animation when a <see cref="BaseUserControl"/> is loaded
        /// </summary>
        protected LoadAnimation LoadAnimation { get; private set; }

        /// <summary>
        /// The Animation when a <see cref="BaseUserControl"/> is unloaded
        /// </summary>
        protected UnloadAnimation UnloadAnimation { get; private set; }

        /// <summary>
        /// Flag to indicate if the <see cref="BaseUserControl"/> should be animated out
        /// </summary>
        public bool ShouldAnimateOut { get; set; }

        /// <summary>
        /// Pass the desired <see cref="Enums.LoadAnimation"/> and <see cref="Enums.UnloadAnimation"/> to the Constructor
        /// </summary>
        /// <param name="loadAnimation">Animate the View in when it's loaded</param>
        /// <param name="unloadAnimation">Animate the View out when it's unloaded</param>
        public BaseUserControl(
            IEventAggregator eventAggregator,
            LoadAnimation loadAnimation, 
            UnloadAnimation unloadAnimation)
        {
            LoadAnimation = loadAnimation;
            UnloadAnimation = unloadAnimation;

            // If we are animating in, hide to begin with
            if (LoadAnimation != LoadAnimation.None)
            {
                Visibility = Visibility.Collapsed;
            }

            // Listen out for the page loading
            Loaded += BaseUserControl_LoadedAsync;

            EventAggregator = eventAggregator;
        }

        #region Animation Load / Unload

        /// <summary>
        /// Once the <see cref="BaseUserControl"/> is loaded, perform the configured animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BaseUserControl_LoadedAsync(object sender, System.Windows.RoutedEventArgs e)
        {
            // If we are setup to animate out on load
            if (ShouldAnimateOut)
            {
                // Animate out the page
                await AnimateOutAsync();
            }
            else // Otherwise...
            {
                // Animate the page in
                await AnimateInAsync();
            }
        }

        /// <summary>
        /// Animates the view in
        /// </summary>
        /// <returns></returns>
        public async Task AnimateInAsync()
        {
            // Make sure we have something to do
            if (LoadAnimation == LoadAnimation.None)
                return;

            switch (LoadAnimation)
            {
                case LoadAnimation.FadeIn:

                    await Animations.FadeIn(this, SlideSeconds);

                    break;

                case LoadAnimation.SlideAndFadeInFromLeft:

                    await Animations.SlideAndFadeInFromLeft(this, SlideSeconds);

                    break;

                case LoadAnimation.SlideAndFadeInFromRight:

                    await Animations.SlideAndFadeInFromRight(this, SlideSeconds);

                    break;

                case LoadAnimation.SlideAndFadeInFromBottom:

                    await Animations.SlideAndFadeInFromBottom(this, SlideSeconds);

                    break;

                case LoadAnimation.SlideAndFadeInFromTop:

                    await Animations.SlideAndFadeInFromTop(this, SlideSeconds);

                    break;
            }
        }

        /// <summary>
        /// Animates the view out
        /// </summary>
        /// <returns></returns>
        public async Task AnimateOutAsync()
        {
            // Make sure we have something to do
            if (UnloadAnimation == UnloadAnimation.None)
                return;

            switch (UnloadAnimation)
            {
                case UnloadAnimation.FadeOut:

                    // Start the animation
                    await Animations.FadeOut(this, SlideSeconds);

                    break;

                case UnloadAnimation.SlideAndFadeOutToLeft:

                    // Start the animation
                    await Animations.SlideAndFadeOutToLeft(this, SlideSeconds);

                    break;

                case UnloadAnimation.SlideAndFadeOutToRight:

                    // Start the animation
                    await Animations.SlideAndFadeOutToRight(this, SlideSeconds);

                    break;

                case UnloadAnimation.SlideAndFadeOutToBottom:

                    // Start the animation
                    await Animations.SlideAndFadeOutToBottom(this, SlideSeconds);

                    break;

                case UnloadAnimation.SlideAndFadeOutToTop:

                    // Start the animation
                    await Animations.SlideAndFadeOutToTop(this, SlideSeconds);

                    break;
            }
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged<T>([CallerMemberName]string propertyName = "")
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void OnPropertyChanged<T>(ref T property, T value, [CallerMemberName]string propertyName = "")
        {
            property = value;
            var handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        } 
        #endregion
        #endregion

    }
}
