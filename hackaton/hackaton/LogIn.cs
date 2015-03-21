
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
			EditText usuario = FindViewById<EditText> (Resource.Id.username);
			EditText pass = FindViewById<EditText> (Resource.Id.password);
			var item = (List<User>)this.Intent.Extras.GetSerializable ("mylist");
			foreach (var i in item) {
				if (i.user == usuario.Text) {
					if (i.password == pass.Text) {
						usuario.Text = "correcto";
					}
				}
			}
			//Button log = FindViewById<Button> (Resource.Id.login);
			/*log.Click += delegate {
				//MainActivity.IsLogIn = true;
				StartActivity(typeof(MainActivity));
			};*/

			// Create your application here
		}
	}
}

