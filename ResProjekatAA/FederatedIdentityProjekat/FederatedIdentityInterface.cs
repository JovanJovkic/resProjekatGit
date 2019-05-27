﻿using System;
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

            IspisiUTekstualniFajl(username, lozinka, sistem);

            if (sistem == "2")
            {
                interfaceDB.cuvajPodatkeDB(username, lozinka, sistem);
                return true;
            }
            else
            {
                bool postoji=interfaceJSON.VerifikovanjeKorisnickihPodatakaJSON(username, lozinka);
                if(postoji)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                //interfaceJSON.cuvajPodatkeJSON(username, lozinka);
            }
        }

        public void IspisiUTekstualniFajl(string username, string lozinka, string sistem)
        {
            if (!file)
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
    }
}
