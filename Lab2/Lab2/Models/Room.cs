using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Models
{
    class Room
    {
        public static int Id { get; set; }
        public string Name { get; set; }
        public int CapaCity { get; set; }

        static int _id = 0;


        public Room(int RoomCapCity, string RoomName)
        {
            _id++;
            Id = _id;
            Name = RoomName;
            CapaCity = RoomCapCity;
        }






    }
}
