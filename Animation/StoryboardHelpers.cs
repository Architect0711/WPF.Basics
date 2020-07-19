using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace WPF.Basics.Animation
{
    public static class StoryboardHelpers
    {
        #region Fades

        public static void AddFadeOut(this Storyboard storyboard, float seconds)
        {
            var slideAnimation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 1,
                To = 0
            };
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Opacity"));
            storyboard.Children.Add(slideAnimation);
        }
        public static void AddFadeIn(this Storyboard storyboard, float seconds)
        {
            var slideAnimation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 0,
                To = 1
            };
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Opacity"));
            storyboard.Children.Add(slideAnimation);
        }

        #endregion

        #region Slides

        #region In

        public static void AddSlideInFromLeft(this Storyboard storyboard, float seconds, double offset, float decelerationratio = 0.9f)
        {
            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(-offset, 0, offset, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationratio
            };
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            storyboard.Children.Add(slideAnimation);
        }

        public static void AddSlideInFromRight(this Storyboard storyboard, float seconds, double offset, float decelerationratio = 0.9f)
        {
            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(offset, 0, -offset, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationratio
            };
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            storyboard.Children.Add(slideAnimation);
        }

        public static void AddSlideInFromBottom(this Storyboard storyboard, float seconds, double offset, float decelerationratio = 0.9f)
        {
            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0, offset, 0, -offset),
                To = new Thickness(0),
                DecelerationRatio = decelerationratio
            };
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            storyboard.Children.Add(slideAnimation);
        }

        public static void AddSlideInFromTop(this Storyboard storyboard, float seconds, double offset, float decelerationratio = 0.9f)
        {
            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0, -offset, 0, offset),
                To = new Thickness(0),
                DecelerationRatio = decelerationratio
            };
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            storyboard.Children.Add(slideAnimation);
        }

        #endregion

        #region Out

        public static void AddSlideOutToLeft(this Storyboard storyboard, float seconds, double offset, float decelerationratio = 0.9f)
        {
            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(-offset, 0, offset, 0),
                DecelerationRatio = decelerationratio
            };
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            storyboard.Children.Add(slideAnimation);
        }

        public static void AddSlideOutToRight(this Storyboard storyboard, float seconds, double offset, float decelerationratio = 0.9f)
        {
            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(offset, 0, -offset, 0),
                DecelerationRatio = decelerationratio
            };
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            storyboard.Children.Add(slideAnimation);
        }

        public static void AddSlideOutToBottom(this Storyboard storyboard, float seconds, double offset, float decelerationratio = 0.9f)
        {
            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(0, offset, 0, -offset),
                DecelerationRatio = decelerationratio
            };
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            storyboard.Children.Add(slideAnimation);
        }

        public static void AddSlideOutToTop(this Storyboard storyboard, float seconds, double offset, float decelerationratio = 0.9f)
        {
            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(0, -offset, 0, offset),
                DecelerationRatio = decelerationratio
            };
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            storyboard.Children.Add(slideAnimation);
        }

        #endregion

        #endregion
    }
}
