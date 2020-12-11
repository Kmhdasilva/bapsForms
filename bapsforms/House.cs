using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bapsforms
{
    class House
    {
        private string _name;
        private int _id;
        private int _rooms;
        public House(int id, string name, int rooms)
        {
            this._id = id;
            this._name = name;
            this._rooms = rooms;
        }
    }
}
