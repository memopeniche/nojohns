
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
	[Activity (Label = "CommentsActivity")]			
	public class CommentsActivity : ListActivity 
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			//SetContentView (Resource.Layout.Comentarios);
			List<Feedback> Comentarios = new List<Feedback> ();
			Comentarios.Add(new Feedback("Comentario1 aksjdhak sjdh akjsdha kjsdh akjsdh ajksdh ajkdh ajksdh akjdhakjsdh akjsdh aksjdha skjdh akjsdhas", 2));
			Comentarios.Add(new Feedback("Comentario2 askjdhas kjdha skjdhas kjdhas djkahs dkjahd kjash dkjash dkjash dkjashd kajsdh aksjdh askjdahskdjah kdj", 2));
			Comentarios.Add(new Feedback("Comentario3", 3));
			Comentarios.Add(new Feedback("Comentario4ajkhd kjashd akjsdh akjsdh ajksdhakjdh ajksdh akjdh ajkshd akjshd akjshd kjadh akjd" +
				"asdasdasdasdasdadasdasdasd asda skdhaksdh kashd akjshd ajksdh a" +
				"sd hasda sdhakjshd ajshd ajkshd ajksdh asdakjshd ajsdh aksjdh aksjd has" +
				"a sdkajhsd jkash djkas hdkja hdkja hsjkas dakjshd kjashd ajshd akjshd akjshd akjshd akjsd as" +
				"d askdja hsdkjah daksjdh akjsdh akjsdh akjsdh kjashd akjdh akjsdh aisd akjshd aksdh as" +
				"d aksdha ksdha sdhaiusd akjshdaiu shd akushd kasd kasdhiuashd aukshd auskd asd" +
				"a suidahs kdjah skdjha sd aksdh aoshiuas daushd alisdh ashd iah ajksdh akjsdh ajksdh ak", 2));
			Comentarios.Add(new Feedback("Comentario5", 2));
			Comentarios.Add(new Feedback("Comentario6", 3));
			Comentarios.Add(new Feedback("Comentario7", 1));
			Comentarios.Add(new Feedback("Comentario8", 2));
			Comentarios.Add(new Feedback("Comentario9", 2));
			Comentarios.Add(new Feedback("Comentario10",3));
			Comentarios.Add(new Feedback("Comentario11",6));
			List <string> items = new List<string> ();
			var id = Intent.Extras.GetString ("id");
			foreach (var i in Comentarios) {
				if (i.id.ToString() == id) {
					items.Add (i.Comment);
				}
			}

			ListAdapter = new ArrayAdapter<string> (this, Android.Resource.Layout.SimpleListItem1, items);
			// Create your application here
		}
	}
}

