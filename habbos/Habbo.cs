using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IHI.Database
{
    public class Habbo
    {
        private int fHabboID;
        public virtual int habbo_id
        {
            get { return this.fHabboID; }
            set
            {
                this.fHabboID = value;
            }
        }
        private int fLoginID;
        public virtual int login_id
        {
            get { return this.fLoginID; }
            set
            {
                this.fLoginID = value;
            }
        }
        private string fUsername;
        public virtual string username
        {
            get { return this.fUsername; }
            set
            {
                this.fUsername = value;
            }
        }
        private DateTimeOffset fCreationDate;
        public virtual DateTimeOffset creation_date
        {
            get { return this.fCreationDate; }
            set
            {
                this.fCreationDate = value;
            }
        }
        private string fFigure;
        public virtual string figure
        {
            get { return this.fFigure; }
            set
            {
                this.fFigure = value;
            }
        }
        private int fSwimFigure;
        public virtual int swim_figure
        {
            get { return this.fSwimFigure; }
            set
            {
                this.fSwimFigure = value;
            }
        }
        private bool fGender;
        public virtual bool gender
        {
            get { return this.fGender; }
            set
            {
                this.fGender = value;
            }
        }
        private string fMotto;
        public virtual string motto
        {
            get { return this.fMotto; }
            set
            {
                this.fMotto = value;
            }
        }
        private int fCredits;
        public virtual int credits
        {
            get { return this.fCredits; }
            set
            {
                this.fCredits = value;
            }
        }
        private int fPixels;
        public virtual int pixels
        {
            get { return this.fPixels; }
            set
            {
                this.fPixels = value;
            }
        }
        private DateTimeOffset? fLastAccess;
        public virtual DateTimeOffset? last_access
        {
            get { return this.fLastAccess; }
            set
            {
                this.fLastAccess = value;
            }
        }
        private string fSSOTicket;
        public virtual string sso_ticket
        {
            get { return this.fSSOTicket; }
            set
            {
                this.fSSOTicket = value;
            }
        }
        private int? fOriginIP;
        public virtual int? origin_ip
        {
            get { return this.fOriginIP; }
            set
            {
                this.fOriginIP = value;
            }
        }
    }
}
