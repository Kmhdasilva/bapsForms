using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bapsforms
{
    class Sensor
    {
        private int _id;
        private string _name;
        private string type;

        public Sensor(int id, string name, string type)
        {
            this._id = id;
            this._name = name;
            this.type = type;
        }
    }
}
