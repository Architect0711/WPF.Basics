using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;
using WPF.Basics.MVVM;

namespace WPF.Basics.Animation
{
    public static class Animations
    {
        /// <summary>
        /// Try to get the Screen Resolution
        /// </summary>  
        private static double Width = System.Windows.SystemParameters.PrimaryScreenWidth > 0 ?
            System.Windows.SystemParameters.PrimaryScreenWidth : 2400;
        private static double Height = System.Windows.SystemParameters.PrimaryScreenHeight > 0 ?
            System.Windows.SystemParameters.PrimaryScreenHeight : 1600;

        #region Load

        public static async Task FadeIn(this BaseUserControl view, float seconds)
        {
            var sb = new Storyboard();
            double width = view.Width > 0 ? view.Width : Width; // Width can be NaN
            sb.AddFadeIn(seconds);
            sb.Begin(view);
            view.Visibility = Visibility.Visible;

            await Task.Delay((int)(seconds * 1000));
        }

        public static async Task SlideAndFadeInFromLeft(this BaseUserControl view, float seconds)
        {
            var sb = new Storyboard();
            double width = view.Width > 0 ? view.Width : Width; // Width can be NaN
            sb.AddSlideInFromLeft(seconds, width);
            sb.AddFadeIn(seconds);
            sb.Begin(view);
            view.Visibility = Visibility.Visible;

            await Task.Delay((int)(seconds * 1000));
        }

        public static async Task SlideAndFadeInFromRight(this BaseUserControl view, float seconds)
        {
            var sb = new Storyboard();
            double width = view.Width > 0 ? view.Width : Width; // Width can be NaN
            sb.AddSlideInFromRight(seconds, width);
            sb.AddFadeIn(seconds);
            sb.Begin(view);
            view.Visibility = Visibility.Visible;

            await Task.Delay((int)(seconds * 1000));
        }

        public static async Task SlideAndFadeInFromBottom(this BaseUserControl view, float seconds)
        {
            var sb = new Storyboard();
            double width = view.Width > 0 ? view.Height : Height; // Height can be NaN
            sb.AddSlideInFromBottom(seconds, width);
            sb.AddFadeIn(seconds);
            sb.Begin(view);
            view.Visibility = Visibility.Visible;

            await Task.Delay((int)(seconds * 1000));
        }

        public static async Task SlideAndFadeInFromTop(this BaseUserControl view, float seconds)
        {
            var sb = new Storyboard();
            double width = view.Width > 0 ? view.Height : Height; // Height can be NaN
            sb.AddSlideInFromTop(seconds, width);
            sb.AddFadeIn(seconds);
            sb.Begin(view);
            view.Visibility = Visibility.Visible;

            await Task.Delay((int)(seconds * 1000));
        }

        #endregion

        #region Unload

        public static async Task FadeOut(this BaseUserControl view, float seconds)
        {
            var sb = new Storyboard();
            double width = view.Width > 0 ? view.Width : Width; // Width can be NaN
            sb.Begin(view);

            await Task.Delay((int)(seconds * 1000));
        }

        public static async Task SlideAndFadeOutToLeft(this BaseUserControl view, float seconds)
        {
            var sb = new Storyboard();
            double width = view.Width > 0 ? view.Width : Width; // Width can be NaN
            sb.AddSlideOutToLeft(seconds, width);
            sb.Begin(view);

            await Task.Delay((int)(seconds * 1000));
        }

        public static async Task SlideAndFadeOutToRight(this BaseUserControl view, float seconds)
        {
            var sb = new Storyboard();
            double width = view.Width > 0 ? view.Width : Width; // Width can be NaN
            sb.AddSlideOutToRight(seconds, width);
            sb.Begin(view);

            await Task.Delay((int)(seconds * 1000));
        }

        public static async Task SlideAndFadeOutToBottom(this BaseUserControl view, float seconds)
        {
            var sb = new Storyboard();
            double width = view.Width > 0 ? view.Height : Height; // Height can be NaN
            sb.AddSlideOutToBottom(seconds, width);
            sb.Begin(view);

            await Task.Delay((int)(seconds * 1000));
        }

        public static async Task SlideAndFadeOutToTop(this BaseUserControl view, float seconds)
        {
            var sb = new Storyboard();
            double width = view.Width > 0 ? view.Height : Height; // Height can be NaN
            sb.AddSlideOutToTop(seconds, width);
            sb.Begin(view);

            await Task.Delay((int)(seconds * 1000));
        }

        #endregion
    }
}
