using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ControlTemplateDemo
{
    public class MainPageViewModel
    {
        public Command TapCommand { set; get; }

        public MainPageViewModel()
        {
            TapCommand = new Command(() =>
            {
                // Do something
            });
        }
    }
}
