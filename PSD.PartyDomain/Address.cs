using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSD.DomainFramework.Base;

namespace PSD.PartyDomain
{
    public abstract class Address : ValueObject<Address>
    {
        protected Address(string purpose)
        {
            if(String.IsNullOrEmpty(purpose))
                throw new ArgumentNullException("purpose");

            Purpose = purpose;
        }

        public string Purpose { get; private set; }
        public abstract string Description { get; }

    }
}
