
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace hackaton
{
	[Activity (Label = "LogIn")]			
	public class LogIn : Android.App.Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Login_Screen);
			//Button log = FindViewById<Button> (Resource.Id.login);
			/*log.Click += delegate {
				//MainActivity.IsLogIn = true;
				StartActivity(typeof(MainActivity));
			};*/

			// Create your application here
		}
	}
}

