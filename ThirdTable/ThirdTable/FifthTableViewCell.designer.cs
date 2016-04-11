// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ThirdTable
{
	[Register ("FifthTableViewCell")]
	partial class FifthTableViewCell
	{
		[Outlet]
		UIKit.UIView descriptionView { get; set; }

		[Outlet]
		UIKit.UIImageView pediometricImageView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel TheDiesaseDescription { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel TheDiesaseName { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (descriptionView != null) {
				descriptionView.Dispose ();
				descriptionView = null;
			}
			if (pediometricImageView != null) {
				pediometricImageView.Dispose ();
				pediometricImageView = null;
			}
			if (TheDiesaseDescription != null) {
				TheDiesaseDescription.Dispose ();
				TheDiesaseDescription = null;
			}
			if (TheDiesaseName != null) {
				TheDiesaseName.Dispose ();
				TheDiesaseName = null;
			}
		}
	}
}
