using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppTry1.BL.Enumeration
{

    public class EnumClass
    {
        public enum TopicParentType
        {
            DataStructures,
            Others,
            None
        }

        public enum TopicType
        {
            Linked_List,
            Tree,
            Graphs,
            Solid_Principles,
            Design_Patterns,
            None
        }

        public EnumClass()
        {

        }

        public static string GetTopicTypeString(TopicType topicType)
        {
            return topicType.ToString().Replace('_', ' ');
        }

        public static string GetTopicParentTypeString(TopicParentType topicType)
        {
            string topic = "";
            switch (topicType)
            {
                case TopicParentType.DataStructures:
                    topic = "Data Structures";
                    break;
                case TopicParentType.Others:
                    topic = "Others";
                    break;
                default:
                    break;
            }

            return topic;
        }


    }
}