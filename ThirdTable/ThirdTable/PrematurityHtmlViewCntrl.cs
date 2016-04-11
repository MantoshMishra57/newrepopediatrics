using System;

using UIKit;
using System.IO;
using Foundation;

namespace ThirdTable
{
	public partial class PrematurityHtmlViewCntrl : UIViewController
	{
		//		public PrematurityHtmlViewCntrl () : base ("PrematurityHtmlViewCntrl", null)
//		{
//		}
		private string DiseaseName = "N/A";
		private string pediometricLargeImageList = "N/A";
		public string pediometricDiseaseName
		{
			get
			{
				return DiseaseName;
			}
			set
			{

				DiseaseName = value;
			}

		}
		public string diseaseLargeImageName
		{
			get
			{
				return pediometricLargeImageList;
			}
			set
			{

				pediometricLargeImageList = value;
			}

		}
		public PrematurityHtmlViewCntrl (IntPtr handle) : base (handle)
		{
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.Title = pediometricDiseaseName;
			this.View.BackgroundColor = UIColor.White;
			string fileName = "prematurity.html"; // remember case-sensitive
			string localHtmlUrl = Path.Combine (NSBundle.MainBundle.BundlePath, fileName);
			HtmlWebView.LoadRequest(new NSUrlRequest(new NSUrl(localHtmlUrl, false)));
			HtmlWebView.ScalesPageToFit = false;
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void ClickToSeeImagesAction_TouchUpInside (UIButton sender)
		{
			//throw new NotImplementedException ();
			var	descriptionViewController = this.Storyboard.InstantiateViewController ("PediometricImageDescriptionViewControllerId") as PediometricImageDescriptionViewController;
			descriptionViewController.pediometricDiseaseName = pediometricDiseaseName;
			descriptionViewController.diseaseLargeImage = diseaseLargeImageName;
			this.NavigationController.PushViewController (descriptionViewController,false);
		}
	}
}


