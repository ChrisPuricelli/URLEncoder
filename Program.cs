using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            //int counter = 0;
            string url = null;
            string projectName = null;
            string activityName = null;
            url = "https://companyserver.com/project_Name/files/activity_Name/activity_NameReport.pdf";
            //ASCII Control Characters: {"%00", "%01", "%02", "%03", "%04", "%05", "%06", "%07", "%08", "%09", "%0A", "%0B", "%0C", "%0D", "%0E", "%0F", "%10", "%11", "%12", "%13", "%14", "%15", "%16", "%17", "%18", "%19", "%1A", "%1B", "%1C", "%1D", "%1E", "%1F"};
            //Don't know how to check for them

                Console.WriteLine("What would you like the name of your project to be?");
                projectName = Console.ReadLine();
                Console.WriteLine("Now what would you like the activity name to be?");
                activityName = Console.ReadLine();

                //if (activityName.Contains(" ") == true)

                //Replaces characters in the variables
                projectName = projectName.Replace("%", "%25");
                projectName = projectName.Replace(":", "%3A");
                projectName = projectName.Replace("/", "%2F");
                activityName = activityName.Replace("%", "%25");
                activityName = activityName.Replace(":", "%3A");
                activityName = activityName.Replace("/", "%2F");

                //Replaces spaces in url with the variables
                url = url.Replace("project_Name", projectName);
                url = url.Replace("activity_Name", activityName);

                //Replaces chracters once in the url
                url = url.Replace(" ", "%20");
                url = url.Replace("<", "%3C");
                url = url.Replace(">", "%3E");
                url = url.Replace("#", "%23");
                url = url.Replace("\"", "%22");
                url = url.Replace(";", "%3B");
                url = url.Replace("?", "%3F");
                url = url.Replace("@", "%40");
                url = url.Replace("&", "%26");
                url = url.Replace("=", "%3D");
                url = url.Replace("+", "%2B");
                url = url.Replace("$", "%24");
                url = url.Replace(",", "%2C");
                url = url.Replace("{", "%7B");
                url = url.Replace("}", "%7D");
                url = url.Replace("|", "%7C");
                url = url.Replace("\\", "%5C");
                url = url.Replace("^", "%5E");
                url = url.Replace("[", "%5B");
                url = url.Replace("]", "%5D");
                url = url.Replace("`", "%60");
                url = url.Replace("'", "%27");

            /*for (counter = 0; counter < controls; counter++)
            {
                if (projectName.Contains(controls) == true)
                {
                    Console.WriteLine("Error, invalid chracters detected, please enter new project name.");
                }
                else if (activityName.Contains(controls) == true)
                {
                    Console.WriteLine("Error, invalid chracters detected, please enter new activity name.");
                }
            }*/
            Console.WriteLine("Your URL string is: {0}", url); //Outputs the url with replacements

            Console.ReadLine();
        }
    }
}
