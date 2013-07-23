using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

//test
namespace TeamSalesForAndroid
{
	//[Activity (Label = "TeamSales", MainLauncher = true, Icon="@drawable/Icon72", ConfigurationChanges=Android.Content.PM.ConfigChanges.Orientation)]
	[Activity (Label = "TeamSales",  Icon="@drawable/Icon72", Theme="@android:style/Theme.NoTitleBar")]
	public class MainActivity : TabActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);

			//bool orientamento = PosizioneOrizzontale ();

			CreaTabs();
	
		}


		void CreaTabs()
		{
			TabHost.TabSpec spec;     // Resusable TabSpec for each tab
			Intent intent;            // Reusable Intent for each tab

			// Create an Intent to launch an Activity for the tab (to be reused)
			intent = new Intent (this, typeof (Home));
			intent.AddFlags (ActivityFlags.NewTask);
			// Initialize a TabSpec for each tab and add it to the TabHost
			spec = TabHost.NewTabSpec ("Home");
			spec.SetIndicator ("Home", Resources.GetDrawable (Resource.Drawable.house));
			spec.SetContent (intent);
			TabHost.AddTab (spec);


			intent = new Intent (this, typeof (Customers));
			intent.AddFlags (ActivityFlags.NewTask);
			// Initialize a TabSpec for each tab and add it to the TabHost
			spec = TabHost.NewTabSpec ("Clienti");
			spec.SetIndicator ("Clienti", Resources.GetDrawable (Resource.Drawable.group));
			spec.SetContent (intent);
			TabHost.AddTab (spec);


			intent = new Intent (this, typeof (Orders));
			intent.AddFlags (ActivityFlags.NewTask);
			// Initialize a TabSpec for each tab and add it to the TabHost
			spec = TabHost.NewTabSpec ( "Ordini");
			spec.SetIndicator ("Ordini", Resources.GetDrawable (Resource.Drawable.cabinet));
			spec.SetContent (intent);
			TabHost.AddTab (spec);


			intent = new Intent (this, typeof (Items));
			intent.AddFlags (ActivityFlags.NewTask);
			// Initialize a TabSpec for each tab and add it to the TabHost
			spec = TabHost.NewTabSpec ("Prodotti");
			spec.SetIndicator ("Prodotti", Resources.GetDrawable (Resource.Drawable.star));
			spec.SetContent (intent);
			TabHost.AddTab (spec);


			intent = new Intent (this, typeof (Shop));
			intent.AddFlags (ActivityFlags.NewTask);
			// Initialize a TabSpec for each tab and add it to the TabHost
			spec = TabHost.NewTabSpec ("Carrello");
			spec.SetIndicator ("Carrello", Resources.GetDrawable (Resource.Drawable.shopping));
			spec.SetContent (intent);
			TabHost.AddTab (spec);

			intent = new Intent (this, typeof (Syncronize));
			intent.AddFlags (ActivityFlags.NewTask);
			// Initialize a TabSpec for each tab and add it to the TabHost
			spec = TabHost.NewTabSpec ("Sincronizza");
			spec.SetIndicator ("Sincronizza", Resources.GetDrawable (Resource.Drawable.redo));
			spec.SetContent (intent);
			TabHost.AddTab (spec);

			intent = new Intent (this, typeof (Tools));
			intent.AddFlags (ActivityFlags.NewTask);
			// Initialize a TabSpec for each tab and add it to the TabHost
			spec = TabHost.NewTabSpec ("Strumenti");
			spec.SetIndicator ("Strumenti", Resources.GetDrawable (Resource.Drawable.gear2));
			spec.SetContent (intent);
			TabHost.AddTab (spec);


			intent = new Intent (this, typeof (GiroVisite));
			intent.AddFlags (ActivityFlags.NewTask);
			// Initialize a TabSpec for each tab and add it to the TabHost
			spec = TabHost.NewTabSpec ("Visite");
			spec.SetIndicator ("Visite", Resources.GetDrawable (Resource.Drawable.map));
			spec.SetContent (intent);
			TabHost.AddTab (spec);
		}

		public override void OnConfigurationChanged (Android.Content.Res.Configuration newConfig)
		{
			base.OnConfigurationChanged (newConfig);

			if (newConfig.Orientation == Android.Content.Res.Orientation.Portrait) 
			{
                //
			} 
            else if (newConfig.Orientation ==  Android.Content.Res.Orientation.Landscape) 
			{
                //
			}
		}

		protected override void OnSaveInstanceState (Bundle outState)
		{
			//outState.PutInt ("counter", c);
			base.OnSaveInstanceState (outState);
		}

		bool PosizioneOrizzontale()
		{

			var surfaceOrientation = WindowManager.DefaultDisplay.Rotation;
			if (surfaceOrientation == SurfaceOrientation.Rotation0 ||
			    surfaceOrientation == SurfaceOrientation.Rotation180) 
			{
				return true;
			} 
			else 
			{
				return false;
			}
		}
	}
}


