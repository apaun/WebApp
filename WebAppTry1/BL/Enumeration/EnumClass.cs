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
            LinkedList,
            Tree,
            SolidPrinciples,
            None
        }

        public EnumClass()
        {

        }

        public static string GetTopicTypeString(TopicType topicType)
        {
            string topic = "";
            switch (topicType)
            {
                case TopicType.LinkedList:
                    topic = "Linked List";
                    break;
                case TopicType.Tree:
                    topic = "Tree";
                    break;
                case TopicType.SolidPrinciples:
                    topic = "Solid Principles";
                    break;
                default:
                    break;
            }

            return topic;
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