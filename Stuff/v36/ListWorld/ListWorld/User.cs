using System;
using System.Collections.Generic;
using System.Text;

namespace ListWorld
{
    public class User
    {
        private string name;
        private short age;
        private bool alive;

        public User()
        {

        }
        public User(string name, short age, bool alive)
        {
            this.name = name;
            this.age = age;
            this.alive = alive;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public short Age
        {
            get { return age; }
            set { age = value; }
        }

        public bool Alive
        {
            get { return alive; }
            set { alive = value; }
        }
    }

}
