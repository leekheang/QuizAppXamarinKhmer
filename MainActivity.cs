using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Quiz_App.Activities;

namespace Quiz_App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainActivity : AppCompatActivity
    {
        Android.Support.V7.Widget.Toolbar toolbar;
        LinearLayout historyLayout;
        LinearLayout geographyLayout;
        LinearLayout spaceLayout;
        LinearLayout engineerLayout;
        LinearLayout programmingLayout;
        LinearLayout businessLayout;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            toolbar = (Android.Support.V7.Widget.Toolbar)FindViewById(Resource.Id.toolbar);
            //setup toolbar
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "topic";
            Android.Support.V7.App.ActionBar actionBar = SupportActionBar;
            actionBar.SetHomeAsUpIndicator(Resource.Drawable.menuaction);
            actionBar.SetDisplayHomeAsUpEnabled(true);
            //View Setups
            historyLayout = (LinearLayout)FindViewById(Resource.Id.historyLayout);
            geographyLayout = (LinearLayout)FindViewById(Resource.Id.geographyLayout);
            spaceLayout = (LinearLayout)FindViewById(Resource.Id.spaceLayout);
            engineerLayout = (LinearLayout)FindViewById(Resource.Id.engineerLayout);
            programmingLayout = (LinearLayout)FindViewById(Resource.Id.programmingLayout);
            businessLayout = (LinearLayout)FindViewById(Resource.Id.businessLayout);

            //Click Event Handlers
            historyLayout.Click += HistoryLayout_Click;
            geographyLayout.Click += GeographyLayout_Click;
            spaceLayout.Click += SpaceLayout_Click;
            engineerLayout.Click += EngineerLayout_Click;
            programmingLayout.Click += ProgrammingLayout_Click;
            businessLayout.Click += BusinessLayout_Click;
        }

        private void BusinessLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Business");
            StartActivity(intent);
        }

        private void ProgrammingLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Programming");
            StartActivity(intent);
        }

        private void EngineerLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Engineer");
            StartActivity(intent);
        }

        private void SpaceLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Space");
            StartActivity(intent);
        }

        private void GeographyLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Geography");
            StartActivity(intent);
        }

        private void HistoryLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "History");
            StartActivity(intent);
        }
    }
}