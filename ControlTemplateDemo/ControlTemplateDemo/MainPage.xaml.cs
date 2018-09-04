using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ControlTemplateDemo
{
    public partial class MainPage : ContentPage
    {
        public static readonly BindableProperty TapCommandProperty = BindableProperty.Create("TapCommand", typeof(Command), typeof(MainPage), null);
        public Command TapCommand
        {
            set
            {
                SetValue(TapCommandProperty, value);
            }
            get
            {
                return (Command)GetValue(TapCommandProperty);
            }
        }
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
