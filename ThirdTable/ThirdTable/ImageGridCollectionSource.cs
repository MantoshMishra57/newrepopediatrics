using System;
using UIKit;
using Foundation;


namespace ThirdTable
{
	public class ImageGridCollectionSource : UICollectionViewSource
	{
		public ImageGridCollectionSource ()
		{
		}
		public override nint GetItemsCount (UICollectionView collectionView, nint section)
		{
			return 3;
		}

		public override UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
		{

			var cell = collectionView.DequeueReusableCell ("Cell", indexPath) as UICollectionViewCell;

			return cell;
		}


	}
}

