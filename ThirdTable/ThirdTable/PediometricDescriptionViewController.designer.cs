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
	[Register ("PediometricDescriptionViewController")]
	partial class PediometricDescriptionViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ClickToSeeImagesAction { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView ContentOfTextView { get; set; }

		[Action ("ClickToSeeImagesAction_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void ClickToSeeImagesAction_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (ClickToSeeImagesAction != null) {
				ClickToSeeImagesAction.Dispose ();
				ClickToSeeImagesAction = null;
			}
			if (ContentOfTextView != null) {
				ContentOfTextView.Dispose ();
				ContentOfTextView = null;
			}
		}
	}
}
