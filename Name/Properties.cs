using System;
using System.Collections.Generic;
using System.Text;

namespace Name
{   
    class Properties
    {
        private int _id;
        private string _name;
        private int pass_marks = 35;

        public void SetID(int id)
        {
            if(id <= 0)
            {
                throw new Exception("ID cannot be negative");
            }
            this._id = id;
        }


        public int GetID()
        {
            return _id;
        }


        public void SetName(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be null");
            }
            this._name = name;
        }

        public string GetName()
        {
            if(string.IsNullOrEmpty(this._name))
            {
                return "No Name";
            }
            else
            {
                return this._name;
            }
        }

    }
}
