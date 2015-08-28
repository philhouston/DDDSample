using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSD.PartyDomain
{
    public class Person :  Party
    {

        public Person(Guid partyId, PersonName name) : base(partyId)
        {

            if(name == null)
                throw new ArgumentNullException("name");

            Name = name;

        }

        public Person(Guid partyId, PersonName name, List<Address> addresses, List<RegisteredIdentifier> identifiers  )
            : base(partyId, addresses, identifiers)
        {

            if (name == null)
                throw new ArgumentNullException("name");

            Name = name;

        }


        public PersonName Name { get; private set; }

        public void ChangeName(PersonName newName)
        {
            Name = newName;
        }

        public override string Description
        {
            get { return Name.ToString(); }
        }
    }
}
