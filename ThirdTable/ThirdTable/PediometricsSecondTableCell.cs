using System;

using Foundation;
using UIKit;

namespace ThirdTable
{
	public partial class PediometricsSecondTableCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("PediometricsSecondTableCell");
		public static readonly UINib Nib;

		static PediometricsSecondTableCell ()
		{
			Nib = UINib.FromName ("PediometricsSecondTableCell", NSBundle.MainBundle);
		}

		public PediometricsSecondTableCell (IntPtr handle) : base (handle)
		{
		}
	}
}
