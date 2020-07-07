using System;
using System.Collections.Generic;
using System.Text;

namespace Name
{
    public struct Structure
    {
        private int _id;
        private string _name;

        public int ID
        {
            get { return _id; }
            set { this._id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Structure(int Id, string Name)
        {
            this._id = Id;
            this._name = Name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("ID, Name = {0} {1} ", this._id, this._name);
        }
    }
}
