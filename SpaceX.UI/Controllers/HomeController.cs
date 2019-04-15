using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using SpaceX.API.Models;
using System.Net.Http;
using SpaceX.API.Helpers;
using Newtonsoft.Json;
using SpaceX.API.Processors;

namespace SpaceX.UI.Controllers
{
    public class HomeController : Controller
    {
        APIHelper _api = new APIHelper();

        public ActionResult Index()
        {
            return View();
        }        

        public async Task<ActionResult> AllLaunches()
        {
            List<LaunchModel> launches = new List<LaunchModel>();
            launches = await LaunchProcessor.GetAllLaunches();

            return View(launches);
        }
    }
}