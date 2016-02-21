using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentResourceSystem_PW2
{
    class Program
    {
        static Dictionary<string, int> studentID = new Dictionary<string, int>()
        { {"Bob Jones", 00120 }, {"Chad Lego", 00121 }, {"Dale Earnie", 00122 }, {"Jack Johnson", 00123 }, {"Ricky Bobby", 00124 } };

        static List<string> resources = new List<string>()
            { "ASP.NET MVC5", "C# Players Guide", "Cracking the Tech Career", "Database Design for Mere Mortals", "Eloquent JavaScript",
            "Essential C#", "Head First C#", "Javascript for Kids", "Killer Game Programming in Java", "Problem Solving and Programming Design in C" };

        
        static List<string> bobJones = new List<string>() { };
        static List<string> chadLego = new List<string>() { };
        static List<string> daleEarnie = new List<string>() { };
        static List<string> jackJohnson = new List<string>() { };
        static List<string> rickyBobby = new List<string>() { };
 
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            List<string> Menu1 = new List<string>() { "\n\t1. View Students", "\n\t2. View Available Resources", "\n\t3. View Student Accounts", "\n\t4. Checkout Item", "\n\t5. Return Item", "\n\t6. Exit" };
            string[] menu = Menu1.ToArray();
            Console.WriteLine("**********Hello welcome to: \"Bootcamp Resources Checkout System\"**********");
            Console.WriteLine("*****Please choose one of the following \"Menu Items\"*****");
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine("\t" + menu[i]);
            }

            string optionMenu = Console.ReadLine().ToLower();
            switch (optionMenu)
            {
                case "1":
                case "view students":
                    Console.Clear();
                    StudentNames();
                    break;
                case "2":
                case "view available resources":
                    Console.Clear();
                    Available();
                    break;
                case "3":
                case "view student accounts":
                    Console.Clear();
                    Accounts();
                    break;
                case "4":
                case "checkout":
                    Console.Clear();
                    Checkout();
                    break;
                case "5":
                case "return":
                    Console.Clear();
                    Return();
                    break;
                case "6":
                case "exit":
                    Console.Clear();
                    Exit();
                    break;
                default:
                    Console.Clear();
                    Menu();
                    break;
            }

        }
        
        static void StudentNames()
        {
            Dictionary<string, int> studentID = new Dictionary<string, int>()
            { {"Bob Jones", 00120 }, {"Chad Lego", 00121 }, {"Dale Earnie", 00122 }, {"Jack Johnson", 00123 }, {"Ricky Bobby", 00124 } };

            StringBuilder students = new StringBuilder();
            foreach (KeyValuePair<string, int> id in studentID)
            {
                students.Append(id).Append("\n");
            }
            Console.WriteLine(students);

            Menu();

        }

        static void Available()
        {
            StringBuilder available = new StringBuilder();

            for (int j = 0; j < resources.Count; j++)
            {
                available.Append(resources[j]).Append("\n");
            }
            Console.WriteLine(available);

            Menu();

        }

        static void Accounts()
        {
            StringBuilder booksChecked = new StringBuilder();

            foreach (KeyValuePair<string, int> names in studentID)
            {
                Console.WriteLine(names);
            }
            Console.WriteLine("Enter Student ID number: ");
            string fullName = Console.ReadLine().ToLower();

            if (studentID.ContainsKey(fullName))
            {
                Console.WriteLine("Please enter ID number: ");
                Accounts();
            }
            else if (studentID.ContainsValue(int.Parse(fullName)))
            {
                Console.ReadKey();
            }
            
            else
            {
                Console.WriteLine("Error: Request Unavailable");
                Console.ReadKey();
                Console.Clear();
                Accounts();
            }

            if (fullName == "120")
            {
                if (bobJones.Count == 0)
                {
                    Console.WriteLine("You have nothing checked out!");
                }
                for (int a = 0; a < bobJones.Count; a++)
                {
                    booksChecked.Append(bobJones[a]).Append("\n");
                }
                Console.WriteLine(booksChecked);

                StreamReader reader = new StreamReader("BobJones.txt");
                using (reader)
                {
                    string booksOut = reader.ReadToEnd();
                    Console.Write($"These books are checked out");
                }
            }
            if (fullName == "121")
            {
                if (chadLego.Count == 0)
                {
                    Console.WriteLine("You have nothing checked out!");
                }
                for (int a = 0; a < chadLego.Count; a++)
                {
                    booksChecked.Append(chadLego[a]).Append("\n");
                }
                Console.WriteLine(booksChecked);

                StreamReader reader = new StreamReader("ChadLego.txt");
                using (reader)
                {
                    string booksOut = reader.ReadToEnd();
                    Console.Write($"These books are checked out");
                }
            }
            if (fullName == "122")
            {
                if (daleEarnie.Count == 0)
                {
                    Console.WriteLine("You have nothing checked out!");
                }
                for (int a = 0; a < daleEarnie.Count; a++)
                {
                    booksChecked.Append(daleEarnie[a]).Append("\n");
                }
                Console.WriteLine(booksChecked);

                StreamReader reader = new StreamReader("DaleEarnie.txt");
                using (reader)
                {
                    string booksOut = reader.ReadToEnd();
                    Console.Write($"These books are checked out");
                }
            }
            if (fullName == "123")
            {
                if (jackJohnson.Count == 0)
                {
                    Console.WriteLine("You have nothing checked out!");
                }
                for (int a = 0; a < jackJohnson.Count; a++)
                {
                    booksChecked.Append(jackJohnson[a]).Append("\n");
                }
                Console.WriteLine(booksChecked);

                StreamReader reader = new StreamReader("JackJohnson.txt");
                using (reader)
                {
                    string booksOut = reader.ReadToEnd();
                    Console.Write($"These books are checked out");
                }
            }
            if (fullName == "124")
            {
                if (rickyBobby.Count == 0)
                {
                    Console.WriteLine("You have nothing checked out!");
                }
                for (int a = 0; a < rickyBobby.Count; a++)
                {
                    booksChecked.Append(rickyBobby[a]).Append("\n");
                }
                Console.WriteLine(booksChecked);

                StreamReader reader = new StreamReader("RickyBobby.txt");
                using (reader)
                {
                    string booksOut = reader.ReadToEnd();
                    Console.Write($"These books are checked out");
                }
            }

            Menu();

        }
        
        static void Checkout()
        {
            bool book = false;
            foreach (KeyValuePair<string, int> names in studentID)
            {
                Console.WriteLine(names);
            }
            Console.WriteLine("Enter Student ID number: ");
            string fullName = Console.ReadLine().ToLower();

            if (studentID.ContainsValue(int.Parse(fullName)))
            {
                book = true;
                Console.ReadKey();
            }
            if (book == false)
            {
                Console.WriteLine("Error: Request Unavailable");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                bool bookOut = false;
                Console.Write("\n");
                Console.WriteLine("Enter title  you would like to check out: \n");
                for (int g = 0; g < resources.Count; g++)
                {
                    Console.WriteLine(resources[g]);
                }
                string checkingOut = Console.ReadLine().ToLower();

                while (true)
                {
                    if (resources.Contains(checkingOut, StringComparer.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("true");
                        Console.ReadKey();
                        break;
                    }
                    if (bookOut == false)
                    {
                        Console.WriteLine("Error: Request Unavailable");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                }

                if (fullName == "120")
                {
                    resources.Remove(checkingOut);
                    bobJones.Add(checkingOut);
                    while (true)
                    {
                        Console.WriteLine("Would you like to check out another book? (y\n)");
                        string topicSelection = Console.ReadLine();
                        if (topicSelection.ToLower() == "y")
                        {
                            Console.WriteLine("Enter book title: \n");
                            for (int g = 0; g < resources.Count; g++)
                            {
                                Console.WriteLine(resources[g]);
                            }
                            Console.WriteLine("\n");
                            checkingOut = Console.ReadLine();
                            resources.Remove(checkingOut);
                            bobJones.Add(checkingOut);
                        }
                        else if (topicSelection.ToLower() == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection, please enter (y\n)");
                        }
                    }

                    StreamWriter checkoutBook = new StreamWriter("BobJones.txt");
                    using (checkoutBook)
                    {
                        for (int c = 0; c < bobJones.Count; c++)
                        {
                            checkoutBook.WriteLine(bobJones[c]);
                        }
                    }
                }

                if (fullName == "121")
                {
                    resources.Remove(checkingOut);
                    chadLego.Add(checkingOut);
                    while (true)
                    {
                        Console.WriteLine("Would you like to check out another book? (y\n)");
                        string topicSelection = Console.ReadLine();
                        if (topicSelection.ToLower() == "y")
                        {
                            Console.WriteLine("Enter book title: \n");
                            for (int g = 0; g < resources.Count; g++)
                            {
                                Console.WriteLine(resources[g]);
                            }
                            Console.WriteLine("\n");
                            checkingOut = Console.ReadLine();
                            resources.Remove(checkingOut);
                            chadLego.Add(checkingOut);
                        }
                        else if (topicSelection.ToLower() == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection, please enter (y\n)");
                        }
                    }
                    StreamWriter checkoutBook = new StreamWriter("ChadLego.txt");
                    using (checkoutBook)
                    {
                        for (int c = 0; c < chadLego.Count; c++)
                        {
                            checkoutBook.WriteLine(chadLego[c]);
                        }
                    }
                }

                if (fullName == "122")
                {
                    resources.Remove(checkingOut);
                    daleEarnie.Add(checkingOut);
                    while (true)
                    {
                        Console.WriteLine("Would you like to check out another book? (y\n)");
                        string topicSelection = Console.ReadLine();
                        if (topicSelection.ToLower() == "y")
                        {
                            Console.WriteLine("Enter book title: \n");
                            for (int g = 0; g < resources.Count; g++)
                            {
                                Console.WriteLine(resources[g]);
                            }
                            Console.WriteLine("\n");
                            checkingOut = Console.ReadLine();
                            resources.Remove(checkingOut);
                            daleEarnie.Add(checkingOut);
                        }
                        else if (topicSelection.ToLower() == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection, please enter (y\n)");
                        }
                    }
                    StreamWriter checkoutBook = new StreamWriter("DaleEarnie.txt");
                    using (checkoutBook)
                    {
                        for (int c = 0; c < daleEarnie.Count; c++)
                        {
                            checkoutBook.WriteLine(daleEarnie[c]);
                        }
                    }
                }

                if (fullName == "123")
                {
                    resources.Remove(checkingOut);
                    jackJohnson.Add(checkingOut);
                    while (true)
                    {
                        Console.WriteLine("Would you like to check out another book? (y\n)");
                        string topicSelection = Console.ReadLine();
                        if (topicSelection.ToLower() == "y")
                        {
                            Console.WriteLine("Enter book title: \n");
                            for (int g = 0; g < resources.Count; g++)
                            {
                                Console.WriteLine(resources[g]);
                            }
                            Console.WriteLine("\n");
                            checkingOut = Console.ReadLine();
                            resources.Remove(checkingOut);
                            jackJohnson.Add(checkingOut);
                        }
                        else if (topicSelection.ToLower() == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection, please enter (y\n)");
                        }
                    }
                    StreamWriter checkoutBook = new StreamWriter("JackJohnson.txt");
                    using (checkoutBook)
                    {
                        for (int c = 0; c < jackJohnson.Count; c++)
                        {
                            checkoutBook.WriteLine(jackJohnson[c]);
                        }
                    }
                }

                if (fullName == "124")
                {
                    resources.Remove(checkingOut);
                    rickyBobby.Add(checkingOut);
                    while (true)
                    {
                        Console.WriteLine("Would you like to check out another book? (y\n)");
                        string topicSelection = Console.ReadLine();
                        if (topicSelection.ToLower() == "y")
                        {
                            Console.WriteLine("Enter book title: \n");
                            for (int g = 0; g < resources.Count; g++)
                            {
                                Console.WriteLine(resources[g]);
                            }
                            Console.WriteLine("\n");
                            checkingOut = Console.ReadLine();
                            resources.Remove(checkingOut);
                            rickyBobby.Add(checkingOut);
                        }
                        else if (topicSelection.ToLower() == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection, please enter (y\n)");
                        }
                    }
                    StreamWriter checkoutBook = new StreamWriter("RickyBobby.txt");
                    using (checkoutBook)
                    {
                        for (int c = 0; c < rickyBobby.Count; c++)
                        {
                            checkoutBook.WriteLine(rickyBobby[c]);
                        }
                    }
                }
            }

            Menu();
        }
        
        static void Return()
        {

            bool book = false;
            foreach (KeyValuePair<string, int> names in studentID)
            {
                Console.WriteLine(names);
            }
            Console.WriteLine("Enter Student ID number: ");
            string fullName = Console.ReadLine().ToLower();

            if (studentID.ContainsValue(int.Parse(fullName)))
            {
                book = true;
                Console.ReadKey();
            }
            if (book == false)
            {
                Console.WriteLine("Error: Request Unavailable");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                bool bookOut = false;
                Console.Write("\n");
                Console.WriteLine("Enter title  you would like to return: \n");
                for (int g = 0; g < resources.Count; g++)
                {
                    Console.WriteLine(resources[g]);
                }
                string returnBook = Console.ReadLine().ToLower();

                while (true)
                {
                    if (resources.Contains(returnBook, StringComparer.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("true");
                        Console.ReadKey();
                        break;
                    }
                    if (bookOut == false)
                    {
                        Console.WriteLine("Error: Request Unavailable");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                }

                if (fullName == "120")
                {
                    resources.Add(returnBook);
                    bobJones.Remove(returnBook);
                    while (true)
                    {
                        Console.WriteLine("Would you like to return another book? (y\n)");
                        string topicSelection = Console.ReadLine();
                        if (topicSelection.ToLower() == "y")
                        {
                            Console.WriteLine("Enter book title: \n");
                            for (int g = 0; g < resources.Count; g++)
                            {
                                Console.WriteLine(resources[g]);
                            }
                            Console.WriteLine("\n");
                            returnBook = Console.ReadLine();
                            resources.Add(returnBook);
                            bobJones.Remove(returnBook);
                        }
                        else if (topicSelection.ToLower() == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection, please enter (y\n)");
                        }
                    }
                    StreamWriter returnTitle = new StreamWriter("BobJones.txt");
                    using (returnTitle)
                    {
                        for (int c = 0; c < bobJones.Count; c++)
                        {
                            returnTitle.WriteLine(bobJones[c]);
                        }
                    }
                }

                if (fullName == "121")
                {
                    resources.Add(returnBook);
                    chadLego.Remove(returnBook);
                    while (true)
                    {
                        Console.WriteLine("Would you like to return another book? (y\n)");
                        string topicSelection = Console.ReadLine();
                        if (topicSelection.ToLower() == "y")
                        {
                            Console.WriteLine("Enter book title: \n");
                            for (int g = 0; g < resources.Count; g++)
                            {
                                Console.WriteLine(resources[g]);
                            }
                            Console.WriteLine("\n");
                            returnBook = Console.ReadLine();
                            resources.Add(returnBook);
                            chadLego.Remove(returnBook);
                        }
                        else if (topicSelection.ToLower() == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection, please enter (y\n)");
                        }
                    }
                    StreamWriter returnTitle = new StreamWriter("ChadLego.txt");
                    using (returnTitle)
                    {
                        for (int c = 0; c < chadLego.Count; c++)
                        {
                            returnTitle.WriteLine(chadLego[c]);
                        }
                    }

                }

                if (fullName == "122")
                {
                    resources.Add(returnBook);
                    daleEarnie.Remove(returnBook);
                    while (true)
                    {
                        Console.WriteLine("Would you like to return another book? (y\n)");
                        string topicSelection = Console.ReadLine();
                        if (topicSelection.ToLower() == "y")
                        {
                            Console.WriteLine("Enter book title: \n");
                            for (int g = 0; g < resources.Count; g++)
                            {
                                Console.WriteLine(resources[g]);
                            }
                            Console.WriteLine("\n");
                            returnBook = Console.ReadLine();
                            resources.Add(returnBook);
                            daleEarnie.Remove(returnBook);
                        }
                        else if (topicSelection.ToLower() == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection, please enter (y\n)");
                        }
                    }
                    StreamWriter returnTitle = new StreamWriter("DaleEarnie.txt");
                    using (returnTitle)
                    {
                        for (int c = 0; c < daleEarnie.Count; c++)
                        {
                            returnTitle.WriteLine(daleEarnie[c]);
                        }
                    }
                }

                if (fullName == "123")
                {
                    resources.Add(returnBook);
                    jackJohnson.Remove(returnBook);
                    while (true)
                    {
                        Console.WriteLine("Would you like to return another book? (y\n)");
                        string topicSelection = Console.ReadLine();
                        if (topicSelection.ToLower() == "y")
                        {
                            Console.WriteLine("Enter book title: \n");
                            for (int g = 0; g < resources.Count; g++)
                            {
                                Console.WriteLine(resources[g]);
                            }
                            Console.WriteLine("\n");
                            returnBook = Console.ReadLine();
                            resources.Add(returnBook);
                            jackJohnson.Remove(returnBook);
                        }
                        else if (topicSelection.ToLower() == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection, please enter (y\n)");
                        }
                    }
                    StreamWriter returnTitle = new StreamWriter("JackJohnson.txt");
                    using (returnTitle)
                    {
                        for (int c = 0; c <jackJohnson.Count; c++)
                        {
                            returnTitle.WriteLine(jackJohnson[c]);
                        }
                    }
                }

                if (fullName == "124")
                {
                    resources.Add(returnBook);
                    rickyBobby.Remove(returnBook);
                    while (true)
                    {
                        Console.WriteLine("Would you like to return another book? (y\n)");
                        string topicSelection = Console.ReadLine();
                        if (topicSelection.ToLower() == "y")
                        {
                            Console.WriteLine("Enter book title: \n");
                            for (int g = 0; g < resources.Count; g++)
                            {
                                Console.WriteLine(resources[g]);
                            }
                            Console.WriteLine("\n");
                            returnBook = Console.ReadLine();
                            resources.Add(returnBook);
                            rickyBobby.Remove(returnBook);
                        }
                        else if (topicSelection.ToLower() == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection, please enter (y\n)");
                        }
                    }
                    StreamWriter returnTitle = new StreamWriter("RickyBobby.txt");
                    using (returnTitle)
                    {
                        for (int c = 0; c < rickyBobby.Count; c++)
                        {
                            returnTitle.WriteLine(rickyBobby[c]);
                        }
                    }
                }
            }
            Menu();
        }
        
        static void Exit()
        {
            Console.WriteLine("Good-Bye");
        }

    }
}
