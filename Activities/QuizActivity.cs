using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Quiz_App.DataModels;
using Quiz_App.Helpers;
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
        RadioButton optionARadio, optionBRadio, optionCRadio, optionDRadio;
        TextView optionATextView, optionBTextView, optionCTextView, optionDTextView, questionTextView, quizPositionTextView, timerCounterTextView;
        Button proccedQuizButton;
        List<Question> quizQuestionList = new List<Question>();
        QuizHelper quizHelper = new QuizHelper();

        string quizTopic;
        int quizPosition;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.quiz_page);
            quizTopic = Intent.GetStringExtra("topic");
            toolbar = (Android.Support.V7.Widget.Toolbar)FindViewById(Resource.Id.quizToolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = quizTopic + " Quiz";
            Android.Support.V7.App.ActionBar actionBar = SupportActionBar;
            actionBar.SetHomeAsUpIndicator(Resource.Drawable.outline_arrowback);
            actionBar.SetDisplayHomeAsUpEnabled(true);
            ConnectViews();
            BeginQuiz();
        }
        void ConnectViews()
        {
            optionARadio = (RadioButton)FindViewById(Resource.Id.optionARadio);
            optionBRadio = (RadioButton)FindViewById(Resource.Id.optionBRadio);
            optionCRadio = (RadioButton)FindViewById(Resource.Id.optionCRadio);
            optionDRadio = (RadioButton)FindViewById(Resource.Id.optionDRadio);

            optionATextView = (TextView)FindViewById(Resource.Id.optionATextView);
            optionBTextView = (TextView)FindViewById(Resource.Id.optionBTextView);
            optionCTextView = (TextView)FindViewById(Resource.Id.optionCTextView);
            optionDTextView = (TextView)FindViewById(Resource.Id.optionDTextView);

            questionTextView = (TextView)FindViewById(Resource.Id.questionTextView);
            quizPositionTextView = (TextView)FindViewById(Resource.Id.quizPositionTextView);
            timerCounterTextView = (TextView)FindViewById(Resource.Id.timeCounterTextView);

            //buttion
            proccedQuizButton = (Button)FindViewById(Resource.Id.processQuizButton);
        }
        void BeginQuiz()
        {
            quizPosition = 1;
            quizQuestionList = quizHelper.GetQuizQuestions(quizTopic);
            questionTextView.Text = quizQuestionList[0].QuizQuestion;

            optionATextView.Text = quizQuestionList[0].OptionA;
            optionBTextView.Text = quizQuestionList[0].OptionB;
            optionCTextView.Text = quizQuestionList[0].OptionC;
            optionDTextView.Text = quizQuestionList[0].OptionD;

            quizPositionTextView.Text = "Question " + quizPosition.ToString() + "/" + quizQuestionList.Count();
        }
    }
}