using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Dictionary
{
    class Program
    {
        static List<Linked_List> dictionary = new List<Linked_List>();
        static void Main(string[] args)
        {
            readfile();
            MainMenu();
        }
        public static void initializedictionaryfile()
        {
            Linked_List WordA = new Linked_List('A');
            dictionary.Add(WordA);
            Linked_List WordB = new Linked_List('B');
            dictionary.Add(WordB);
            Linked_List WordC = new Linked_List('C');
            dictionary.Add(WordC);
            Linked_List WordD = new Linked_List('D');
            dictionary.Add(WordD);
            Linked_List WordE = new Linked_List('E');
            dictionary.Add(WordE);
            Linked_List WordF = new Linked_List('F');
            dictionary.Add(WordF);
            Linked_List WordG = new Linked_List('G');
            dictionary.Add(WordG);
            Linked_List WordH = new Linked_List('H');
            dictionary.Add(WordH);
            Linked_List WordI = new Linked_List('I');
            dictionary.Add(WordI);
            Linked_List WordJ = new Linked_List('J');
            dictionary.Add(WordJ);
            Linked_List WordK = new Linked_List('K');
            dictionary.Add(WordK);
            Linked_List WordL = new Linked_List('L');
            dictionary.Add(WordL);
            Linked_List WordM = new Linked_List('M');
            dictionary.Add(WordM);
            Linked_List WordN = new Linked_List('N');
            dictionary.Add(WordN);
            Linked_List WordO = new Linked_List('O');
            dictionary.Add(WordO);
            Linked_List WordP = new Linked_List('P');
            dictionary.Add(WordP);
            Linked_List WordQ = new Linked_List('Q');
            dictionary.Add(WordQ);
            Linked_List WordR = new Linked_List('R');
            dictionary.Add(WordR);
            Linked_List WordS = new Linked_List('S');
            dictionary.Add(WordS);
            Linked_List WordT = new Linked_List('T');
            dictionary.Add(WordT);
            Linked_List WordU = new Linked_List('U');
            dictionary.Add(WordU);
            Linked_List WordV = new Linked_List('V');
            dictionary.Add(WordV);
            Linked_List WordW = new Linked_List('W');
            dictionary.Add(WordW);
            Linked_List WordX = new Linked_List('X');
            dictionary.Add(WordX);
            Linked_List WordY = new Linked_List('Y');
            dictionary.Add(WordY);
            Linked_List WordZ = new Linked_List('Z');
            dictionary.Add(WordZ);
        }
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" *******************************************");
            Console.WriteLine("|         WELCOME TO MY DICTIONARY          |");
            Console.WriteLine(" *******************************************");
            Console.WriteLine();
            Console.WriteLine(" ===========================================");
            Console.WriteLine("|          1) ADMIN LOGIN                   |");
            Console.WriteLine("|          2) USER LOGIN                    |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|          3) EXIT FROM MY DICTIONARY       |");
            Console.WriteLine(" ===========================================");
            Console.WriteLine();
            Console.Write(" Please Enter the number of the option you want to do : ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Write(" Please Enter the User Name: ");
                string admin = Console.ReadLine();
                Console.Write(" Please Enter the Password : ");
                string password = Console.ReadLine();
                if ((admin == "Shoaib" && password == "1510") || (admin == "Humza" && password == "pass") || (admin == "Sannia" && password == "7890"))
                {
                    Console.WriteLine("\n\t **** LOGIN COMPLETE **** \n\n Press Enter to continue");
                    Console.ReadLine();
                    AdminMenu();
                }
                else
                {
                    Console.WriteLine("\n\t  Invalid Credentials!! \n Press Enter to continue");
                    Console.ReadLine();
                    MainMenu();
                }
            }
            
            else if (choice == "2")
            {
                Console.WriteLine("\n\t  ENTERING DICTIONARY AS USER \n\n Press Enter to continue");
                Console.ReadLine();
                UserMenu();
            }
            else if (choice == "3")
            {
                Console.WriteLine("\n\t **** YOR ARE ABOUT TO EXIT FROM THE MY DICTIONARY **** \n\n Press Enter to continue");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            else if (choice == "4" || choice == "/" || choice == "]" || choice == "?" || choice == "[" || choice == "}" || choice == "{" )
            {
                Console.WriteLine("Please Enter Number Between 1 and 3\nPress Enter to Continue");
                Console.ReadLine();
                MainMenu();
            }
            else
            {
                Console.WriteLine("\n  Invalid Input!! \n\n Press Enter to continue");
                Console.ReadLine();
                MainMenu();
            }
        }
        public static void AdminMenu()
        {
            writeonfile();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" *******************************************");
            Console.WriteLine("|           WELCOME TO ADMIN MENU           |");
            Console.WriteLine(" *******************************************");
            Console.WriteLine();
            Console.WriteLine(" ===========================================");
            Console.WriteLine("|           1) ADD A WORD                   |");
            Console.WriteLine("|           2) UPDATE A WORD                |");
            Console.WriteLine("|           3) DELETE A WORD                |");
            Console.WriteLine("|           4) SEARCH FOR A WORD            |");
            Console.WriteLine("|           5) PRINT MY DICTIONARY          |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|           6) LOGOUT                       |");
            Console.WriteLine(" ===========================================");
            Console.WriteLine();
            Console.Write("  Enter the number of the option you want to do : ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine(" Please Enter the First Letter of Word Capital!!");
                Console.WriteLine();
                Console.Write(" Please Enter the word : ");
                string word = Console.ReadLine();
                char ww = char.ToUpper(word[0]);
                Console.Write("\n Please Enter the partofspeech : ");
                string partofspeech = Console.ReadLine();
                Console.Write("\n Please Enter the meaning : ");
                string meaning = Console.ReadLine();
                string abc = Console.ReadLine();               
                    foreach (var item in dictionary)
                    {
                        if (item.word == ww)
                        {
                            item.InsertFront(word, partofspeech, meaning);
                            break;
                        }
                    }

                Console.WriteLine("\n\t **** The Word is Added to MY DICTIONARY ****");
                Console.WriteLine("\n\n Press Enter to continue");
                Console.ReadLine();
                AdminMenu();
            }
            else if (choice == "2")
            {
                Console.WriteLine(" Please Enter the First Letter of Word Capital!!");
                Console.WriteLine();
                Console.Write(" Please Enter the word : ");
                string word = Console.ReadLine();
                char ww = char.ToUpper(word[0]);
                foreach (var item in dictionary)
                {
                    if (item.word == ww)
                    {
                        item.Searchandupdate(word);
                        break;
                    }
                }
                
                Console.WriteLine("\n\n Press Enter to continue");
                Console.ReadLine();
                AdminMenu();
            }
            else if (choice == "3")
            {
                Console.WriteLine(" Please Enter the First Letter of Word Capital!!");
                Console.WriteLine();
                Console.Write(" Please Enter the word : ");
                string word = Console.ReadLine();
                char ww = char.ToUpper(word[0]);
                foreach (var item in dictionary)
                {
                    if (item.word == ww)
                    {
                        item.DeleteNode(word);                        
                        break;
                    }            
                }
              //  Console.WriteLine("\n\t **** The Word is Deleted from MY DICTIONARY ****");
                Console.WriteLine("\n\n Press Enter to continue");
                Console.ReadLine();
                AdminMenu();
            }
            else if (choice == "4")
            {
                Console.WriteLine(" Please Enter the First Letter of Word Capital!!");
                Console.WriteLine();
                Console.Write(" Please Enter the word : ");
                string word = Console.ReadLine();
                char ww = char.ToUpper(word[0]);
                foreach (var item in dictionary)
                {
                    if (item.word == ww)
                    {
                        item.Search(word);
                        break;
                    }                  
                }
               
                Console.WriteLine("\n\n Press Enter to continue");
                Console.ReadLine();
                AdminMenu();
            }
            else if (choice == "5")
            {
                Console.WriteLine();
                Console.WriteLine(" *******************************************");
                Console.WriteLine("|                MY DICTIONARY              |");
                Console.WriteLine(" *******************************************");
                Console.WriteLine();
                foreach (var item in dictionary)
                {
                    item.Display();
                }
                Console.WriteLine("\n\n Press Enter to continue");
                Console.ReadLine();
                AdminMenu();
            }
            else if (choice == "6")
            {
                Console.WriteLine("\n\t **** YOU ARE LOGGING OUT OF THE ADMIN MENU **** ");
                Console.WriteLine("\n\n Press Enter to continue");
                Console.ReadLine();
                MainMenu();
            }
            else if (choice == " ")
            {
                Console.WriteLine("Please Write Number Between 1 to 6");
            }
            else
            {
                Console.WriteLine("\n\t  Invalid Input!! \n\n Press Enter to continue");
                Console.ReadLine();
                AdminMenu();
            }
        }
        public static void UserMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" *******************************************");
            Console.WriteLine("|           WELCOME TO USER MENU            |");
            Console.WriteLine(" *******************************************");
            Console.WriteLine();
            Console.WriteLine(" ===========================================");
            Console.WriteLine("|           1) SEARCH FOR A WORD            |");
            Console.WriteLine("|           2) PRINT MY DICTIONARY          |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|           3) RETURN TO MAIN MENU          |");
            Console.WriteLine(" ===========================================");
            Console.WriteLine();
            Console.Write("  Enter the number of the option you want to do : ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine(" Please Enter the First Letter of Word Capital!!");
                Console.WriteLine();
                Console.Write(" Please Enter the word : ");
                string word = Console.ReadLine();
                char ww = char.ToUpper(word[0]);
                foreach (var item in dictionary)
                {
                    if (item.word == ww)
                    {
                        item.Search(word);
                        break;
                    }
                }
                Console.WriteLine("\n\n Press Enter to continue");
                Console.ReadLine();
                UserMenu();
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                Console.WriteLine(" *******************************************");
                Console.WriteLine("|                MY DICTIONARY              |");
                Console.WriteLine(" *******************************************");
                Console.WriteLine();
                foreach (var item in dictionary)
                {
                    item.Display();
                }
                Console.WriteLine("\n\n Press Enter to continue");
                Console.ReadLine();
                UserMenu();
            }
            else if (choice == "3")
            {
                Console.WriteLine("\n Do you want to send any message to admin: (Write Something or Just Enter)");
                Console.Write("  ");
                Console.ReadLine();
                Console.WriteLine("\n\t **** Thank you for visiting MY DICTIONARY ****");
                Console.WriteLine("\n\n Press Enter to continue");
                Console.ReadLine();
                MainMenu();
            }
            else if (choice == " ")
            {
                Console.WriteLine("Please Enter Number between 1 and 3");
            }
            else
            {
                Console.WriteLine("\n\t  Invalid Input!! \n\n Press Enter to continue");
                Console.ReadLine();
                UserMenu();
            }
        }

        public static void readfile()
        {
            string dir = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            string serializationFile = Path.Combine(dir, "Dictionary.txt");

            if (!File.Exists(Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())), "Dictionary.txt")))
            {
                initializedictionaryfile();
                writeonfile();
            }
            using (Stream stream = File.Open(serializationFile, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                dictionary = (List<Linked_List>)bformatter.Deserialize(stream);
            }
        }
        public static void writeonfile()
        {
            string dir = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            string serializationFile = Path.Combine(dir, "Dictionary.txt");
            using (Stream stream = File.Open(serializationFile, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, dictionary);
            }
        }
    }
}
