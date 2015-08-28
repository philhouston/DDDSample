using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSD.PartyDomain.Formatters
{
    public class DefaultPersonNameFormatter : IPersonNameFormatter
    {
        public string Format(PersonName name)
        {
            var builder = new StringBuilder();

            builder.Append(!String.IsNullOrEmpty(name.KnownAs) ? name.KnownAs : name.FirstName);
            builder.Append(" ");
            builder.Append(name.LastName);

            return builder.ToString();
        }
    }
}
