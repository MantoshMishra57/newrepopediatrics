using System;
using UIKit;
using System.Collections.Generic;
using ThirdTable.Extensions;
namespace ThirdTable
{
	public partial class PediometricSpecificDescriptionVC : UIViewController
	{
		private string DiseaseName = "N/A";
		private string DiseaseDiscription = "N/A";
		private string color = "N/A";
		private string ImageName = "N/A";
		private string pediometricLargeImageList = "N/A";
		//private List <string>testList;
	//	private List <string>testDescription;

		public PediometricSpecificDescriptionVC(IntPtr handle) : base (handle)
		{
		}

		public List<string> TestList {
			get;
			set;
		}
		public List<string> TestDescription {
			get;
			set;
		}


//		public List<string> testNameList
//		{
//			get{ return testList; }
//			set { testList = value; }
//
//		}
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

			Console.WriteLine ("TestList {0}",TestList);
			Console.WriteLine ("TestDescription {0}",TestDescription);
			this.Title = DiseaseName;
			this.TheSpecificTableView.SeparatorColor = UIColor.Clear;

			//this.TheContentDescriptionView.AutoresizingMask = UIViewAutoresizing.FlexibleHeight | UIViewAutoresizing.FlexibleWidth;
			this.TheContentDescriptionView.Text =DiseaseDiscription;
			this.TheContentDescriptionView.ShowsHorizontalScrollIndicator = false;
			this.TheContentDescriptionView.ShowsVerticalScrollIndicator = false;


			this.TheSpecificTableView.Source = new PediatricsSpecificTableViewSource (pediometricDiseaseDiscription,pediometricDiseaseName,TestList,TestDescription);
			this.TheSpecificTableView.ShowsHorizontalScrollIndicator = false;
			this.TheSpecificTableView.ShowsVerticalScrollIndicator = false;
			this.TheSpecificTableView.BackgroundColor = UIColor.White;
			this.TheSpecificTableView.Layer.BorderWidth = 1f;
			this.TheSpecificTableView.Layer.BorderColor = UIColor.DarkGray.CGColor;
			this.TheSpecificTableView.ClipsToBounds = true;
		//	this.TheSpecificTableView.ContentInset = new UIEdgeInsets(0,0, 0, 0);
			//this.pediatricsSpecificCell.ContentInsetMA
			// Perform any additional setup after loading the view, typically from a nib.
			UIColor uc = UIColor.Clear;
			ClickToSeeImagesAction.BackgroundColor = uc.FromHexString (cellColor);
		}
		public override void ViewDidLayoutSubviews ()
		{
			this.TheContentDescriptionView.SetContentOffset(new CoreGraphics.CGPoint(0.0,0.0),false);
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
			descriptionViewController.pediometricDiseaseName= pediometricDiseaseName;
			descriptionViewController.diseaseLargeImage = diseaseLargeImageName;
			this.NavigationController.PushViewController (descriptionViewController,false);
		}
	}
}


