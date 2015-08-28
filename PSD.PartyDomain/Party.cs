using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSD.PartyDomain
{
    public abstract class Party
    {

        protected Party(Guid partyId)
        {
            if (partyId == Guid.Empty)
                throw new ArgumentException("PartyId must be specified");

            Addresses = new List<Address>();
            Identifiers = new List<RegisteredIdentifier>();

        }

        protected Party(Guid partyId, List<Address> addresses, List<RegisteredIdentifier> identifiers  ) : this(partyId)
        {

            if (addresses == null)
                throw new ArgumentNullException("addresses");

            if(identifiers == null)
                throw new ArgumentNullException("identifiers");

            PartyId = partyId;
            Addresses = addresses;
            Identifiers = identifiers;
        }

        public Guid PartyId { get; private set; }
        public abstract string Description { get; }

        public List<Address> Addresses { get; private set; }

        public List<RegisteredIdentifier> Identifiers { get; private set; } 
    }
}
