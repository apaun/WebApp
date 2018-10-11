using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppTry1.Models
{
    public class SubTopic
    {
        public string SubTopicTopicName { get; set; }

        public string SubTopicDescription { get; set; }


        public SubTopic(string name,string description)
        {
            SubTopicTopicName = name;
            SubTopicDescription = description;
        }
    }
}