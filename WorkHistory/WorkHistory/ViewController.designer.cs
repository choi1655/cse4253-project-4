// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
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
			if (titleLabel != null) {
				titleLabel.Dispose ();
				titleLabel = null;
			}

			if (websiteButton != null) {
				websiteButton.Dispose ();
				websiteButton = null;
			}
		}
	}
}
