using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiz_App.Activities
{
    [Activity(Label = "QuizActivity")]
        
    public class QuizActivity : AppCompatActivity
    {
        Android.Support.V7.Widget.Toolbar toolbar; 
        string quizTopic;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.quiz_page);
            quizTopic = Intent.GetStringExtra("Topic");
            toolbar = (Android.Support.V7.Widget.Toolbar)FindViewById(Resource.Id.quizToolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = quizTopic + " Quiz";
            Android.Support.V7.App.ActionBar actionBar = SupportActionBar;
            actionBar.SetHomeAsUpIndicator(Resource.Drawable.outline_arrowback);
            actionBar.SetDisplayHomeAsUpEnabled(true);
            
        }
    }
}