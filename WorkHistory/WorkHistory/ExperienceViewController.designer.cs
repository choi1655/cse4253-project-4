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
	[Register ("ExperienceViewController")]
	partial class ExperienceViewController
	{
		[Outlet]
		UIKit.UIImageView imageView { get; set; }

		[Outlet]
		UIKit.UILabel jobDesc { get; set; }

		[Outlet]
		UIKit.UITextView jobDescriptionBox { get; set; }

		[Outlet]
		UIKit.UILabel jobTitle { get; set; }

		[Outlet]
		UIKit.UILabel jobTitleLabel { get; set; }

		[Outlet]
		UIKit.UIButton lenovoButton { get; set; }

		[Outlet]
		UIKit.UIButton nasaButton { get; set; }

		[Outlet]
		UIKit.UIButton sasButton { get; set; }

		[Outlet]
		UIKit.UILabel titleLabel { get; set; }

		[Action ("ButtonPressed:")]
		partial void ButtonPressed (UIKit.UIButton sender);

		[Action ("LenovoPressed:")]
		partial void LenovoPressed (UIKit.UIButton sender);

		[Action ("NasaPressed:")]
		partial void NasaPressed (UIKit.UIButton sender);

		[Action ("SasPressed:")]
		partial void SasPressed (UIKit.UIButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (titleLabel != null) {
				titleLabel.Dispose ();
				titleLabel = null;
			}

			if (nasaButton != null) {
				nasaButton.Dispose ();
				nasaButton = null;
			}

			if (sasButton != null) {
				sasButton.Dispose ();
				sasButton = null;
			}

			if (lenovoButton != null) {
				lenovoButton.Dispose ();
				lenovoButton = null;
			}

			if (imageView != null) {
				imageView.Dispose ();
				imageView = null;
			}

			if (jobTitle != null) {
				jobTitle.Dispose ();
				jobTitle = null;
			}

			if (jobTitleLabel != null) {
				jobTitleLabel.Dispose ();
				jobTitleLabel = null;
			}

			if (jobDesc != null) {
				jobDesc.Dispose ();
				jobDesc = null;
			}

			if (jobDescriptionBox != null) {
				jobDescriptionBox.Dispose ();
				jobDescriptionBox = null;
			}
		}
	}
}
