using FederatedIdentityProjekat;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FederatedIdentityProjekatTEST
{
    [TestFixture]
    public class LogovanjeZahteva
    {
        [Test]
        [TestCase("pera", "123", null)]
        [TestCase("pera", null, "db")]
        [TestCase("pera", "123", null)]
        [TestCase(null, null, null)]
        public void LogovanjeZahteva_NullArguments_ThrowsException(string username, string lozinka, string sistem)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                FederatedIdentityInterface fi = new FederatedIdentityInterface();
                fi.LogovanjeZahteva(username, lozinka, sistem);
            }
            );
        }

        [Test]
        [TestCase("pera", "123 ", "abc")]
        [TestCase("pera", "123", "")]
        [TestCase("pera", "123", "DBjson")]
        [TestCase("pera", "123", "jsoon")]
        [TestCase("pera", "123", "dbbb")]
        [TestCase("pera", "123", "hhh")]
        [TestCase("pera", "12", "123")]

        public void LogovanjeZahteva_LosOdabirSistema_ThrowsException(string username, string lozinka, string sistem)
        {
            Assert.Throws<Exception>(() =>

            {
                FederatedIdentityInterface fii = new FederatedIdentityInterface();
                fii.LogovanjeZahteva(username, lozinka, sistem);
            }
            );
        }

    }
}
