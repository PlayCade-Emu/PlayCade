﻿// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace PlayCade.iOS
{
	public partial class AddFolderViewController : UITableViewController
	{
		public AddFolderViewController(IntPtr handle) : base(handle)
		{
		}

		partial void CancelButton(UIBarButtonItem sender)
		{
			DismissViewController(true, null);
		}

		partial void SaveButton(UIBarButtonItem sender)
		{
			//TODO: Implement Save Button once backend storage is done
			DismissViewController(true, null);
		}
	}
}
