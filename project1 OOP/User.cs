namespace project1_OOP
{
    public class User
    {
        List<UserInformation> lst = new List<UserInformation>();

        public void displayAllServices()
        {
            Console.WriteLine("===================== CRUD =========================");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Update User");
            Console.WriteLine("3. Delete User");
            Console.WriteLine("4. Display all User");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                addUser();

            }
            else if (choice == 2)
            {
                updateUser();
            }
            else if (choice == 3)
            {
                deleteUser();
            }
            else if (choice == 4)
            {
                displayUser("the all users Information", 1);
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
            Console.WriteLine("=============================================");
            tryAgain();
        }
        public void addUser()
        {
            string name, email, number;
            Console.WriteLine("---------------------ADD USER--------------------------");
            Console.WriteLine("Enter your name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your email: ");
            email = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your number: ");
            number = Convert.ToString(Console.ReadLine());

            lst.Add(new UserInformation { Name = name, Email = email, Number = number });
            displayUser("The user information added",0);


        }
        public void updateUser()
        {
            Console.WriteLine("---------------------UPDATE USER--------------------------");
            Console.WriteLine("Enter User Phone Number you want to edit :");
            string number = Console.ReadLine();

            foreach (var user in lst)
            {
                if (user.Number == number)
                {
                    Console.WriteLine(
                        "enter 1 to Edit Name:" +
                        "\nenter 2 to Edit email:" +
                        "\nenter 3 to Edit phoneNumber:");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.WriteLine("Enter a new name: ");
                        user.Name = Console.ReadLine();
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Enter a new Email: ");
                        user.Email = Console.ReadLine();
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("Enter a new phone Number: ");
                        user.Number = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Invaled choice");
                    }
                }
                else Console.WriteLine("NA NUMBER");

            }
            displayUser("The user information is updated", 0);


        }

        public void deleteUser()
        {
            Console.WriteLine("---------------------Delete USER--------------------------");
            Console.WriteLine("Enter User Phone Number you want to delete :");
            string number = Console.ReadLine();
            var itemRemove = new List<UserInformation>();
            foreach(var i in lst)
            {
                if (i.Number == number)
                {
                    itemRemove.Add(i);
                    
                }
                else
                {
                    Console.WriteLine("this number not found , olease enter correct number");
                    deleteUser();
                }
            }
            foreach (var s in itemRemove)
            {
                lst.Remove(s);
            }
        }

        public void displayUser(String title, int index)
        {
            if (index == 0)
            {
                var innerl = lst.Last();
                
                    Console.WriteLine($"---------------------{title}--------------------------");
                    Console.WriteLine($"Name: {innerl.Name}");
                    Console.WriteLine($"Email: {innerl.Email}");
                    Console.WriteLine($"Number: {innerl.Number}");  
                    Console.WriteLine("========================================================");
            }
            else if( index == 1)
            {
               
                    foreach (var s in lst)
                    {
                      //  Console.WriteLine($"User :{i + 1}");
                        Console.WriteLine($"Name: {s.Name}");
                        Console.WriteLine($"Email: {s.Email}");
                        Console.WriteLine($"Number: {s.Number}");
                    }
            }
        }

        public void tryAgain()
        {
            Console.WriteLine("Do you want to try anything else\nY for yes || N for No");
            string answer = Console.ReadLine().ToUpper();
            if (answer == "Y")
                displayAllServices();
            else if (answer == "N")
                Console.WriteLine("mission is ended");
            else
            {
                Console.WriteLine("invaled charachter, Please try again\n");
                tryAgain();

            }

        }

    }
}


