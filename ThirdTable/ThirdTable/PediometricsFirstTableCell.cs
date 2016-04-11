using System;

using Foundation;
using UIKit;

namespace ThirdTable
{
	public partial class PediometricsFirstTableCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("PediometricsFirstTableCell");
		public static readonly UINib Nib;

		static PediometricsFirstTableCell ()
		{
			Nib = UINib.FromName ("PediometricsFirstTableCell", NSBundle.MainBundle);
		}

		public PediometricsFirstTableCell (IntPtr handle) : base (handle)
		{
		}
	}
}
