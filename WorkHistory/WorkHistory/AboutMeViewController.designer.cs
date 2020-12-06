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
	[Register ("AboutMeViewController")]
	partial class AboutMeViewController
	{
		[Outlet]
		UIKit.UILabel currentGPALabel { get; set; }

		[Outlet]
		UIKit.UILabel hiimjohnLabel { get; set; }

		[Outlet]
		UIKit.UILabel label { get; set; }

		[Outlet]
		UIKit.UITextView myHIstoryBox { get; set; }

		[Outlet]
		UIKit.UILabel myLittleNoteLabel { get; set; }

		[Outlet]
		UIKit.UISlider slider { get; set; }

		[Outlet]
		UIKit.UITextView textBox { get; set; }

		[Action ("SliderChanged:")]
		partial void SliderChanged (UIKit.UISlider sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (hiimjohnLabel != null) {
				hiimjohnLabel.Dispose ();
				hiimjohnLabel = null;
			}

			if (label != null) {
				label.Dispose ();
				label = null;
			}

			if (myHIstoryBox != null) {
				myHIstoryBox.Dispose ();
				myHIstoryBox = null;
			}

			if (myLittleNoteLabel != null) {
				myLittleNoteLabel.Dispose ();
				myLittleNoteLabel = null;
			}

			if (textBox != null) {
				textBox.Dispose ();
				textBox = null;
			}

			if (currentGPALabel != null) {
				currentGPALabel.Dispose ();
				currentGPALabel = null;
			}

			if (slider != null) {
				slider.Dispose ();
				slider = null;
			}
		}
	}
}
