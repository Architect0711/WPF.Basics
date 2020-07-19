using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Basics.Enums
{
    public enum LoadAnimation
    {
        /// <summary>
        /// Don't do any Animation
        /// </summary>
        None,

        /// <summary>
        /// Content fades in
        /// </summary>
        FadeIn,

        /// <summary>
        /// Content slides in and fades in from the left
        /// </summary>
        SlideAndFadeInFromLeft,

        /// <summary>
        /// Content slides in and fades in from the right
        /// </summary>
        SlideAndFadeInFromRight,

        /// <summary>
        /// Content slides in and fades in from the top
        /// </summary>
        SlideAndFadeInFromTop,

        /// <summary>
        /// Content slides in and fades in from the bottom
        /// </summary>
        SlideAndFadeInFromBottom
    }
}
