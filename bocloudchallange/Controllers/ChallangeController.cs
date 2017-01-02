using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Extensions;

namespace bocloudchallange.Controllers
{
    [Route("api")]
    public class ChanllangeController : Controller
    {
        [HttpGet]
        [Route("person")]
        public IActionResult MyPersonalInfo()
        {
            var personalInfo =  new {
                    FirstName = "Ali",
                    LastName = "Özgür",
                    Email = "aliozgur79@gmail.com",
                    Twitter = "@aliozgur",
                    GitHub = "aliozgur",
                    Gravatar = "http://en.gravatar.com/pragmadev"
            };

            return new JsonResult(personalInfo);
        }

        [HttpGet]
        [Route("profile")]
        public IActionResult MyProfile()
        {
            var myProfile = new {
                    Interests = new List<string>(){
                        "Coding",
                        "Open Source",
                        "Writing",
                        "Technology",
                        "Robotics",
                        "Mobile Technologies",
                        ".NET, C#, F#, R, Cloud and Git",
                        "Xamarin"
                    },
                    Blog = "http://aliozgur.net",
                    Projects = new Dictionary<string,string>(){
                        ["PragmaSql"] = "Open source T-SQL editor",
                        ["Xamarin"] = "Couple of open source plugins for Xamarin Forms",
                        ["Serilog.HttpContextData"] = "Enrich your log messages with HttpContext data",
                        ["SeqApps"] = "Seq apps for Jira, Rocket.Chat, GitLab and GitHub",
                    }
            };

            return new JsonResult(myProfile);
        }
        
        [HttpGet]
        [Route("problem")]
        public IActionResult TheProblem()
        {
           
            var url = UriHelper.GetDisplayUrl(this.Request);
            var notFoundMsg = new 
            { 
                Message = $"No HTTP resource was found that matches the request URI '{url}'.",
                ProjectRepository = "https://github.com/aliozgur/bochallange"
            };
            return NotFound( notFoundMsg );

        }
       
    }
}
