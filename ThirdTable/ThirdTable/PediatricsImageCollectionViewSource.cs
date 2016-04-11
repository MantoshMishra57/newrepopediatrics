using System;
using UIKit;
using Foundation;
using System.Collections.Generic;
using CoreGraphics;


namespace ThirdTable
{
	public class PediatricsImageCollectionViewSource : UICollectionViewSource
	{
		private List<string> pediometricLargeImgList;
		private List<string> pediometricSmallImgList;
		private UIViewController pController;
		private string pPediometricDiseaseName;

		public PediatricsImageCollectionViewSource (string pediometricDiseaseName,List <string>thePediometricLargeImgList,List<string> thePediometricSmallImgList,UIViewController controller)
		{
			this.pediometricLargeImgList = thePediometricLargeImgList;
			this.pediometricSmallImgList = thePediometricSmallImgList;
			this.pController = controller;
			this.pPediometricDiseaseName = pediometricDiseaseName;
		}

		public override nint GetItemsCount (UICollectionView collectionView, nint section)
		{
			return pediometricLargeImgList.Count;
		}

		public override UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
		{

			var cell = collectionView.DequeueReusableCell ("Cell", indexPath) as UICollectionViewCell;
			var imageView = cell.ViewWithTag (200001) as UIImageView;
			imageView.ClipsToBounds = true;
			imageView.Image = UIImage.FromBundle (this.pediometricLargeImgList [indexPath.Row]);

			return cell;
		}
			
	}

	public class ContentPageDelegate : UICollectionViewDelegateFlowLayout
	{
		private List<string> ThepediometricLargeImgList;
		//private List<string> TheppPediometricSmalImgList;
		private UIViewController TheController;
		private string ThePediometricDiseaseName;

		public ContentPageDelegate (string pediometricDiseaseName,List <string>thePediometricLargeImgList,List<string> thePediometricSmallImgList,UIViewController controller)
		{
			this.ThepediometricLargeImgList = thePediometricLargeImgList;
			//this.TheppPediometricSmalImgList = thePediometricSmallImgList;
			this.TheController = controller;
			this.ThePediometricDiseaseName = pediometricDiseaseName;
		}

		public override CGSize GetSizeForItem (UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath)
		{
			
			return new CGSize (collectionView.Frame.Size.Width , (collectionView.Frame.Size.Height/2)-50);



		}
		public override void ItemSelected (UICollectionView collectionView, NSIndexPath indexPath)
		{

			var	descriptionViewController = TheController.Storyboard.InstantiateViewController ("PediometricImageDescriptionViewControllerId") as PediometricImageDescriptionViewController;
			descriptionViewController.pediometricDiseaseName = ThePediometricDiseaseName;
			descriptionViewController.diseaseLargeImage = this.ThepediometricLargeImgList [indexPath.Row];
			TheController.NavigationController.PushViewController (descriptionViewController,false);
		}

	}
}

