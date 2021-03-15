﻿using System;
using TrainingRoom.Models;
using UIKit;

namespace trainingrooms.ios
{
    public partial class RoomDetailViewController : UIViewController
    {
        private Room _room;

        public void SetTrainingRoom(Room room)
        {
            _room = room;
        }

        public RoomDetailViewController() : base("RoomDetailViewController", null)
        {
        }

        protected internal RoomDetailViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            txtRoomName.Text = _room.Name;
            txtLocation.Text = _room.Location;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

