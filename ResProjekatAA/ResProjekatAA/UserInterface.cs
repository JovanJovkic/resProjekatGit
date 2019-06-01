using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfejsi;
using FederatedIdentityProjekat;
using CQRSProjekatJSON;
using CQRSProjekatDB;
using AuthenticationDB;
using AuthenticationJSON;

namespace ResProjekatAA
{
    public class UserInterface : IUserInterface
    {
        IFederatedIdentityInterface ifederated = new FederatedIdentityInterface();

        private bool autentifikovan=false;

        public UserInterface()
        {
            ICQRSInterfaceJSON icqrsjson = new CQRSInterfaceJSON();
            ICQRSInterfaceDB icqrsdb = new CQRSInterfaceDB();

            IAuthenticationInterfacesJSON iajson = new AuthenticationInterfaceJSON(icqrsjson);
            IAuthenticationInterfaceDB iadb = new AuthenticationInterfaceDB(icqrsdb);

            IFederatedIdentityInterface ifii = new FederatedIdentityInterface(iajson, iadb);

            ifederated = ifii;
        }

        string sistrem;
        string akcija;

        public void OdaberiSistemZaPrijavu()
        {
            do
            {
                PrikaziSistemeZaPrijavu();
                sistrem = Console.ReadLine();
                sistrem = sistrem.ToLower();
            } while (sistrem != "1" && sistrem != "2");
        }

        public void PrijaviSe()
        {
            do
            {
                OdaberiSistemZaPrijavu();
                Console.WriteLine("Unesite username: ");
                Console.Write(">>");
                string username = Console.ReadLine();
               
                Console.WriteLine("Unesite lozinku: ");
                Console.Write(">>");
                string lozinka = "";

                lozinka = UnosLozinke();

                Console.WriteLine();
                Console.WriteLine("The Password You entered is : " + lozinka);

                autentifikovan = ifederated.LogovanjeZahteva(username, lozinka, sistrem);

                if (autentifikovan)
                {
                    Console.WriteLine("*** Uspesno ste se ulogovali");
                    break;
                }
                else
                {
                    Console.WriteLine("*** Niste uneli tacne podatke");
                }

            } while (true);

            do {
                string akcija = IzaberiAkciju();
                IzvrsiAkciju(akcija);

                if(akcija=="3")
                {
                    break;
                }

            } while (true);



            Console.ReadLine();
        }

        public void IzvrsiAkciju(string akcija)
        {
            if(akcija=="2")
            {
                Console.WriteLine("Unesite username: ");
                Console.Write(">>");
                string username = Console.ReadLine();

                Console.WriteLine("Unesite lozinku: ");
                Console.Write(">>");
                string lozinka = "";

                lozinka = UnosLozinke();

                ifederated.SacuvajPodatke(username,lozinka);
            }
            else if(akcija=="1")
            {
                Console.WriteLine("Unesite username: ");
                Console.Write(">>");
                string username = Console.ReadLine();
                Interfejsi.User u=ifederated.PronadjiKorisnika(username);
                IspisiRezultatPretrageKorisnika(u);
            }
        }

        public void IspisiRezultatPretrageKorisnika(Interfejsi.User u)
        {
            if(u==null)
            {
                Console.WriteLine("Nije pronadjen korisnik sa datim username-om!");
                return;
            }

            Console.WriteLine("Rezultat pretrage: ");
            Console.WriteLine("\r\tUsername: {0}",u.Username);
            Console.WriteLine("\r\tLozinka: {0}", u.Lozinka);
            Console.WriteLine("\r\tRola: {0}", u.Rola);
        }

        public string IzaberiAkciju()
        {
            do
            {
                PrikaziAkcije();
                akcija = Console.ReadLine();
            } while (akcija != "1" && akcija != "2" && akcija != "3");

            return akcija;
        }

        public void PrikaziAkcije()
        {
            Console.WriteLine("Izaberite akciju: ");
            Console.WriteLine("\r\t1. Pronadji korisnika ");  //metoda za pronalazenje
            Console.WriteLine("\r\t2. Dodaj korisnika ");  //metoda za dodavanje 
            Console.WriteLine("\r\t3. Odjavi se ");  //metoda za dodavanje 
            Console.Write(">>");
        }

        public void PrikaziSistemeZaPrijavu()
        {
            Console.WriteLine("Izaberite sistem za prijavu:");
            Console.WriteLine("\r\t1. JSON");
            Console.WriteLine("\r\t2. DB");
            Console.Write(">>");
        }

        public string UnosLozinke()
        {
            string lozinka = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);
                // Backspace Should Not Work
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    lozinka += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && lozinka.Length > 0)
                    {
                        lozinka = lozinka.Substring(0, (lozinka.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            } while (true);

            return lozinka;
        }
    }
}
