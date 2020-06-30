using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace PlayingWithAnimations
{
    public partial class MainPage : ContentPage
    {
        public bool IsOnOff { get; set; }
        
        public MainPage()
        {
            InitializeComponent();

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        private void Clicked(object sender, EventArgs e)
        {
            if (!animationView.IsPlaying)
            {
                if (IsOnOff)
                {
                    animationView.PlayFrameSegment(1, 2);
                    status.Text = "OFF";
                }
                else
                {
                    animationView.PlayFrameSegment(1, 60);
                    status.Text = "ON";
                }

                animationView.Progress = 0;
                IsOnOff = !IsOnOff;
            }
        }

        private void Finished(object sender, EventArgs e)
        {
            animationView.IsPlaying = false;
        }
    }
}