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
        UIKit.UIButton aboutMeButton { get; set; }


        [Outlet]
        UIKit.UIButton experiencesButton { get; set; }


        [Outlet]
        UIKit.UILabel titleLabel { get; set; }


        [Outlet]
        UIKit.UIButton websiteButton { get; set; }


        [Action ("WebsitePressed:")]
        partial void WebsitePressed (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
        }
    }
}