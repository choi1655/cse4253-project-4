using Foundation;
using System;
using UIKit;
using SafariServices;

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
            //titleLabel.Hidden = false;
            titleLabel.TextColor = UIColor.Black;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void websitePressed(UIButton button)
        {
            var url = new NSUrl("https://johnchoi96.github.io/");
            var sfViewController = new SFSafariViewController(url);
            PresentViewController(sfViewController, true, null);
        }
    }
}