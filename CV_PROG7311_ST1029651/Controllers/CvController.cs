using Microsoft.AspNetCore.Mvc;
using CV_PROG7311_ST1029651.Models;

namespace CV_PROG7311_ST1029651.Controllers
{
    public class CvController : Controller
    {
        public IActionResult Cv()
        {
            var model = new CvModel()
            {
                FirstNames = "Raven Pydee",
                LastName = "Lakhraj",
                Email = "ravenlakhraj@gmail.com",
                PhoneNumber = "073 252 5129",
                Location = "6 5th Street, Linden, Randburg 2195",
                LinkedIn = "www.linkedin.com/in/raven-lakhraj-4a0436293\r\n\r\n",
                Summary = "Driven and detail-oriented aspiring software developer versed in full-stack web development. " +
                "Experienced in utilising technologies such as Java, C#, HTML/CSS, SQL, and ASP.NET MVC " +
                "to build efficient and scalable applications. Currently pursuing a Bachelor's degree in " +
                "Computer and Information Sciences with a focus on application development, " +
                "with a proven commitment to delivering quality solutions.",

                TechnicalSkills = new List<string>
                {
                    "Java",
                    "C#",
                    "HTML/CSS",
                    "SQL",
                    "ASP.NET MVC",
                    "Azure Web Services",
                    "Microsoft Entity Framework"
                },

                EducationList = new List<Education>
                {
                    new Education
                    {
                        Name = "Richardsbaai Hoerskool",
                        Duration = "January 2014 - December 2019",
                        Achievement = "National Senior Certificate",
                        EducationLevel = "Secondary"
                    },

                    new Education
                    {
                        Name = "Varsity College Sandton",
                        Duration = "January 2023 - present",
                        Achievement = "Bachelor of Computer and Information Sciences in Application Development",
                        EducationLevel = "Tertiary"
                    }
                }
            };
            return View(model);
        }
    }
}
