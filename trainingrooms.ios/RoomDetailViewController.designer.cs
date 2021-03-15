// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace trainingrooms.ios
{
	[Register ("RoomDetailViewController")]
	partial class RoomDetailViewController
	{
		[Outlet]
		UIKit.UILabel txtLocation { get; set; }

		[Outlet]
		UIKit.UILabel txtRoomName { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (txtRoomName != null) {
				txtRoomName.Dispose ();
				txtRoomName = null;
			}

			if (txtLocation != null) {
				txtLocation.Dispose ();
				txtLocation = null;
			}
		}
	}
}
