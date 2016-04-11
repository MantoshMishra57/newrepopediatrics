using System;

using UIKit;
using CoreGraphics;

namespace ThirdTable
{
	public partial class PediometricImageDescriptionViewController : UIViewController
	{
		public static string pediometricLargeImage = "N/A";
		public static string DiseaseName = "N/A";
		public PediometricImageDescriptionViewController (IntPtr handle) : base (handle)
		{
		}
		public string diseaseLargeImage
		{
			get
			{
				
				return pediometricLargeImage;
			}
			set
			{

				pediometricLargeImage = value;
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
		public override void ViewDidLoad ()
		{
			//Console.WriteLine("Name::{0}",diseaseLargeImage);
			//Console.WriteLine("Title::{0}",pediometricDiseaseName);
			this.Title = DiseaseName;
	

			base.ViewDidLoad ();
			this.NavigationController.NavigationBar.TintColor = UIColor.White;

			UIScrollView scrollView;
			UIImageView imageView;


			scrollView = new UIScrollView (
				new CoreGraphics.CGRect (0,0, this.View.Frame.Width
					, this.View.Frame.Height-50));
			scrollView.BackgroundColor = UIColor.White;
			scrollView.AutoresizingMask = UIViewAutoresizing.FlexibleHeight | UIViewAutoresizing.FlexibleWidth;
			this.View.AddSubview (scrollView);

			imageView = new UIImageView (new CoreGraphics.CGRect (0, 0, scrollView.Frame.Width
				, scrollView.Frame.Height-50));
			imageView.Image = UIImage.FromBundle (diseaseLargeImage);
			imageView.AutoresizingMask = UIViewAutoresizing.FlexibleHeight | UIViewAutoresizing.FlexibleWidth;
			scrollView.ContentSize = imageView.Image.Size;
			imageView.BackgroundColor = UIColor.Clear;
			imageView.ContentMode = UIViewContentMode.Center;
			imageView.ContentMode = UIViewContentMode.ScaleAspectFit;
		
			scrollView.AddSubview (imageView);

			scrollView.MaximumZoomScale = 3f;
			scrollView.MinimumZoomScale = .1f;
			CGPoint pt;
			pt = imageView.Center;
			UIView.Animate (2, 0, UIViewAnimationOptions.CurveEaseInOut | UIViewAnimationOptions.Autoreverse,
				() => {
					scrollView.ViewForZoomingInScrollView += (UIScrollView sv) => { return imageView; }; 
					},
				() => {
					}
			);
		

		}


		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

