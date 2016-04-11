using System;

using Foundation;
using UIKit;

namespace ThirdTable
{
	public partial class SixthTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("SixthTableViewCell");
		public static readonly UINib Nib;

		static SixthTableViewCell ()
		{
			Nib = UINib.FromName ("SixthTableViewCell", NSBundle.MainBundle);
		}

		public SixthTableViewCell (IntPtr handle) : base (handle)
		{
		}
	}
}
