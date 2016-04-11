using System;
using System.Collections.Generic;
using Foundation;
using Mono;
using ObjCRuntime;
using ThirdTable.Extensions;
using UIKit;

namespace ThirdTable
{
	public class TableViewDataSource: UITableViewSource{
		
		static NSString kCellIdentifier = new NSString ("MyIdentifier");
		private List<string> pediometricImageList;
		private List <string>pediometricLargeImageList;
		private List <string> colorList;
		private List <string> pediometricDiseaseDiscription;
		private List <string> pediometricDiseaseName;
		private List <string>testList;
	    private List <string>testDescription;
		private ViewController viewController;
		private int pIndexPath;
		private int selectedIndexPath;

		public TableViewDataSource (List<string> pediometricImageList,List<string>colorList,List<string>pediometricDiseaseName,
			List<string> pediometricDiseaseDiscription,List <string>pediometricLargeImageList,List <string>testList, List <string>testDescription,ViewController controller){

			this.pediometricLargeImageList = pediometricLargeImageList;
			this.pediometricImageList = pediometricImageList;

			this.colorList = colorList;
			this.viewController = controller;
			this.pediometricDiseaseDiscription = pediometricDiseaseDiscription;
			this.pediometricDiseaseName = pediometricDiseaseName;
			this.testList = testList;
			this.testDescription = testDescription;

		}
		public override nint RowsInSection (UITableView tableView, nint section){
			return pediometricImageList.Count;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			selectedIndexPath = indexPath.Row;
			if(indexPath.Row == 1)
			{
				var	descriptionViewController = viewController.Storyboard.InstantiateViewController ("PediometricSpecificDescriptionVCID") as PediometricSpecificDescriptionVC;
				descriptionViewController.diseaseImageName = pediometricImageList [indexPath.Row];
				descriptionViewController.TestList = this.testList;
				descriptionViewController.TestDescription = this.testDescription;
				descriptionViewController.diseaseLargeImageName = pediometricLargeImageList [indexPath.Row];

				if (selectedIndexPath < colorList.Count) 
				{
					descriptionViewController.cellColor = colorList [selectedIndexPath];
				} 
				else
				{
					selectedIndexPath = selectedIndexPath % colorList.Count;
					descriptionViewController.cellColor = colorList [selectedIndexPath];
				}
				descriptionViewController.pediometricDiseaseName = pediometricDiseaseName [indexPath.Row];
				descriptionViewController.pediometricDiseaseDiscription= pediometricDiseaseDiscription [indexPath.Row];
				viewController.NavigationController.PushViewController (descriptionViewController,false);
			}
			else if(indexPath.Row== 18)
			{
				var	descriptionViewController = viewController.Storyboard.InstantiateViewController ("PrematurityHtmlViewCntrlID") as PrematurityHtmlViewCntrl;
				descriptionViewController.pediometricDiseaseName = pediometricDiseaseName [indexPath.Row];
				descriptionViewController.diseaseLargeImageName = pediometricLargeImageList [indexPath.Row];
				viewController.NavigationController.PushViewController (descriptionViewController,false);
			}
			else
			{

			var	descriptionViewController = viewController.Storyboard.InstantiateViewController ("PediometricDescriptionViewControllerID") as PediometricDescriptionViewController;
			descriptionViewController.diseaseImageName = pediometricImageList [indexPath.Row];
			descriptionViewController.diseaseLargeImageName = pediometricLargeImageList [indexPath.Row];
			if (selectedIndexPath < colorList.Count) 
			{
				descriptionViewController.cellColor = colorList [selectedIndexPath];
			} 
			else
			{
				selectedIndexPath = selectedIndexPath % colorList.Count;
				descriptionViewController.cellColor = colorList [selectedIndexPath];
			}

			descriptionViewController.pediometricDiseaseName = pediometricDiseaseName [indexPath.Row];
			descriptionViewController.pediometricDiseaseDiscription= pediometricDiseaseDiscription [indexPath.Row];
			viewController.NavigationController.PushViewController (descriptionViewController,false);
			}
		}

		public override nfloat GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			return 134;
		}
	
		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = null;
			pIndexPath = indexPath.Row;


			if (indexPath.Row % 2 == 0) 
			{
				cell = tableView.DequeueReusableCell (kCellIdentifier) as FifthTableViewCell;
				if (cell == null)
				{
					var views = NSBundle.MainBundle.LoadNib("FifthTableViewCell", cell, null);
					cell = views.GetItem<FifthTableViewCell>(0);
				}
			}
			else 
			{
				cell = tableView.DequeueReusableCell (kCellIdentifier) as SixthTableViewCell;
				if (cell == null)
				{
					var views = NSBundle.MainBundle.LoadNib("SixthTableViewCell", cell, null);
					cell = views.GetItem<SixthTableViewCell>(0);
				}
			}
			cell.SelectionStyle = UITableViewCellSelectionStyle.None;


			if (cell != null)
			{
				var imageView = cell.ViewWithTag (1001) as UIImageView;
				var descriptionView = cell.ViewWithTag (2001) as UIView;
				var TheDiesaseDescription = cell.ViewWithTag (10001) as UILabel;
				var TheDiesaseName = cell.ViewWithTag (9001) as UILabel;
				imageView.ClipsToBounds = true;
				imageView.Image = UIImage.FromBundle (pediometricImageList [indexPath.Row]);
				UIColor uc = UIColor.Clear;
		
				TheDiesaseName.Text = pediometricDiseaseName [pIndexPath];
				TheDiesaseDescription.Text = pediometricDiseaseDiscription [pIndexPath];

				if (pIndexPath < colorList.Count) 
				{
					descriptionView.BackgroundColor = uc.FromHexString (colorList [pIndexPath]);
				} 
				else
				{
					pIndexPath = pIndexPath % colorList.Count;
					descriptionView.BackgroundColor = uc.FromHexString (colorList [pIndexPath]);
				}
			}

			return cell;
		}
	}
}

