using System;
using CoreFoundation;
using Foundation;
using UIKit;

namespace WorkHistory
{
    public partial class ExperienceViewController : UIViewController
    {
        private readonly AppManager manager;

        public ExperienceViewController(IntPtr handle) : base(handle)
        {
            manager = new AppManager();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            titleLabel.TextColor = UIColor.Black;

            nasaButton.Layer.CornerRadius = 15;
            sasButton.Layer.CornerRadius = 15;
            lenovoButton.Layer.CornerRadius = 15;

            jobTitle.TextColor = UIColor.Black;
            jobTitleLabel.TextColor = UIColor.Black;
            jobDesc.TextColor = UIColor.Black;

            jobDescriptionBox.Layer.CornerRadius = 15;

            // set up using first element
            var exp = manager.GetExperience("NASA");
            jobTitleLabel.Text = exp.GetJobTitle();
            jobDescriptionBox.Text = exp.GetDescription();
            UpdateImage(exp);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void ButtonPressed(UIButton sender)
        {
            var exp = manager.GetExperience(sender.TitleLabel.Text);
            jobTitleLabel.Text = exp.GetJobTitle();
            jobDescriptionBox.Text = exp.GetDescription();
            UpdateImage(exp);
        }

        private void UpdateImage(Experience Ex)
        {
            NSUrlSession session = NSUrlSession.SharedSession;
            var dataTask = session.CreateDataTask(new NSUrlRequest(Ex.GetNSUrl()), (data, response, error) =>
            {
                if (response != null)
                {
                    DispatchQueue.MainQueue.DispatchAsync(() =>
                    {
                        imageView.Image = UIImage.LoadFromData(data);
                    });
                }
            });

            dataTask.Resume();
        }
    }
}

