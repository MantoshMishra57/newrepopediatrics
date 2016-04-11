using System;

using Foundation;
using UIKit;

namespace ThirdTable
{
	public partial class UltrasoundParametersAndTheNonstressTestTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("UltrasoundParametersAndTheNonstressTestTableViewCell");
		public static readonly UINib Nib;

		static UltrasoundParametersAndTheNonstressTestTableViewCell ()
		{
			Nib = UINib.FromName ("UltrasoundParametersAndTheNonstressTestTableViewCell", NSBundle.MainBundle);
		}

		public UltrasoundParametersAndTheNonstressTestTableViewCell (IntPtr handle) : base (handle)
		{
		}
	}
}
