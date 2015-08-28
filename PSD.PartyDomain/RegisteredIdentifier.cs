using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSD.DomainFramework.Base;

namespace PSD.PartyDomain
{
    public class RegisteredIdentifier : ValueObject<RegisteredIdentifier>
    {

        public RegisteredIdentifier(string identifier, string identifierType, string issuedBy, DateTime? validFrom, DateTime? validTo)
            : this(identifier, identifierType, issuedBy, validFrom)
        {
            // Cannot set To Date if not from date is specified
            if(!validFrom.HasValue)
                throw new ArgumentNullException("validFrom");

            ValidTo = validTo;
        }

        public RegisteredIdentifier(string identifier, string identifierType, string issuedBy, DateTime? validFrom) : this(identifier, identifierType, issuedBy)
        {
            ValidFrom = validFrom;
        }


        public RegisteredIdentifier(string identifier, string identifierType, string issuedBy)
        {
            if(String.IsNullOrEmpty(identifier))
                throw new ArgumentNullException("identifier");

            if (String.IsNullOrEmpty(identifierType))
                throw new ArgumentNullException("identifierType");

            if(String.IsNullOrEmpty(issuedBy))
                throw  new ArgumentNullException("issuedBy");

            Identifier = identifier;
            IdentifierType = identifierType;
            IssuedBy = issuedBy;

        }

        public string Identifier { get; private set; }
        public string IssuedBy { get; private set; }
        public string IdentifierType { get; private set; }

        public DateTime? ValidFrom { get; private set; }

        public DateTime? ValidTo { get; private set; }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            return new object[] { Identifier, IdentifierType, IssuedBy};
        }
    }
}
