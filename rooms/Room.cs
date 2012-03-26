using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IHI.Database
{
    public class Room
    {
        public virtual int room_id
        {
            get;
            set;
        }
        public virtual int owner_id
        {
            get;
            set;
        }
        public virtual string name
        {
            get;
            set;
        }
        public virtual string description
        {
            get;
            set;
        }
        public virtual string category_id
        {
            get;
            set;
        }
    }
}
