using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using WebAppTry1.BL.Enumeration;
using static WebAppTry1.BL.Enumeration.EnumClass;

namespace WebAppTry1.Models
{
    public class Topic
    {
        #region Public Properties
        public TopicType TopicName { get; set; }

        public string TopicNameString { get; set; }

        public TopicParent Topicparent { get; set; }

        public string TopicIcon { get; set; }

        public Dictionary<string, List<string>> TopicParentMapping { get; set; }

        public List<SubTopic> SubTopicList { get; set; }

        public SubTopic SubTopicSelected { get; set; }


        #endregion

        #region Constructor
        public Topic(TopicParentType topicParent, TopicType topicName, string subTopicName = "")
        {
            Topicparent = new TopicParent(topicParent);
            TopicName = topicName;
            TopicNameString = EnumClass.GetTopicTypeString(topicName);
            SubTopicList = new List<SubTopic>();
            TopicParentMapping = new Dictionary<string, List<string>>();
            PrepareSubTopicDictonary();

            if (string.IsNullOrWhiteSpace(subTopicName))
            {
                SubTopicSelected = SubTopicList.FirstOrDefault(); 
            }
            else
            {
                SubTopicSelected = SubTopicList.Where(x => x.SubTopicDescription == subTopicName).FirstOrDefault();
            }
        }
        #endregion

        #region Private Method
        private void PrepareTopicDictonary()
        {
            var parentTypeString = EnumClass.GetTopicParentTypeString(TopicParentType.DataStructures);
            if (!TopicParentMapping.ContainsKey(parentTypeString))
            {
                TopicParentMapping.Add(parentTypeString, new List<string>());
            }
            TopicParentMapping[parentTypeString].Add(EnumClass.GetTopicTypeString(TopicType.Linked_List));
            TopicParentMapping[parentTypeString].Add(EnumClass.GetTopicTypeString(TopicType.Tree));

            parentTypeString = EnumClass.GetTopicParentTypeString(TopicParentType.Others);
            if (!TopicParentMapping.ContainsKey(parentTypeString))
            {
                TopicParentMapping.Add(parentTypeString, new List<string>());
            }
        }

        private void PrepareSubTopicDictonary()
        {
            switch (TopicName)
            {
                case TopicType.Linked_List:
                    SubTopicList.Add(new SubTopic("Introduction ", "LL1"));
                    SubTopicList.Add(new SubTopic("Creating a Linked List", "LL2"));
                    break;
                case TopicType.Tree:
                    SubTopicList.Add(new SubTopic("Introduction", "T1"));
                    SubTopicList.Add(new SubTopic("Creating a Tree", "T2"));
                    break;
                case TopicType.Graphs:
                    SubTopicList.Add(new SubTopic("Introduction", "G1"));
                    SubTopicList.Add(new SubTopic("Creating a Graph", "G2"));
                    break;
                case TopicType.Solid_Principles:
                    SubTopicList.Add(new SubTopic("Introduction", "SP1"));
                    SubTopicList.Add(new SubTopic("Single Responsibility Principle", "SP2"));
                    SubTopicList.Add(new SubTopic("Open Closed Principle", "SP3"));
                    break;
                case TopicType.Design_Patterns:
                    SubTopicList.Add(new SubTopic("Introduction", "DP1"));
                    SubTopicList.Add(new SubTopic("Single Responsibility Principle", "DP2"));
                    SubTopicList.Add(new SubTopic("Open Closed Principle", "DP3"));
                    break;
                case TopicType.None:
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}