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

        public TopicType SelectedTopic { get; set; }

        public List<Topic> Topics { get; set; }

        private TopicParent(TopicParentType parentType, TopicType topicType = TopicType.None, string subTopic = "")
        {
            ParentName = parentType;
            ParentNameString = EnumClass.GetTopicParentTypeString(ParentName);
            SelectedTopic = topicType;
            Topics = new List<Topic>();

        }

        public TopicParent(string parentNameString, string topic = "None", string subTopic = "")
        {
            ParentName = (TopicParentType)Enum.Parse(typeof(TopicParentType), parentNameString);
            ParentNameString = parentNameString;
            SelectedTopic = (TopicType)Enum.Parse(typeof(TopicType), topic);
            Topics = new List<Topic>();
        }


        private void PopulateTopicsList()
        {
            if (ParentName == TopicParentType.DataStructures)
            {
                if (SelectedTopic == TopicType.None)
                {
                    Topics.Add(new Topic(ParentName, TopicType.LinkedList));
                    Topics.Add(new Topic(ParentName, TopicType.Tree));
                }
                else
                {
                    Topics.Add(new Topic(ParentName, SelectedTopic));
                }
                
            }
            else if (ParentName == TopicParentType.Others)
            {
                if (SelectedTopic == TopicType.None)
                {
                    Topics.Add(new Topic(ParentName, TopicType.SolidPrinciples));
                }
                else
                {
                    Topics.Add(new Topic(ParentName, SelectedTopic));
                }
            }
        }

    }
}