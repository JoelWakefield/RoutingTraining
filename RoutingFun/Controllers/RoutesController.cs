using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RoutingFun.Controllers
{
    public class RoutesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("{year}/{month}/{day}/{blob}")]
        public IActionResult Blog(string year, string month, string day, string blob)
        {
            List<KeyValuePair<string, string>> pairs = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("year", year),
                new KeyValuePair<string, string>("month", month),
                new KeyValuePair<string, string>("day", day),
                new KeyValuePair<string, string>("blob", blob),
            };

            ViewBag.Pairs = pairs;

            return View("Index");
        }

        [Route("{year}/{month}/{day}/{category?}/{blob}")]
        public IActionResult Blog(string year, string month, string day, string category, string blob)
        {
            List<KeyValuePair<string, string>> pairs = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("year", year),
                new KeyValuePair<string, string>("month", month),
                new KeyValuePair<string, string>("day", day),
                new KeyValuePair<string, string>("category", category),
                new KeyValuePair<string, string>("blob", blob)
            };

            ViewBag.Pairs = pairs;

            return View("Index");
        }

        [Route("watch")]
        public IActionResult Video(string v)
        {
            List<KeyValuePair<string, string>> pairs = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("video code", v)
            };

            ViewBag.Pairs = pairs;

            return View("Index");
        }

        [Route("shows/{show}/video/{encodedString}/{episode}")]
        public IActionResult Video(string show, string encodedString, string episode)
        {
            List<KeyValuePair<string, string>> pairs = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("show", show),
                new KeyValuePair<string, string>("encodedString", encodedString),
                new KeyValuePair<string, string>("episode", episode)
            };

            ViewBag.Pairs = pairs;

            return View("Index");
        }

        [Route("shows/{show}/episode-guide/{season}/{episode}")]
        public IActionResult Show(string show, string season, string episode)
        {
            List<KeyValuePair<string, string>> pairs = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("show", show),
                new KeyValuePair<string, string>("season", season),
                new KeyValuePair<string, string>("episode", episode)
            };

            ViewBag.Pairs = pairs;

            return View("Index");
        }

        [Route("gp/buyagain")]
        public IActionResult Shop(string ie, string ref_)
        {
            List<KeyValuePair<string, string>> pairs = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("ie", ie),
                new KeyValuePair<string, string>("ref_", ref_)
            };

            ViewBag.Pairs = pairs;

            return View("Index");
        }

        [Route("{product}/dp/{code}")]
        public IActionResult Shop(string product, string code, string pd_rd_w, string pf_rd_p, string pf_rd_r, string pd_rd_r, string pd_rd_wg, string pd_rd_i, string psc, string ref_)
        {
            ////  Also a way of getting data
            //ViewBag.Path = Request.Path.ToString();
            //ViewBag.RouteValues = Request.RouteValues;
            //ViewBag.Query = Request.Query;

            List<KeyValuePair<string, string>> pairs = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("product", product),
                new KeyValuePair<string, string>("code", code),
                new KeyValuePair<string, string>("pd_rd_w", pd_rd_w),
                new KeyValuePair<string, string>("pf_rd_p", pf_rd_p),
                new KeyValuePair<string, string>("pf_rd_r", pf_rd_r),
                new KeyValuePair<string, string>("pd_rd_r", pd_rd_r),
                new KeyValuePair<string, string>("pd_rd_wg", pd_rd_wg),
                new KeyValuePair<string, string>("pd_rd_i", pd_rd_i),
                new KeyValuePair<string, string>("psc", psc),
                new KeyValuePair<string, string>("ref_", ref_),
            };

            ViewBag.Pairs = pairs;

            return View("Index");
        }

        [Route("en-us/{tool}/{mode}/{section}")]
        public IActionResult Tools(string tool, string mode, string section)
        {
            List<KeyValuePair<string, string>> pairs = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("tool", tool),
                new KeyValuePair<string, string>("mode", mode),
                new KeyValuePair<string, string>("section", section)
            };

            ViewBag.Pairs = pairs;

            return View("Index");
        }

        [Route("en-us/pdp")]
        public IActionResult Tools(string id)
        {
            List<KeyValuePair<string, string>> pairs = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("id", id)
            };

            ViewBag.Pairs = pairs;

            return View("Index");
        }

        [Route("main")]
        public IActionResult Dynamics(string app, string forceUCI, string pagetype, string id, string type)
        {
            List<KeyValuePair<string, string>> pairs = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("app", app),
                new KeyValuePair<string, string>("forceUCI", forceUCI),
                new KeyValuePair<string, string>("pagetype", pagetype),
                new KeyValuePair<string, string>("id", id),
                new KeyValuePair<string, string>("type", type),
            };

            ViewBag.Pairs = pairs;

            return View("Index");
        }
        
        [Route("manage/environments/{defaultPage}/{tool}/{id}/details")]
        public IActionResult Dynamics(string defaultPage,string tool, string id)
        {
            List<KeyValuePair<string, string>> pairs = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("defaultPage", defaultPage),
                new KeyValuePair<string, string>("tool", tool),
                new KeyValuePair<string, string>("id", id)
            };

            ViewBag.Pairs = pairs;

            return View("Index");
        }

        [Route("environments/environment/{id}/hub")]
        public IActionResult Dynamics(string id, string geo)
        {
            List<KeyValuePair<string, string>> pairs = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("id", id),
                new KeyValuePair<string, string>("geo", geo)
            };

            ViewBag.Pairs = pairs;

            return View("Index");
        }
    }
}
