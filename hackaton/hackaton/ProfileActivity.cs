
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
	[Activity (Label = "ProfileActivity")]			
	public class ProfileActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			string text = Intent.GetStringExtra ("MyData") ?? "Data not available";
			// Create your application here
			SetContentView(Resource.Layout.User_Profile);
			EditText name = FindViewById<EditText> (Resource.Id.nombre);
			name.Text = text;
		}
	}
}

