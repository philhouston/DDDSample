using System.Collections.Generic;
using PSD.DomainFramework.Base;

namespace PSD.DomainFramework.ValueTypes.HourBased
{
    public class ContractedHours : ValueObject<ContractedHours>
    {
        public readonly Hours Hours;

        public ContractedHours(Hours hours)
        {
            this.Hours = hours;
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            return new object[] { Hours };
        }
    }
}
