using System;
using Foundation;
using SafariServices;
using UIKit;

namespace WorkHistory
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            titleLabel.TextColor = UIColor.Black;

            aboutMeButton.Layer.CornerRadius = 15;
            experiencesButton.Layer.CornerRadius = 15;
            websiteButton.Layer.CornerRadius = 15;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void WebsitePressed(UIButton Button)
        {
            var url = new NSUrl("https://johnchoi96.github.io/");
            var sfViewController = new SFSafariViewController(url);
            PresentViewController(sfViewController, true, null);
        }
    }
}