using System;

using Foundation;
using UIKit;

namespace ThirdTable
{
	public partial class FifthTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("FifthTableViewCell");
		public static readonly UINib Nib;

		static FifthTableViewCell ()
		{
			Nib = UINib.FromName ("FifthTableViewCell", NSBundle.MainBundle);
		}

		public FifthTableViewCell (IntPtr handle) : base (handle)
		{
			
		}
	}
}
