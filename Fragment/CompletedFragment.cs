using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiz_App.Fragment
{
    public class CompletedFragment : Android.Support.V4.App.DialogFragment
    {
        ImageView thisimage;
        TextView remarksTextView;
        TextView scoreTextView;
        Button goHomeButtion;

        string remarks, score, image;
        public event EventHandler GoHome;

        public CompletedFragment(string _remarks, string _score, string _image)
        {
            remarks = _remarks;
            score = _score;
            image = _image; 

        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.completed, container, false);

            thisimage = (ImageView)view.FindViewById(Resource.Id.image);
            remarksTextView = (TextView)view.FindViewById(Resource.Id.remarksTextView);
            scoreTextView = (TextView)view.FindViewById(Resource.Id.scoreTextView);
            goHomeButtion = (Button)view.FindViewById(Resource.Id.goHomeButton);
            goHomeButtion.Click += GoHomeButtion_Click;

            remarksTextView.Text = remarks;
            scoreTextView.Text = score; 

            if(image == "failed")
            {
                thisimage.SetImageResource(Resource.Drawable.sad);
            }
            return view;
        }

        private void GoHomeButtion_Click(object sender, EventArgs e)
        {
            this.Dismiss();
            GoHome?.Invoke(this , new EventArgs());
        }
    }
}