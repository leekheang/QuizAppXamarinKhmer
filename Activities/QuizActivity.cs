using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Quiz_App.DataModels;
using Quiz_App.Fragment;
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
        double correctAnswerCount = 0;
        int timerCounter = 0;
        DateTime dateTime;

        System.Timers.Timer countDown = new System.Timers.Timer();
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
            countDown.Interval = 1000;
            countDown.Elapsed += CountDown_Elapsed;
        }

        private void CountDown_Elapsed(object sender, System.Timers.ElapsedEventArgs e)

        {
            timerCounter++;

            DateTime dt = new DateTime();
            dt = dateTime.AddSeconds(-1);
            var dateDifference = dateTime.Subtract(dt);
            dateTime = dateTime - dateDifference;
            RunOnUiThread(() =>
            {
                timerCounterTextView.Text = dateTime.ToString("mm:ss");
            });

            if(timerCounter == 120)
            {
                countDown.Enabled = false;
                CompleteQuiz();
            }
        }

        void ConnectViews()
        {
            optionARadio = (RadioButton)FindViewById(Resource.Id.optionARadio);
            optionBRadio = (RadioButton)FindViewById(Resource.Id.optionBRadio);
            optionCRadio = (RadioButton)FindViewById(Resource.Id.optionCRadio);
            optionDRadio = (RadioButton)FindViewById(Resource.Id.optionDRadio);

            optionARadio.Click += OptionARadio_Click;
            optionBRadio.Click += OptionBRadio_Click;
            optionCRadio.Click += OptionCRadio_Click;
            optionDRadio.Click += OptionDRadio_Click;

            optionATextView = (TextView)FindViewById(Resource.Id.optionATextView);
            optionBTextView = (TextView)FindViewById(Resource.Id.optionBTextView);
            optionCTextView = (TextView)FindViewById(Resource.Id.optionCTextView);
            optionDTextView = (TextView)FindViewById(Resource.Id.optionDTextView);

            questionTextView = (TextView)FindViewById(Resource.Id.questionTextView);
            quizPositionTextView = (TextView)FindViewById(Resource.Id.quizPositionTextView);
            timerCounterTextView = (TextView)FindViewById(Resource.Id.timerCounterTextView);

            //buttion
            proccedQuizButton = (Button)FindViewById(Resource.Id.processQuizButton);
            proccedQuizButton.Click += ProccedQuizButton_Click;
        }

        private void ProccedQuizButton_Click(object sender, EventArgs e)
        {
            if(!optionARadio.Checked && !optionBRadio.Checked && !optionCRadio.Checked && !optionDRadio.Checked)
            {
                Snackbar.Make((View)sender, "Please choose your answer !!", Snackbar.LengthShort).Show();          
            }
            else if (optionARadio.Checked)
            {
                if(optionATextView.Text == quizQuestionList[quizPosition - 1].Answer)
                {
                    correctAnswerCount++;
                    CorrectAnswer();
                }
                else
                {
                    IncorrectAnswer();
                }
            }
            else if (optionBRadio.Checked)
            {
                if (optionBTextView.Text == quizQuestionList[quizPosition - 1].Answer)

                {
                    correctAnswerCount++;
                    CorrectAnswer();
                }
                else
                {
                    IncorrectAnswer();
                }
            }
            else if (optionCRadio.Checked)
            {
                if (optionCTextView.Text == quizQuestionList[quizPosition - 1].Answer)
                {
                    correctAnswerCount++;
                    CorrectAnswer();
                }
                else
                {
                    IncorrectAnswer();
                }
            }
            else if (optionDRadio.Checked)
            {
                if (optionDTextView.Text == quizQuestionList[quizPosition - 1].Answer)
                {
                    correctAnswerCount++;
                    CorrectAnswer();
                }
                else
                {
                    IncorrectAnswer();
                }
            }
        }

        private void OptionDRadio_Click(object sender, EventArgs e)
        {
            ClearOptionsSelected();
            optionDRadio.Checked = true;
            
        }

        private void OptionCRadio_Click(object sender, EventArgs e)
        {
            ClearOptionsSelected();
            optionCRadio.Checked = true;
            
        }

        private void OptionBRadio_Click(object sender, EventArgs e)
        {
            ClearOptionsSelected();
            optionBRadio.Checked = true;
        }

        private void OptionARadio_Click(object sender, EventArgs e)
        {
            ClearOptionsSelected();
            optionARadio.Checked = true;
        }
        void ClearOptionsSelected()
        {
            optionARadio.Checked = false;
            optionBRadio.Checked = false;
            optionCRadio.Checked = false;
            optionDRadio.Checked = false;
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
            dateTime = new DateTime();
            dateTime = dateTime.AddMinutes(2);
            timerCounterTextView.Text = dateTime.ToString("mm:ss");  
            countDown.Enabled = true;
        }
        void CorrectAnswer()
        {
            CorrectFragment correctFragment = new CorrectFragment();
            var trans = SupportFragmentManager.BeginTransaction();
            correctFragment.Cancelable = false;
            correctFragment.Show(trans, "Correct");
            correctFragment.NextQuestion += CorrectFragment_NextQuestion;
        }
        void IncorrectAnswer()
        {
            IncorrectFragment incorrectFragment = new IncorrectFragment(quizQuestionList[quizPosition - 1].Answer);
            var trans = SupportFragmentManager.BeginTransaction(); 
            incorrectFragment.Cancelable = false;
            incorrectFragment.Show(trans, "Incorrect");
            incorrectFragment.NextQuestion += CorrectFragment_NextQuestion;
        }

      
        private void CorrectFragment_NextQuestion(object sender, EventArgs e)
        {
            quizPosition++;
            if(quizPosition > quizQuestionList.Count)
            {
                CompleteQuiz();
                return;
            }   
            int idx = quizPosition - 1;
            ClearOptionsSelected();
            questionTextView.Text = quizQuestionList[idx].QuizQuestion;
            optionATextView.Text = quizQuestionList[idx].OptionA;
            optionBTextView.Text = quizQuestionList[idx].OptionB;
            optionCTextView.Text = quizQuestionList[idx].OptionC;
            optionDTextView.Text = quizQuestionList[idx].OptionD;

            quizPositionTextView.Text = "Question" + quizPosition.ToString() + "/" + quizQuestionList.Count.ToString();
        }
        void CompleteQuiz()
        {
            timerCounterTextView.Text = dateTime.ToString("00:00");
            countDown.Enabled = true;

            string score = correctAnswerCount.ToString() + "/" + quizQuestionList.Count.ToString();
            double percentage = (correctAnswerCount / double.Parse(quizQuestionList.Count.ToString())) * 100;
            string remarks = "";
            string image = "";
            if(percentage > 50 && percentage < 70)
            {
                remarks = "Very Good result, you\nReally tried";
            }
            else if(percentage >= 70)
            {
                remarks = "Very Outstanding result, you\nKill tried";
            }
            else if (percentage == 50)
            {
                remarks = "You really made it\nAverage result";
            }
            else if (percentage < 50)
            {
                remarks = "So sad you didn't make it, \nBut you can try again";
                image = "failed";
            }
            CompletedFragment completedFragment = new CompletedFragment(remarks , score , image);
            completedFragment.Cancelable = false;
            var trans = SupportFragmentManager.BeginTransaction();
            completedFragment.Show(trans, "Complete");
            completedFragment.GoHome += (sender, e) =>
            {
                this.Finish();
            };
        }
    }
}