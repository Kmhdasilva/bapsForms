using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bapsforms
{
    class Device
    {
        private int _id;
        private string _name;
        private string _roomName;

        public Device(int id, string name, string roomName)
        {
            this._id = id;
            this._name = name;
            this._roomName = roomName;
        }

    }
}
