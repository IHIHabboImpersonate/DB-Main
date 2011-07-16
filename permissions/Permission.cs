using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IHI.Database
{
    public class Permission
    {
        private int fPermissionID;
        public virtual int permission_id
        {
            get { return this.fPermissionID; }
            set
            {
                this.fPermissionID = value;
            }
        }
        private string fPermissionName;
        public virtual string permission_name
        {
            get { return this.fPermissionName; }
            set
            {
                this.fPermissionName = value;
            }
        }
    }
}
