using System;
using System.Collections.Generic;

using Xamarin.Forms;
using SegmentedControl.FormsPlugin.Abstractions;
using Xamarin.Essentials;

namespace CustomIosFrameShadowsWithXF45.Views
{
    public partial class CustomFrameControlPage : ContentPage
    {
        public void FrameShadowType_Changed(object sender, SegmentedControl.FormsPlugin.Abstractions.ValueChangedEventArgs e)
        {
            SetFrame(e.NewValue);
        }

        bool firstLoad = true;
        private void SetFrame(int frame)
        {
            if (firstLoad)
            {
                firstLoad = false;
                return;
            }
            // Hide all
            DefaultFrame.IsVisible = CustomFrame.IsVisible = NoShadowFrame.IsVisible = false;

            // Just quick 'n dirty for demo
            if (frame == 0)
            {
                DefaultFrame.IsVisible = true;
            }
            else if (frame == 1)
            {
                CustomFrame.IsVisible = true;
            }
            else if (frame == 2)
            {
                NoShadowFrame.IsVisible = true;
            }
        }

        public CustomFrameControlPage()
        {
            InitializeComponent();
            //Task.Delay(2500)MainThread.BeginInvokeOnMainThread(() =>
            //{
            //    SetFrame(0);
            //});
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //SetFrame(0);
        }
    }
}
