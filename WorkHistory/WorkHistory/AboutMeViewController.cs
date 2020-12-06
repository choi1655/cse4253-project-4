using System;
using Foundation;
using UIKit;

namespace WorkHistory
{
    public partial class AboutMeViewController : UIViewController
    {
        private readonly AppManager manager;

        public AboutMeViewController(IntPtr handle) : base(handle)
        {
            manager = new AppManager();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            label.TextColor = UIColor.Black;
            myLittleNoteLabel.TextColor = UIColor.Black;
            if (NSUserDefaults.StandardUserDefaults.StringForKey("textContent") == null)
            {
                textBox.Text = "Type in something...";
            }
            else
            {
                textBox.Text = NSUserDefaults.StandardUserDefaults.StringForKey("textContent");
            }

            textBox.BackgroundColor = UIColor.White;
            textBox.TextColor = UIColor.Black;
            textBox.Layer.CornerRadius = 15;

            hiimjohnLabel.TextColor = UIColor.Black;
            myHIstoryBox.TextColor = UIColor.Black;
            myHIstoryBox.BackgroundColor = UIColor.White;
            myHIstoryBox.Layer.CornerRadius = 15;
            myHIstoryBox.Text = manager.GetMyHistory();

            currentGPALabel.TextColor = UIColor.Black;

            var gpa = NSUserDefaults.StandardUserDefaults.DoubleForKey("gpa");
            currentGPALabel.Text = String.Format("My current GPA: {0:0.00} / 4.00", gpa);
            
            slider.TintColor = UIColor.Red;
            slider.Value = (float)gpa;
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            if (textBox.Text == "")
            {
                NSUserDefaults.StandardUserDefaults.SetString("Type in something...", "textContent");
            }
            else
            {
                NSUserDefaults.StandardUserDefaults.SetString(textBox.Text, "textContent");
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void SliderChanged(UISlider sender)
        {
            this.currentGPALabel.Text = String.Format("My current GPA: {0:0.00} / 4.00", sender.Value);
            NSUserDefaults.StandardUserDefaults.SetDouble(sender.Value, "gpa");
        }
    }
}

