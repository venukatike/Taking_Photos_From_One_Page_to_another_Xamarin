using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using Plugin.Media.Abstractions;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public static FileResult CapturedPhoto { get; set; }

        public MainPage()
        {
            InitializeComponent();
        }
        async void btn1(object sender, EventArgs e)
        {
            var photo = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
            {
                Title="Take a Photo"
            });
                CapturedPhoto = photo;
            }
        async void btn2(object sender, EventArgs e)
        {
            var photo = await MediaPicker.CapturePhotoAsync();
            CapturedPhoto = photo;
        }

        async void btn3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
       
    }
}
