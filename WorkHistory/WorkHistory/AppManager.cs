using System;

namespace WorkHistory
{
    public class AppManager
    {
        public string GetMyHistory()
        {
            return "Hi, I'm John Choi and I study Computer Science and " +
                "Engineering at The Ohio State University.\nI am looking to " +
                "become an iOS developer when I graduate. I had 3 internships " +
                "so far and I am looking for more ways to become a better " +
                "developer.";
        }

        public Experience GetExperience(string CompanyName)
        {
            Experience experience;
            string jobTitle;
            string description;
            string url = "https://johnchoi96.github.io/cse4253/" + CompanyName.ToLower() + ".png";
            switch (CompanyName)
            {
                case "SAS":
                    {
                        jobTitle = "iOS R&D Techinical Intern";
                        description = "Assisted iOS software engineering team";
                        experience = new Experience(jobTitle, description, CompanyName, url);
                    }
                    break;
                case "Lenovo":
                    {
                        jobTitle = "Software Development Intern";
                        description = "Built an application that performs HTTP requests";
                        experience = new Experience(jobTitle, description, CompanyName, url);
                    }
                    break;
                case "NASA":
                    {
                        jobTitle = "Undergraduate Research Software Engineer";
                        description = "Co-authored an abstract titled “Physically Based Hydrology Model in a Snowmelt-Dominant" +
                                                "Watershed for 2020 AGU Fall Meeting.";
                        experience = new Experience(jobTitle, description, CompanyName, url);
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Invalid company name");
            }
            return experience;
        }
    }
}
