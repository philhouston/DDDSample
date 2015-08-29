using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSD.DomainFramework.Base;
using PSD.PartyDomain.Formatters;

namespace PSD.PartyDomain
{
    public class PersonName : ValueObject<PersonName>
    {
        public PersonName(string firstname, string lastname)
        {
            if (String.IsNullOrEmpty(firstname))
                throw new ArgumentNullException("firstname");

            if(String.IsNullOrEmpty(lastname))
                throw new ArgumentNullException("lastname");

            FirstName = firstname;
            LastName = lastname;
        }

        public PersonName(string firstname, string lastname, string middlename) : this(firstname, lastname)
        {
            MiddleName = middlename;
        }

        public PersonName(string firstname, string lastname, string middlename, string knownas)
            : this(firstname, lastname, middlename)
        {
            KnownAs = knownas;
        }

        public PersonName(string firstname, string lastname, string middlename, string prefix, string suffix) : this(firstname, lastname, middlename)
        {
            Prefix = prefix;
            Suffix = suffix;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string MiddleName { get; private set; }

        public string KnownAs { get; private set; }

        public string Prefix { get; private set; }

        public string Suffix { get; private set; }


        public IPersonNameFormatter NameFormatter { private get; set; }

        public override string ToString()
        {
            IPersonNameFormatter formatter = new DefaultPersonNameFormatter();

            if (NameFormatter != null)
                formatter = NameFormatter;

            return formatter.Format(this);
        }
        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            return new object[] { FirstName, LastName, MiddleName, KnownAs, Prefix, Suffix };
        }
    }
}
