using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PSD.PartyDomain
{
    public class EmailAddress : Address
    {
        public EmailAddress(string email, string purpose)
            : base(purpose)
        {
            Validate(email);
            Email = email;
        }

        private bool Validate(string email)
        {
            if (String.IsNullOrEmpty(email))
                throw new ArgumentNullException("email");

            MailAddress m = new MailAddress(email);
            return true;
        }


        public string Email { get; private set; }

        public override string Description
        {
            get { return Email; }
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            return new object[] { Email, Purpose };
        }
    }
}
