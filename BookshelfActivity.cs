
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

namespace ProgrammaticallyInterface
{
	[Activity (Label = "BookshelfActivity")]			
	public class BookshelfActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.BookshelfLayout);

			LinearLayout mainLayout = 
				FindViewById<LinearLayout> 
				(Resource.Id.linearLayout2);

			for (int i = 0; i < 10; i++) {
				LinearLayout newLinearLayout = 
					new LinearLayout (this);
				newLinearLayout.Orientation = 
					Orientation.Horizontal;

				for (int j = 0; j < 2; j ++) {
					Button newButton = new Button (this);
					newButton.Text = 
						(i * 2 + j + 1).ToString ();

					newButton.SetBackgroundColor 
					(Android.Graphics.Color.PaleVioletRed);

					LinearLayout.LayoutParams buttonParameters = 
						new LinearLayout.LayoutParams (30, 30);
					buttonParameters.SetMargins
					(0, 0, 5, 0);

					newButton.LayoutParameters = buttonParameters;

					newLinearLayout.AddView (newButton);
				}

				mainLayout.AddView (newLinearLayout);
			}

			// Create your application here
		}
	}
}

