using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bapsforms
{
    class Room
    {
        private int _id;
        private string _name;
        private int _floor;

        public Room(int id, string name, int floor)
        {
            this._id = id;
            this._name = name;
            this._floor = floor;
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}
