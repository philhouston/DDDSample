using System.Collections.Generic;
using PSD.DomainFramework.Base;

namespace PSD.DomainFramework.ValueTypes.HourBased
{
    public class HoursWorked : ValueObject<HoursWorked>
    {
        public readonly Hours Hours;

        public HoursWorked(Hours hours)
        {
            this.Hours = hours;
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            return new object[] { Hours };
        }
    }
}
