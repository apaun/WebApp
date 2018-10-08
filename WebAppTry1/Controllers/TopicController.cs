using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppTry1.BL;
using WebAppTry1.Models;
using static WebAppTry1.BL.Enumeration.EnumClass;

namespace WebAppTry1.Controllers
{
    public class TopicController : Controller
    {
        private static Topic topic;

        public TopicController()
        {

        }
            

        // GET: Topic
        public ActionResult TopicPage(string topicParent = "", string topicName = "", string subtopicName = "")
        {
            var bl = new BusinessLogic();
            Topic topic = null;
            string text = "";

            if (string.IsNullOrWhiteSpace(topicParent) || string.IsNullOrWhiteSpace(topicName))
                return View("~/Views/Home/Offering.cshtml");

            var topicParentType = (TopicParentType)Enum.Parse(typeof(TopicParentType), topicParent);
            var topicType = (TopicType)Enum.Parse(typeof(TopicType), topicName);
            topic = bl.GetTopicsList(topicParentType, topicType, subtopicName);

            if (topic == null)
                throw new Exception("Topic Not Found...");

            ViewBag.Topic = topic;
            ViewBag.Text = text;

            return View();
        }
    }
}