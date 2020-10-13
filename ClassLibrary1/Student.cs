using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35; // read-only
        // private string _city;
        // private string _email;

        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("id cannot be negative");
                }

                _id = value;
            }
            get
            {
                return _id;
            }
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception();
                }

                _name = value;
            }

            get
            {
                return _name;
            }
        }
        public int PassMark
        {
            get
            {
                return _passMark;
            }
        }

        public string City { set; get; }

        public string Email { set; get; }

        // Legacy code
        public void SetId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("id cannot be negative");
            }

            _id = id;
        }

        public int GetId() => _id;

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception();
            }

            _name = name;
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(_name) ? "no name" : _name;

            //if (string.IsNullOrEmpty(_name))
            //    return "no name";

            //return _name;
        }

        public int GetPassMark() => _passMark;
    }

}
