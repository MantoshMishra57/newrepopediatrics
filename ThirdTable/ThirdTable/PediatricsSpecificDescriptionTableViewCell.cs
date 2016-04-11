using System;

using Foundation;
using UIKit;

namespace ThirdTable
{
	public partial class PediatricsSpecificDescriptionTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("PediatricsSpecificDescriptionTableViewCell");
		public static readonly UINib Nib;

		static PediatricsSpecificDescriptionTableViewCell ()
		{
			Nib = UINib.FromName ("PediatricsSpecificDescriptionTableViewCell", NSBundle.MainBundle);
		}

		public PediatricsSpecificDescriptionTableViewCell (IntPtr handle) : base (handle)
		{
		}
	}
}
