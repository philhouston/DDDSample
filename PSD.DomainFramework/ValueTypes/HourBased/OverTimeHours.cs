using System.Collections.Generic;
using PSD.DomainFramework.Base;

namespace PSD.DomainFramework.ValueTypes.HourBased
{
    public class OvertimeHours : ValueObject<OvertimeHours>
    {
        public readonly Hours Hours;

        public OvertimeHours(Hours hours)
        {
            this.Hours = hours;
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            return new object[] { Hours };
        }
    }
}
