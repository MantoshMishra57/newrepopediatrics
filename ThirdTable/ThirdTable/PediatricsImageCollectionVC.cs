using System;

using UIKit;
using System.Collections.Generic;

namespace ThirdTable
{
	public partial class PediatricsImageCollectionVC : UIViewController
	{

		public PediatricsImageCollectionVC (IntPtr handle) : base (handle)
		{
		}

		public List<string> LargeImageList {
			get;
			set;
		}
		public List<string> SmallImageList {
			get;
			set;
		}
		public string pediometricDiseaseName {
			get;
			set;
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.Title = pediometricDiseaseName;
			this.ImageCollectionView.Source = new PediatricsImageCollectionViewSource(pediometricDiseaseName,LargeImageList,SmallImageList, this);
			this.ImageCollectionView.Delegate = new ContentPageDelegate(pediometricDiseaseName,LargeImageList,SmallImageList, this);
			//this.ImageCollectionView.FlashScrollIndicators (false);
			this.ImageCollectionView.ShowsHorizontalScrollIndicator = false;
			this.ImageCollectionView.ShowsVerticalScrollIndicator = false;
			//this.ImageCollectionView.PagingEnabled = true;
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


