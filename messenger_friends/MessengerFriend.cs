using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IHI.Database
{
    public class MessengerFriend
    {
        private int fFriendID;
        public virtual int friend_id
        {
            get { return this.fFriendID; }
            set
            {
                this.fFriendID = value;
            }
        }
        private int fHabboAID;
        public virtual int habbo_a_id
        {
            get { return this.fHabboAID; }
            set
            {
                this.fHabboAID = value;
            }
        }
        private int fHabboBID;
        public virtual int habbo_b_id
        {
            get { return this.fHabboBID; }
            set
            {
                this.fHabboBID = value;
            }
        }

        private int fCategoryAID;
        public virtual int category_a_id
        {
            get { return this.fCategoryAID; }
            set
            {
                this.fCategoryAID = value;
            }
        }
        private int fCategoryBID;
        public virtual int category_b_id
        {
            get { return this.fCategoryBID; }
            set
            {
                this.fCategoryBID = value;
            }
        }

    }
}
