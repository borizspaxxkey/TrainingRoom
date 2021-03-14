using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrainingRoom.Models;

namespace TrainingRoom.Repository
{
    public class RoomRepository
    {
        private List<Room> _rooms = new List<Room>
        {
            new Room{Id=1,Name="Copernicus", Location="Building 1", NumberComputers=25},
            new Room{Id=2,Name="Sagittarius", Location="Building 7", NumberComputers=25},
            new Room{Id=3,Name="Luna", Location="Building 3", NumberComputers=50}
        };

        public RoomRepository()
        {

        }

        public List<Room> GetRooms()
        {
            return _rooms;
        }

        public Room GetRoom(int id)
        {
            return _rooms.Where(room => room.Id == id)
                         .FirstOrDefault();
        }
    }
}
