using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrainingRoom.Models;
using TrainingRoom.Repository;
using RoomRepository = TrainingRoom.Repository.RoomRepository;

namespace trainingrooms.droid
{
    [Activity(Label = "TrainingRoomDetailActivity")]
    public class TrainingRoomDetailActivity : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.room_list_item);

            int roomId = Intent.GetIntExtra("roomId",0);
            var repo = new RoomRepository();
            var room = repo.GetRoom(roomId);

            this.Title = "Room Detail";
            this.FindViewById<TextView>(Resource.Id.txtName).Text = room.Name;
            this.FindViewById<TextView>(Resource.Id.txtLocation).Text = room.Location;
        }
    }
}