using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using TrainingRoom.Models;
using TrainingRoom.Repository;
using Android.Views;
using Android.Content;

namespace trainingrooms.droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var repo = new RoomRepository();
            var rooms = repo.GetRooms();

            var adapter = new ArrayAdapter<Room>(this, Resource.Layout.room_list_item, rooms.ToArray());

            this.ListAdapter = adapter;
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            base.OnListItemClick(l, v, position, id);

            var intent = new Intent(this, typeof(TrainingRoomDetailActivity));

            var selectedItem = ((ArrayAdapter<Room>)ListAdapter).GetItem(position);
            intent.PutExtra("roomId", selectedItem.Id);

            StartActivity(intent);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}