using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {

        public Page1()
        {
            var ph = MainPage.CapturedPhoto;
            InitializeComponent();
            if (ph != null)
            {
                MyImage.Source = ImageSource.FromFile(ph.FullPath);
            }
        }

    }
}