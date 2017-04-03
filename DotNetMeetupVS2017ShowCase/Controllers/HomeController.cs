using DotNetMeetupVS2017ShowCase.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetMeetupVS2017ShowCase.Controllers
{
    public class HomeController : Controller
    {
        private MessageProvider _messageProvider;

        public HomeController()
        {
            _messageProvider = new MessageProvider();
        }
        public ActionResult Index()
        {
            return View(_messageProvider.GetMessage(MessageTyp.IndexPage));
        }

        public ActionResult About()
        {
            return View(_messageProvider.GetMessage(MessageTyp.AboutPage));
        }

        public ActionResult Contact()
        {
            //TODO Show IntelliSense
            return View(_messageProvider.GetMessage(MessageTyp.IndexPage));
        }
    }
}