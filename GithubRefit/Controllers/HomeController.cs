using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using GithubRefit.Models;
using Refit;

namespace GithubRefit.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {

            var gitHubApi = RestService.For<IGitHubApi>("https://api.github.com");

            var request = new RenderRequest
            {
                Text = "Hello **world**, this is sample markdown [with a URL](http://www.somewhere.com)",
                Mode = "markdown"
            };

            var response = await gitHubApi.RenderAsMarkdown(request);

            ViewBag.Markdown = request.Text;
            ViewBag.Html = response;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}