using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SampleApp
{
	public partial class App : Application
	{
		public static IList<string> PhoneNumbers { get; set; }

		public App()
		{
			InitializeComponent();
			PhoneNumbers = new List<string>();
			MainPage = new NavigationPage(new MainPage());
			// MainPage = new MainPage();
			// MainPage = new SampleAppPage();
			// MainPage = new StackLayoutPage();
			// MainPage = new ContentPage
			// {
			// 	Content = new Label
			// 	{
			// 		Text = "Hello, Forms !",
			// 		VerticalOptions = LayoutOptions.CenterAndExpand,
			// 		HorizontalOptions = LayoutOptions.CenterAndExpand
			// 	}
			// };
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
