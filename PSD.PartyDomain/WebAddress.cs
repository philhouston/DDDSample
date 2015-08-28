using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace PSD.PartyDomain
{
    public class WebAddress : Address
    {
        public WebAddress(string url, string purpose) : base(purpose)
        {
            if(!Validate(url))
                throw new FormatException("url");

            Url = url;
        }

        private bool Validate(string url)
        {
            if (String.IsNullOrEmpty(url))
                throw new ArgumentNullException("url");

            return Uri.IsWellFormedUriString(url, UriKind.Absolute);
        }

        public bool UrlReachable()
        {
            Uri uri = new Uri(Url);
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(uri);
            request.Timeout = 1000;
            request.Method = "HEAD";

            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                return response.StatusCode == HttpStatusCode.OK;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string Url { get; private set; }

        public override string Description
        {
            get { return Url; }
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            return new object[] { Url, Purpose};
        }
    }
}
