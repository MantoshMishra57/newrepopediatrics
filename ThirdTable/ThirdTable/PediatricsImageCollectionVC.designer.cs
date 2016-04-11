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
	[Register ("PediatricsImageCollectionVC")]
	partial class PediatricsImageCollectionVC
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UICollectionView ImageCollectionView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ImageCollectionView != null) {
				ImageCollectionView.Dispose ();
				ImageCollectionView = null;
			}
		}
	}
}
