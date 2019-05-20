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
    public class VerifikovanjeKorisnickihPodatakaJSON
    {
        [Test]
        [TestCase(null, "456")]
        [TestCase("pera", null)]
        [TestCase(null, null)]

        public void VerifikovanjeKorisnickihPodatakaJSON_NullArguments_ThrowsException(string username, string lozinka)
        {
            Assert.Throws<ArgumentNullException>(() =>

            {
                AuthenticationInterfaceJSON vj = new AuthenticationInterfaceJSON();
                vj.VerifikovanjeKorisnickihPodatakaJSON(username, lozinka);
            }
            );
        }
        
    }
}
