using System.Collections.Generic;
using PSD.DomainFramework.Base;

namespace PSD.DomainFramework.ValueTypes.HourBased
{
    public class Hours : ValueObject<Hours>
    {
        public readonly int Amount;

        public Hours(int amount)
        {
            this.Amount = amount;
        }

        public static Hours operator -(Hours left, Hours right)
        {
            return new Hours(left.Amount - right.Amount);
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            return new object[] { Amount };
        }
    }
}
