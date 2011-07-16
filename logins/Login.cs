using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IHI.Database
{
    public class Login
    {
        private int fLoginID;
        public virtual int login_id
        {
            get { return this.fLoginID; }
            set
            {
                this.fLoginID = value;
            }
        }
        private string fEmail;
        public virtual string email
        {
            get { return this.fEmail; }
            set
            {
                this.fEmail = value;
            }
        }
        private string fPassword;
        public virtual string password
        {
            get { return this.fPassword; }
            set
            {
                this.fPassword = value;
            }
        }
        private DateTimeOffset fDateOfBirth;
        public virtual DateTimeOffset date_of_birth
        {
            get { return this.fDateOfBirth; }
            set
            {
                this.fDateOfBirth = value;
            }
        }
        private DateTimeOffset fDateCreated;
        public virtual DateTimeOffset date_created
        {
            get { return this.fDateCreated; }
            set
            {
                this.fDateCreated = value;
            }
        }
    }
}
