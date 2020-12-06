using System;
using Foundation;

namespace WorkHistory
{
    public class Experience
    {
        private string jobTitle;
        private string description;
        private string company;
        private NSUrl imageUrl;

        public Experience(string jobTitle, string desc, string company, string url)
        {
            this.jobTitle = jobTitle;
            this.description = desc;
            this.company = company;
            this.imageUrl = new NSUrl(url);
        }

        public string GetJobTitle()
        {
            return jobTitle;
        }

        public string GetDescription()
        {
            return description;
        }

        public string GetCompany()
        {
            return company;
        }

        public NSUrl GetNSUrl()
        {
            return imageUrl;
        }
    }
}
