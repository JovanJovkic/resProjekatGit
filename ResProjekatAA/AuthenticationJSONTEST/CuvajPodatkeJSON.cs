using AuthenticationJSON;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationJSONTEST
{
    [TestFixture]
    public class CuvajPodatkeJSON
    {
        [Test]
        [TestCase(null, "1234")]
        [TestCase("pera", null)]
        [TestCase(null, null)]

        public void CuvajPodatkeJSON_NullArguments_ThrowsException(string username, string lozinka)
        {
            Assert.Throws<ArgumentNullException>(() =>

            {
                AuthenticationInterfaceJSON aj = new AuthenticationInterfaceJSON();
                aj.cuvajPodatkeJSON(username, lozinka);
            }
            );
        }
    }
}
