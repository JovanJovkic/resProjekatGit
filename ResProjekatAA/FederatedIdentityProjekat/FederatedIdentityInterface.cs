using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfejsi;
using AuthenticationDB;
using AuthenticationJSON;
using System.IO;

namespace FederatedIdentityProjekat
{
    public class FederatedIdentityInterface : IFederatedIdentityInterface
    {
        private IAuthenticationInterfaceDB interfaceDB;
        private IAuthenticationInterfacesJSON interfaceJSON;

        private Sistemi trenutniSistem;


        public bool file = false;
        private string path = "projekatLog.txt";

        public FederatedIdentityInterface()
        {
            
        }

        public FederatedIdentityInterface(IAuthenticationInterfacesJSON iajson, IAuthenticationInterfaceDB iadb)
        {
            interfaceJSON = iajson;
            interfaceDB = iadb;
        }

        public bool LogovanjeZahteva(string username, string lozinka, string sistem)
        {
            if(username == null || lozinka == null || sistem == null)
            {
                throw new ArgumentNullException("Vrednost ne moze biti null");
            }

            if(sistem != "1" && sistem != "2")
            {
                throw new Exception("Sistem nije dobar");
            }

            if (sistem == "1")
            {
                trenutniSistem = Sistemi.JSON;
            }
            else
            {
                trenutniSistem = Sistemi.DB;
            }

            IspisiUTekstualniFajl(username, lozinka, sistem);

            bool postoji;
            if (trenutniSistem == Sistemi.JSON)
            {
                postoji = interfaceJSON.VerifikovanjeKorisnickihPodatakaJSON(username, lozinka);
            }
            else
            {
                postoji = interfaceDB.VerifikovanjeKorisnickihPodatakaDB(username, lozinka,"admin");
            }

            if(postoji)
            {
                return true;
            }

            return false;
            
        }

        public void IspisiUTekstualniFajl(string username, string lozinka, string sistem)
        {
            if (!File.Exists(path))
            {
                StreamWriter writer;
                using(writer = new StreamWriter(path))
                {
                    writer.WriteLine(DateTime.Now.ToString() + " " + username + " " + lozinka + " " + sistem);
                }
            }
            else
            {
                StreamWriter writer;
                using(writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(DateTime.Now.ToString() + " " + username + " " + lozinka + " " + sistem);
                }
            }

            file = true;
        }

        public void SacuvajPodatke(string username,string lozinka)
        {
            if(trenutniSistem==Sistemi.JSON)
            {
                interfaceJSON.cuvajPodatkeJSON(username, lozinka);
            }

            interfaceDB.cuvajPodatkeDB(username, lozinka,"korisnik");
        }

        
        public User PronadjiKorisnika(string username)
        {
            if (trenutniSistem == Sistemi.JSON)
            {
                return interfaceJSON.PronadjiKorisnika(username);
            }

            

            return interfaceDB.PronadjiKorisnika(username);
        }
        
    }
}
