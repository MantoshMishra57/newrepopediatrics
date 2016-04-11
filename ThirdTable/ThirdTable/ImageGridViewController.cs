using System;

using UIKit;

namespace ThirdTable
{
	public partial class ImageGridViewController : UIViewController
	{
		public ImageGridViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.theCollectionView.Source = new ImageGridCollectionSource ();

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


