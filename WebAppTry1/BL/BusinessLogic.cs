using System.Collections.Generic;
using WebAppTry1.Models;
using static WebAppTry1.BL.Enumeration.EnumClass;

namespace WebAppTry1.BL
{
    public class BusinessLogic
    {
        #region Private Fields
        #endregion

        #region Public Property
        #endregion

        #region Constructor
        public BusinessLogic()
        {
        }
        #endregion

        #region Public Method
        public Topic GetTopicsList(TopicParentType topicParentType, TopicType topicType, string subTopicName = "")
        {
            var topic = new Topic(topicParentType, topicType, subTopicName);
            return topic;
        }
        #endregion


    }
}