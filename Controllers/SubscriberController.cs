using IceCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IceCore.Controllers {
    public class SubscriberController:Controller {
        public ViewResult Index() { 
            return View();
        }
        [HttpGet]
        public ActionResult Signup() {
            return View("Dashboard");
        }

        [HttpPost]
        public ActionResult Signup(Subscriber subscriber) {
            var SubRepos = new SubscriberRepository();
            SubRepos.AddSubscriber(subscriber);
            return View("Dashboard", subscriber);
        }
        [HttpGet]
        public ActionResult Signin() {
            return View("Dashboard");
        }

        [HttpPost]
        public ActionResult Signin(Subscriber subscriber) {
            var SubRepos = new SubscriberRepository();
            if (SubRepos.IsSubscriberExist(subscriber)) {
                return View("Dashboard", subscriber);
            }
            else {
                return View();
            }
        }
    }
}
