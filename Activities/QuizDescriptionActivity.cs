using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Quiz_App.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiz_App.Activities
{
    [Activity(Label = "QuizDescriptionActivity", Theme = "@style/AppTheme")]
    public class QuizDescriptionActivity : AppCompatActivity

        
    {
        TextView quizTopicTextView;
        TextView descriptionTextView;
        ImageView quizImageView;
        Button startQuizButtion;
        // Variable 
        string quizTopic;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.selected_topic);

            quizTopicTextView = (TextView)FindViewById(Resource.Id.quizTopicText);
            descriptionTextView = (TextView)FindViewById(Resource.Id.quizDescriptionText);
            quizImageView = (ImageView)FindViewById(Resource.Id.quizeImage);
            startQuizButtion = (Button)FindViewById(Resource.Id.quizStartQuizButton);
            quizTopic = Intent.GetStringExtra("topic");
            quizTopicTextView.Text = quizTopic;
            quizImageView.SetImageResource(GetImage(quizTopic));
            QuizHelper quizHelper = new QuizHelper();
            descriptionTextView.Text = quizHelper.GetTopicDescription(quizTopic);
            
        }
        int GetImage(string topic)
        {
            int imageInt = 0;
            if (topic == "History")
            {
                imageInt = Resource.Drawable.history;
            }
            else if (topic == "Geography")
            {
                imageInt = Resource.Drawable.geography;
            }
            else if (topic == "Space")
            {
                imageInt = Resource.Drawable.space;
            }
            else if (topic == "Engineer")
            {
                imageInt = Resource.Drawable.engineer;
            }
            else if (topic == "Programming")
            {
                imageInt = Resource.Drawable.program;
            }
            else if (topic == "Business"){
                imageInt = Resource.Drawable.business;
            }
            return imageInt;
        }
    }
}