using System;
using UIKit;
using Foundation;
using System.Collections.Generic;

namespace ThirdTable
{
	public class PediatricsSpecificTableViewSource : UITableViewSource
	{
		//private string thePediometricDiseaseDiscription;
		private List <string>testList;
		private List <string>testDescription;
		//private int pIndexPath;

		public PediatricsSpecificTableViewSource (string pediometricDiseaseDiscription,string pediometricDiseaseName,List <string>TheTestList,List <string>TheTestDescription)
		{
			//this.thePediometricDiseaseDiscription = pediometricDiseaseDiscription;
			this.testList = TheTestList;
			this.testDescription = TheTestDescription;
		}
		static NSString kCellIdentifier = new NSString ("MyIdentifier");


		public override nint RowsInSection (UITableView tableView, nint section){
			return testList.Count;
		}

		public override nfloat GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
//			if (indexPath.Row == 0) {
//				return 200;
//			} else {
			return 70;
			//}
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = null;
			//pIndexPath = indexPath.Row;


//			if (indexPath.Row == 0) 
//			{
//				cell = tableView.DequeueReusableCell (kCellIdentifier) as UltrasoundParametersAndTheNonstressTestTableViewCell;
//				if (cell == null)
//				{
//					var views = NSBundle.MainBundle.LoadNib("UltrasoundParametersAndTheNonstressTestTableViewCell", cell, null);
//					cell = views.GetItem<UltrasoundParametersAndTheNonstressTestTableViewCell>(0);
//				}
//				var TestNameLabel = cell.ViewWithTag (3200) as UILabel;
//				var TestDescriptionLabel = cell.ViewWithTag (3300) as UILabel;
//				TestNameLabel.Text = testList[indexPath.Row];
//				TestDescriptionLabel.Text = testDescription[indexPath.Row];
//			}
//			else 
//			{
			cell = tableView.DequeueReusableCell (kCellIdentifier) as UltrasoundParametersAndTheNonstressTestTableViewCell;
				if (cell == null)
				{
					var views = NSBundle.MainBundle.LoadNib("UltrasoundParametersAndTheNonstressTestTableViewCell", cell, null);
					cell = views.GetItem<UltrasoundParametersAndTheNonstressTestTableViewCell>(0);
				}
				var TestNameLabel = cell.ViewWithTag (3200) as UILabel;
				var TestDescriptionLabel = cell.ViewWithTag (3300) as UILabel;
			TestNameLabel.Text = testList[indexPath.Row];
			TestDescriptionLabel.Text = testDescription[indexPath.Row];
			//TestNameLabel.BackgroundColor = UIColor.White;
			//TestDescriptionLabel.BackgroundColor = UIColor.White;
			//cell.BackgroundColor = UIColor.Black;
			//cell.BackgroundColor = UIColor.Purple;
//			if (indexPath.Row == 0) {
//				cell.BackgroundColor = UIColor.Red;
//			}
//			if (indexPath.Row == 1) {
//				cell.BackgroundColor = UIColor.Blue;
//			}
//			if (indexPath.Row == 2) {
//				cell.BackgroundColor = UIColor.Green;
//			}
//			if (indexPath.Row == 3) {
//				cell.BackgroundColor = UIColor.Gray;
//			}
//			if (indexPath.Row == 4) {
//				cell.BackgroundColor = UIColor.Purple;
//			}
			//}
		

//			if (indexPath.Row == 0) {
//				cell.BackgroundColor = UIColor.Red;
//			} 
//			UITableViewCell cell = null;
//
//			cell = tableView.DequeueReusableCell (kCellIdentifier);
//			if (cell == null)
//			{
//				//var views = NSBundle.MainBundle.LoadNib("FifthTableViewCell", cell, null);
//				//cell = views.GetItem<FifthTableViewCell>(0);
//				cell = new UITableViewCell();
//			}
//			cell.BackgroundColor = UIColor.Red;
			return cell;
		}

	}
}

