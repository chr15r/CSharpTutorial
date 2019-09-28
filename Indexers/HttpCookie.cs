using System;
using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        private Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
            Expiry = DateTime.Now.AddMinutes(10);
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

    }
}
