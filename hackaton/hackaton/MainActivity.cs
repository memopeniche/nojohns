using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace hackaton
{

	[Activity (Label = "hackaton", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			List<User> Usuarios = new List<User> ();
			Usuarios.Add(new User("Eduardo", "Alonzo", "9982429063",
				"eduardinio33340@gmail.com", "smz 46 mz 11", "eduardinio", "pato"));

			// Set our view from the "main" layout resource
			//SetContentView (Resource.Layout.Main);
			SetContentView (Resource.Layout.Main);
			Button boton = FindViewById<Button> (Resource.Id.user);
			TextView nombre = FindViewById<TextView> (Resource.Id.nombre1);
			boton.Click += delegate {
				nombre.Text = Usuarios[0].name;
			};
		}
	}
}


