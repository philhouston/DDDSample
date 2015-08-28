using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSD.PartyDomain.Formatters
{
    public class AlphabeticalPersonNameFormatter : IPersonNameFormatter
    {
        public string Format(PersonName name)
        {
            var builder = new StringBuilder();

            builder.Append(name.LastName);
            builder.Append(", ");
            builder.Append(!String.IsNullOrEmpty(name.KnownAs) ? name.KnownAs : name.FirstName);

            return builder.ToString();
        }
    }
}
