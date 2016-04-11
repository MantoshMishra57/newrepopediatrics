using System;
using UIKit;
using ThirdTable.Extensions;

namespace ThirdTable
{
	public partial class PediometricSpecificDescriptionViewController : UIViewController
	{
		private string DiseaseName = "N/A";
		private string DiseaseDiscription = "N/A";
		private string color = "N/A";
		private string ImageName = "N/A";
		private string pediometricLargeImageList = "N/A";
		public PediometricSpecificDescriptionViewController(IntPtr handle) : base (handle)
		{
		}
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
		public string pediometricDiseaseDiscription
		{
			get
			{
				return DiseaseDiscription;
			}
			set
			{

				DiseaseDiscription = value;
			}

		}
		public string cellColor
		{
			get
			{
				return color;
			}
			set
			{

				color = value;
			}

		}
		public string diseaseImageName
		{
			get
			{
				return ImageName;
			}
			set
			{

				ImageName = value;
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
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			Console.WriteLine("Name::{0}",diseaseLargeImageName);
			this.NavigationController.NavigationBar.TintColor = UIColor.White;
			UIBarButtonItem.Appearance.SetBackButtonTitlePositionAdjustment(new UIOffset(0, -60), UIBarMetrics.Default);
			this.Title = pediometricDiseaseName;
			base.ViewDidLoad ();
			this.AutomaticallyAdjustsScrollViewInsets = false;
			UIColor uc = UIColor.Clear;
		//	this.pediatricsContentOfTextView.Text = pediometricDiseaseDiscription;
		//	this.ClickToSeeImagesAction.BackgroundColor = uc.FromHexString (cellColor);
		//	this.pediatricsListTable.Source = new PediatricsSpecificTableViewSource(diseaseLargeImageName,diseaseImageName,cellColor,
			//	pediometricDiseaseDiscription,pediometricDiseaseName);
			// Perform any additional setup after loading the view, typically from a nib.
		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

//		partial void ClickToSeeImagesAction_TouchUpInside (UIButton sender)
//		{
//			//throw new NotImplementedException ();
//			var	descriptionViewController = this.Storyboard.InstantiateViewController ("PediometricImageDescriptionViewControllerId") as PediometricImageDescriptionViewController;
//		//	descriptionViewController.pediometricDiseaseName= pediometricDiseaseName;
//		//	descriptionViewController.diseaseLargeImage = diseaseLargeImageName;
//			this.NavigationController.PushViewController (descriptionViewController,false);
//		}
	}
}


