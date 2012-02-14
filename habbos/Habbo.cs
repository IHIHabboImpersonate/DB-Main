using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IHI.Database
{
    public class Habbo
    {
        public virtual int habbo_id
        {
            get;
            set;
        }
        public virtual int login_id
        {
            get;
            set;
        }
        public virtual string username
        {
            get;
            set;
        }
        public virtual DateTimeOffset creation_date
        {
            get;
            set;
        }
        public virtual string figure
        {
            get;
            set;
        }
        public virtual int swim_figure
        {
            get;
            set;
        }
        public virtual bool gender
        {
            get;
            set;
        }
        public virtual string motto
        {
            get;
            set;
        }
        public virtual int credits
        {
            get;
            set;
        }
        public virtual int pixels
        {
            get;
            set;
        }
        public virtual DateTimeOffset? last_access
        {
            get;
            set;
        }
        public virtual string sso_ticket
        {
            get;
            set;
        }
        public virtual int? origin_ip
        {
            get;
            set;
        }
    }
}
