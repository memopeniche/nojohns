using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace hackaton
{

	[Activity (Label = "hackaton", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		public bool IsLogIn = false;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			//SetContentView (Resource.Layout.Main);
			SetContentView (Resource.Layout.Main);
			if (!IsLogIn) {
				StartActivity(typeof(LogIn));
			} else {
				//SetContentView (Resource.Layout.Main);
			}
		}
	}
}


