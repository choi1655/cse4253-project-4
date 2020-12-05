// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace WorkHistory
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UILabel titleLabel { get; set; }


        [Outlet]
        UIKit.UIButton websiteButton { get; set; }


        [Action ("aboutMePressed:")]
        partial void aboutMePressed (UIKit.UIButton sender);


        [Action ("experiencePressed:")]
        partial void experiencePressed (UIKit.UIButton sender);


        [Action ("websitePressed:")]
        partial void websitePressed (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
        }
    }
}