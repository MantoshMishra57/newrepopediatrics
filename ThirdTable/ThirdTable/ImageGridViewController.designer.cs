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
	[Register ("ImageGridViewController")]
	partial class ImageGridViewController
	{
		[Outlet]
		UIKit.UICollectionView theCollectionView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UICollectionView TheCollectionView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (TheCollectionView != null) {
				TheCollectionView.Dispose ();
				TheCollectionView = null;
			}
		}
	}
}
