using System;

using Foundation;
using UIKit;
using CoreGraphics;

namespace ThirdTable
{
	public partial class ThirdCustomCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("ThirdCustomCell");
		public static readonly UINib Nib;

		static ThirdCustomCell ()
		{
			Nib = UINib.FromName ("ThirdCustomCell", NSBundle.MainBundle);
		}

		public ThirdCustomCell (IntPtr handle) : base (handle)
		{
		}
	}
}
