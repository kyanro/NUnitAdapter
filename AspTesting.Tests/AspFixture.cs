using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using NUnit.Framework;

namespace AspTesting.Tests
{
    public abstract class AspFixture
    {
        //private const string BASE_URI = "http://localhost:990/UnitTests/ASPTesting.Tests/";
        private const string BASE_URI = "http://localhost:33211/";

        public void RunAspTest(string uri)
        {
            var request = WebRequest.Create(BASE_URI + uri);

            ICredentials requestCredentials = CredentialCache.DefaultCredentials;
            request.Credentials = requestCredentials;

            using (var response = request.GetResponse())
            {
                using (var stream = new StreamReader(response.GetResponseStream()))
                {
                    string html = stream.ReadToEnd();

                    Assert.IsFalse(html.Contains("Failed"));
                }
            }
        }
    }
}
