using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PageControlSample.ViewModels;

namespace Xamarin.Forms.PageControlSample
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            this.BindingContext = new MainViewModel();

            Xamarin.Forms.PageControl.PageControl a = new PageControl.PageControl();
            a.ShowIndicator = true;

        }
	}
}
