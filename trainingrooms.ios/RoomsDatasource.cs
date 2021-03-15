using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using TrainingRoom.Models;
using UIKit;

namespace trainingrooms.ios
{
    public class RoomsDatasource : UITableViewSource
    {
        private List<Room> _rooms;

        public RoomsDatasource(List<Room> rooms)
        {
            _rooms = rooms;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("roomCell");
            var room = _rooms[indexPath.Row];

            cell.TextLabel.Text = room.Name;
            cell.DetailTextLabel.Text = room.Location;
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return _rooms.Count();
        }

        public Room GetItem(int row)
        {
            return _rooms[row];
        }
    }
}
