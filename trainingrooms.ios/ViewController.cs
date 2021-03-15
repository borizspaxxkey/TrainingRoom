﻿using Foundation;
using System;
using TrainingRoom.Repository;
using UIKit;

namespace trainingrooms.ios
{
    public partial class ViewController : UITableViewController
    {
        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.
            var repo = new RoomRepository();
            var rooms = repo.GetRooms();

            var source = new RoomsDatasource(rooms);
            this.TableView.Source = source;
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            RoomsDatasource source = this.TableView.Source as RoomsDatasource;
            var room = source.GetItem(this.TableView.IndexPathForSelectedRow.Row);

            if (segue.Identifier == "detailSegue")
            {
                var target = segue.DestinationViewController as RoomDetailViewController;
                target.SetTrainingRoom(room);
            }
        }
    }
}