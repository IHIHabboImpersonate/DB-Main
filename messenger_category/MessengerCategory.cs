using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IHI.Database
{
    public class MessengerCategory
    {
        private int fCategoryID;
        public virtual int category_id
        {
            get { return this.fCategoryID; }
            set
            {
                this.fCategoryID = value;
            }
        }
        private int fHabboID;
        public virtual int habbo_id
        {
            get { return this.fHabboID; }
            set
            {
                this.fHabboID = value;
            }
        }
        private string fName;
        public virtual string name
        {
            get { return this.fName; }
            set
            {
                this.fName = value;
            }
        }
    }
}
