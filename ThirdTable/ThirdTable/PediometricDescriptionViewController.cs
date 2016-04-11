using System;
using UIKit;
using ThirdTable.Extensions;
using System.Collections.Generic;

namespace ThirdTable
{
	public partial class PediometricDescriptionViewController : UIViewController
	{
		private string DiseaseName = "N/A";
		private string DiseaseDiscription = "N/A";
		private string color = "N/A";
		private string ImageName = "N/A";
		private string pediometricLargeImageList = "N/A";
		private string pediometricDiseaListImage = "N/A";
		private List <string>pediometricLarImageList;
		private List <string>pediometricSmallImageList;
		public PediometricDescriptionViewController (IntPtr handle) : base (handle)
		{
		}
		public string pediometricDiseaseImage
		{
			get
			{
				return pediometricDiseaListImage;
			}
			set
			{

				pediometricDiseaListImage = value;
			}
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
			pediometricLarImageList = new List<string> () {
				"PneumomediastinumHRI..png",
				"Pneumomediastinum-lat-view-copyHRI..png"
			};
			pediometricSmallImageList = new List<string> () {
				"PneumomediastinumSmall.png",
				"Pneumomediastinum-lat-view-copySmall.png"
			};

			Console.WriteLine("FirstTitle::{0}",pediometricDiseaseName);
			this.NavigationController.NavigationBar.TintColor = UIColor.White;
			UIBarButtonItem.Appearance.SetBackButtonTitlePositionAdjustment(new UIOffset(0, -60), UIBarMetrics.Default);
			this.Title = pediometricDiseaseName;
			base.ViewDidLoad ();
			this.AutomaticallyAdjustsScrollViewInsets = false;
			UIColor uc = UIColor.Clear;
			ContentOfTextView.Text = pediometricDiseaseDiscription;
			ContentOfTextView.ShowsVerticalScrollIndicator = false;
			ContentOfTextView.ShowsHorizontalScrollIndicator = false;
			ClickToSeeImagesAction.BackgroundColor = uc.FromHexString (cellColor);
		}
		public override void ViewDidLayoutSubviews ()
		{
			this.ContentOfTextView.SetContentOffset(new CoreGraphics.CGPoint(0.0,0.0),false);
		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
			
		partial void ClickToSeeImagesAction_TouchUpInside (UIButton sender)
		{

			if( pediometricDiseaseName == "Pneumomedaistinum")
			{
				var	descriptionViewController = this.Storyboard.InstantiateViewController ("PediatricsImageCollectionVCID") as PediatricsImageCollectionVC;
				descriptionViewController.LargeImageList= pediometricLarImageList;
				descriptionViewController.SmallImageList= pediometricSmallImageList;
				descriptionViewController.pediometricDiseaseName = pediometricDiseaseName;
				this.NavigationController.PushViewController (descriptionViewController,false);
			}
			else
			{
				var	descriptionViewController = this.Storyboard.InstantiateViewController ("PediometricImageDescriptionViewControllerId") as PediometricImageDescriptionViewController;
				descriptionViewController.pediometricDiseaseName = pediometricDiseaseName;
				descriptionViewController.diseaseLargeImage = diseaseLargeImageName;
				this.NavigationController.PushViewController (descriptionViewController,false);
			}
		}

	}
}


