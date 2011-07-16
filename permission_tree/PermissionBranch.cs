using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IHI.Database
{
    public class PermissionBranch
    {
        private int fBranchID;
        public virtual int branch_id
        {
            get { return this.fBranchID; }
            set
            {
                this.fBranchID = value;
            }
        }
        private byte fType;
        public virtual byte type
        {
            get { return this.fType; }
            set
            {
                this.fType = value;
            }
        }
        private int fValueID;
        public virtual int value_id
        {
            get { return this.fValueID; }
            set
            {
                this.fValueID = value;
            }
        }
        private int fLeft;
        public virtual int branch_left
        {
            get { return this.fLeft; }
            set
            {
                this.fLeft = value;
            }
        }
        private int fRight;
        public virtual int branch_right
        {
            get { return this.fRight; }
            set
            {
                this.fRight = value;
            }
        }
    }
}
