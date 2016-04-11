using System;

using Foundation;
using UIKit;

namespace ThirdTable
{
	public partial class FourthCustomCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("FourthCustomCell");
		public static readonly UINib Nib;

		static FourthCustomCell ()
		{
			Nib = UINib.FromName ("FourthCustomCell", NSBundle.MainBundle);
		}

		public FourthCustomCell (IntPtr handle) : base (handle)
		{
		}
	}
}
