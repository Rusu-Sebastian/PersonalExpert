//acum e pe consolo schimbam cu intervatza


using System;

namespace PersonalExpert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bun venit la PersonalExpert!");

            // Autentificare utilizator
            bool autentificat = Autentificare();

            if (autentificat)
            {
                MeniuPrincipal();
            }
            else
            {
                Console.WriteLine("Autentificarea a eșuat. Aplicația se închide.");
            }
        }

        public static bool Autentificare()
        {
            console.WriteLine("Aveti cont? (da/nu)");
            string raspuns1 = console.ReadLine();
            if (raspuns1.ToLower() == "da")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Doriti sa creati unul? (da/nu)");
                    string raspuns2 = Console.ReadLine();
                    if (raspuns2.ToLower() == "da")
                    {
                        CreareCont();
                    }
                    else
                    {
                        return false;
                    }
                }
            Console.WriteLine("Vă rugăm să vă autentificați.");
            Console.WriteLine("Introduceți numele de utilizator: ");
            string numeUtilizator = Console.ReadLine();
            Console.WriteLine("Introduceți parola: ");
            string parola = Console.ReadLine();
            

            bool areCont = VerificareCont(numeUtilizator, parola);

            if (areCont)
            {
                Console.WriteLine("Autentificare reușită!");
                return true;
            }
            else
            {
                Console.WriteLine("Nu aveți un cont. Doriți să creați unul nou? (da/nu)");
                string raspuns = Console.ReadLine();

                if (raspuns.ToLower() == "da")
                {
                    CreareCont();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        static bool VerificareCont(string numeUtilizator, string parola)
        {
            using streamreader sr = new streamreader("Utilizatori.txt");
            if numeUtilizator == sr.readline() && parola == sr.readline()
            {
                Console.WriteLine("Autentificare reușită!");
                return true;
            }
            else
            {
                Console.WriteLine("Autentificare eșuată. Nume de utilizator sau parolă incorecte.");
                return false;
            }
        }

        static void CreareCont()
        {
           using streamreader cn = new streamreader("Utilizatori.txt");
            Console.WriteLine("Introduceti numele dvs.: ");
            string utilizator = console.readline();
            cn.writeline(utilizator + endl);

            console.writeline("Alegeti parola: ");
            string parola = console.readline();
            cn.writeline(parola + endl);

            console.writeline("Introduceti email-ul: ");
            string email = console.readline();
            cn.writeline(email + endl);

            Console.WriteLine("Contul a fost creat cu succes!");
            return Autentificare();
        }

        static void MeniuPrincipal()
        {
            bool iesire = false;

            while (!iesire)
            {
                Console.WriteLine("Meniu principal:");
                Console.WriteLine("1. Creare profil nou");
                Console.WriteLine("2. Căutare profiluri existente");
                Console.WriteLine("3. Editare profil");
                Console.WriteLine("4. Ștergere profil");
                Console.WriteLine("5. Informații angajați și salariu mediu");
                Console.WriteLine("6. Ieșire");

                Console.Write("Introduceți opțiunea dorită: ");
                string optiune = Console.ReadLine();

                switch (optiune)
                {
                    case "1":
                        CreareProfil();
                        break;
                    case "2":
                        CautareProfiluri();
                        break;
                    case "3":
                        EditareProfil();
                        break;
                    case "4":
                        StergereProfil();
                        break;
                    case "5":
                        InformatiiAngajatiSalariuMediu();
                        break;
                    case "6":
                        iesire = true;
                        break;
                    default:
                        Console.WriteLine("Opțiune invalidă. Vă rugăm să încercați din nou.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void CreareProfil()
        {
            // cod scire
            Console.WriteLine("Profilul a fost creat cu succes!");
        }

        static void CautareProfiluri()
        {
            // cod
            Console.WriteLine("Rezultatele căutării:");
            Console.WriteLine("Profil 1");
            Console.WriteLine("Profil 2");
            Console.WriteLine("Profil 3");
        }

        static void EditareProfil()
        {
            // cod de scris
            Console.WriteLine("Profilul a fost editat cu succes!");
        }

        static void StergereProfil()
        {
            // Icod
            Console.WriteLine("Profilul a fost șters cu succes!");
        }

        static void InformatiiAngajatiSalariuMediu()
        {
            // cod
            Console.WriteLine("Numărul de angajați: 100");
            Console.WriteLine("Salariul mediu: $5000");
        }
    }
}
