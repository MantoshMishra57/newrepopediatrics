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
	[Register ("UltrasoundParametersAndTheNonstressTestTableViewCell")]
	partial class UltrasoundParametersAndTheNonstressTestTableViewCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel testDescription { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel testName { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (testDescription != null) {
				testDescription.Dispose ();
				testDescription = null;
			}
			if (testName != null) {
				testName.Dispose ();
				testName = null;
			}
		}
	}
}
