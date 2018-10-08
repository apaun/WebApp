using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppTry1.BL.Enumeration;
using static WebAppTry1.BL.Enumeration.EnumClass;

namespace WebAppTry1.Models
{
    public class Topic
    {
        #region Public Properties
        public TopicParentType TopicParent { get; set; }

        public string TopicParentString { get; set; }

        public TopicType TopicName { get; set; }

        public string TopicNameString { get; set; }

        public string TopicIcon { get; set; }

        public Dictionary<string, List<string>> TopicParentMapping { get; set; }

        public Dictionary<string, string> SubTopicDictionary { get; set; }

        public KeyValuePair<string, string> SubTopicSelected { get; set; }

        #endregion

        #region Constructor
        public Topic(TopicParentType topicParent, TopicType topicName, string subTopicName = "")
        {
            TopicParent = topicParent;
            TopicParentString = EnumClass.GetTopicParentTypeString(topicParent);
            TopicName = topicName;
            TopicNameString = EnumClass.GetTopicTypeString(topicName);
            SubTopicDictionary = new Dictionary<string, string>();
            TopicParentMapping = new Dictionary<string, List<string>>();
            PrepareSubTopicDictonary();

            if (string.IsNullOrWhiteSpace(subTopicName))
            {
                SubTopicSelected = SubTopicDictionary.FirstOrDefault();
            }
            else
            {
                SubTopicSelected = SubTopicDictionary.Where(x => x.Key == subTopicName).FirstOrDefault();
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
            TopicParentMapping[parentTypeString].Add(EnumClass.GetTopicTypeString(TopicType.LinkedList));
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
                case TopicType.LinkedList:
                    SubTopicDictionary.Add("LL1", "Introduction");
                    SubTopicDictionary.Add("LL2", "Creating a Linked List");
                    break;
                case TopicType.Tree:
                    SubTopicDictionary.Add("T1", "Introduction");
                    SubTopicDictionary.Add("T2", "Creating a Tree");
                    break;
                case TopicType.SolidPrinciples:
                    SubTopicDictionary.Add("SP1", "Introduction");
                    SubTopicDictionary.Add("SP2", "Single Responsibility Principle");
                    SubTopicDictionary.Add("SP3", "Open Closed Principle");
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}