using System;
using System.Collections.Generic;
using PSD.DomainFramework.Base;
using PSD.DomainFramework.Exceptions;

namespace PSD.DomainFramework.ValueTypes
{
    public class Money : ValueObject<Money>
    {
        protected readonly decimal Value;
        public Money()
            : this(0m)
        {
        }

        public Money(decimal value)
        {
            Validate(value);

            Value = value;
        }

        private void Validate(decimal value)
        {
            if (value % 0.01m != 0)
                throw new MoreThanTwoDecimalPlacesInMoneyValueException();

            if (value < 0)
                throw new MoneyCannotBeANegativeValueException();
        }

        public Money Add(Money money)
        {
            return new Money(Value + money.Value);
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            return new List<Object>() { Value };
        }


        public static Money Create(int amount)
        {
            if (amount % 0.01m != 0)
                throw new MoreThanTwoDecimalPlacesInMoneyValueException();

            if (amount < 0)
                throw new MoneyCannotBeANegativeValueException();

            return new Money(amount);
        }
    }
}
   
