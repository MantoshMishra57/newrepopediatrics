using System;
using UIKit;
using System.Collections.Generic;
using Foundation;


namespace ThirdTable
{
	public class TableViewDelegate : UITableViewDelegate
	{
		private List<string> list;
		private ViewController theViewController;
	   
		public TableViewDelegate(List<string> list)
		{
			this.list = list;
			//theViewController = UIControl;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			Console.WriteLine("RowSelected");
		//	viewController.NavigateToOtherView ();
		//	theViewController.NavigateToOtherView ();
			var	descriptionViewController = Storyboard.InstantiateViewController ("DescriptionCntrl") as DescriptionController;
			this.NavigationController.PushViewController (descriptionViewController,true);
		}

		public override nfloat GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			//var someHeight = CalcHeightSomehow(indexPath.row);
			return 134;
		}


	}
}

