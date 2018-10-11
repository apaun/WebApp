using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppTry1.BL.Enumeration;
using static WebAppTry1.BL.Enumeration.EnumClass;

namespace WebAppTry1.Models
{
    public class TopicParent
    {
        public TopicParentType ParentName { get; set; }

        public string ParentNameString { get; set; }

        public string TopicIcon { get; set; }

        public TopicParent(TopicParentType parentType)
        {
            ParentName = parentType;
            ParentNameString = EnumClass.GetTopicParentTypeString(ParentName);
        }

    }
}