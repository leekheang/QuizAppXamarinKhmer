using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiz_App.Helpers
{
    class QuizHelper
    {
        public string GetTopicDescription(string topic)
        {
            string topicDescription = "";
            if(topic == "History")
            {
                topicDescription = "History"; 
            }
            else if(topic == "Geography")
            {
                topicDescription = "Geography";
            }
            else if (topic == "Space")
            {
                topicDescription = "";
            }
            else if (topic == "Engineer")
            {
                topicDescription = "Engineer";
            }
            else if (topic == "Programming")
            {
                topicDescription = "Programming";
            }
            else if (topic == "Business")
            {
                topicDescription = "Business";
            }
            return topicDescription;
            
        }
    }
}