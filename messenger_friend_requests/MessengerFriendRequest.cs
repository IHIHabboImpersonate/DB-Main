using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IHI.Database
{
    public class MessengerFriendRequest
    {
        private int fFriendRequestID;
        public virtual int friend_request_id
        {
            get { return this.fFriendRequestID; }
            set
            {
                this.fFriendRequestID = value;
            }
        }

        private int fHabboFromID;
        public virtual int habbo_from_id
        {
            get { return this.fHabboFromID; }
            set
            {
                this.fHabboFromID = value;
            }
        }

        private int fHabboToID;
        public virtual int habbo_to_id
        {
            get { return this.fHabboToID; }
            set
            {
                this.fHabboToID = value;
            }
        }
    }

}
