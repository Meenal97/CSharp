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
    }
}
