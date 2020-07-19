using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Basics.Enums
{
    public enum UnloadAnimation
    {
        /// <summary>
        /// Don't do any Animation
        /// </summary>
        None,

        /// <summary>
        /// Content fades out
        /// </summary>
        FadeOut,

        /// <summary>
        /// Content slides out and fades out to the left
        /// </summary>
        SlideAndFadeOutToLeft,

        /// <summary>
        /// Content slides out and fades out to the right
        /// </summary>
        SlideAndFadeOutToRight,

        /// <summary>
        /// Content slides out and fades out to the top
        /// </summary>
        SlideAndFadeOutToTop,

        /// <summary>
        /// Content slides out and fades out to the bottom
        /// </summary>
        SlideAndFadeOutToBottom
    }
}
