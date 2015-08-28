using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSD.PartyDomain.Formatters
{
    public interface IPersonNameFormatter
    {
        string Format(PersonName name );
    }
}
