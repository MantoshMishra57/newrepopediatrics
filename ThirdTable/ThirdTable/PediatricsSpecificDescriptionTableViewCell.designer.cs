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
	[Register ("PediatricsSpecificDescriptionTableViewCell")]
	partial class PediatricsSpecificDescriptionTableViewCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView contentDescriptionView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (contentDescriptionView != null) {
				contentDescriptionView.Dispose ();
				contentDescriptionView = null;
			}
		}
	}
}
