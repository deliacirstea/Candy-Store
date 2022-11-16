using System;
using System.Collections.Generic;

class Program
{
    /*private const string  Format = "Om du köper 100 gr blir det: kr";*/
    // Method for not repeating the code
    private const string Instructions = "Tryck på ENTER för att gå tillbacka till menyn!";
    public static void Main(string[] args)
    {

        // Introduction to the website
        Console.WriteLine("***********************************\n");
        Console.WriteLine(" Välkomma till Candinavia!\n");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("Vår onlinebutik erbjuder en mängd olika val för alla krav\n");
        Console.WriteLine("Tryck ENTER för att gå vidare till meny");
        Console.ReadKey();

        // Presentation of the menu
        string[] menuOptions = new string[] { "Plocka  själv\t\t", "Köpa godispåse\t\t", "Sockerfritt varianter\t\t", "Registrera dig\t\t", "Avsluta meny\t\t" }; // Variables with users choice
        int menuSelect = 0;

        while (true)
        { // loop
            Console.Clear(); // Method for cleaning the screen
            Console.CursorVisible = false; // Hide the cursor

            if (menuSelect == 0)
            {
                Console.WriteLine("** " + menuOptions[0] + "<--");
                Console.WriteLine(menuOptions[1]);
                Console.WriteLine(menuOptions[2]);
                Console.WriteLine(menuOptions[3]);
                Console.WriteLine(menuOptions[4]);
            }

            else if (menuSelect == 1)
            {
                Console.WriteLine(menuOptions[0]);
                Console.WriteLine("** " + menuOptions[1] + "<--");
                Console.WriteLine(menuOptions[2]);
                Console.WriteLine(menuOptions[3]);
                Console.WriteLine(menuOptions[4]);
            }


            else if (menuSelect == 2)
            {
                Console.WriteLine(menuOptions[0]);
                Console.WriteLine(menuOptions[1]);
                Console.WriteLine("** " + menuOptions[2] + "<--");
                Console.WriteLine(menuOptions[3]);
                Console.WriteLine(menuOptions[4]);
            }

            else if (menuSelect == 3)
            {
                Console.WriteLine(menuOptions[0]);
                Console.WriteLine(menuOptions[1]);
                Console.WriteLine(menuOptions[2]);
                Console.WriteLine("** " + menuOptions[3] + "<--");
                Console.WriteLine(menuOptions[4]);
            }
            else if (menuSelect == 4)
            {
                Console.WriteLine(menuOptions[0]);
                Console.WriteLine(menuOptions[1]);
                Console.WriteLine(menuOptions[2]);
                Console.WriteLine(menuOptions[3]);
                Console.WriteLine("** " + menuOptions[4] + "< --");

            }
            var keyPressed = Console.ReadKey();
            // för att pilen inte ska kunna gå över menyvalen
            if (keyPressed.Key == ConsoleKey.DownArrow && menuSelect != menuOptions.Length - 1)
            {
                menuSelect++;
            }
            // samma fast åt andr hållet
            else if (keyPressed.Key == ConsoleKey.UpArrow && menuSelect >= 1)
            {
                menuSelect--;
            }
            else if (keyPressed.Key == ConsoleKey.Enter)
            {
                switch (menuSelect)
                {
                    case 0:
                        FirstChoice();
                        break;
                    case 1:
                        SecondChoice();
                        break;
                    case 2:
                        ThirdChoice();
                        break;
                    case 3:
                        FourthChoice();
                        break;
                    case 4:
                        FifthChoice();
                        break;
                }
            }

            else
            { // If the users selects invalid choice
                Console.Clear();
                Console.WriteLine("Du gjorde inte giltigt val!\nGå tillbaka till menyn och gör ett nytt val!");
                Console.WriteLine("Tryck Enter för att gå tillbaka till menyn");
                Console.ReadKey();
            }
        }
    }
    // first choice on the menu
    public static void FirstChoice()
    {
        int x = 0;
        // variables with double value
        double a = 23.49;
        double b = 21.20;
        double c = 18.50;
        double d = 19.76;
        double e = 21.92;
        double f = 22.22;
        double g = 23.00;
        double h = 28.09;
        double i = 19.03;
        double j = 20.50;
        double k = a + a;
        double l = b + b;
        double m = c + c;
        double n = d + d;
        double o = e + e;
        double p = f + f;
        double q = g + g;
        double r = h + h;
        double s = i + i;
        double t = j + j;
        //Method for presenting the choices
        Console.Clear();
        Console.WriteLine("Har kan du plocka själv:");
        Console.WriteLine(("1. Mallaco Mallorca Mix = 23,49 kr/kg "), ((double)a));
        Console.WriteLine(("2. Panda Chockladlinser = 21,56 kr/hg "), ((double)b));
        Console.WriteLine(("3. Halva Salmiak Hårda Karameller = 18,90 kr/hg"), ((double)c));
        Console.WriteLine(("4. Malaco Zoo = 19,76 kr/hg"), ((double)d));
        Console.WriteLine(("5. Haribo Fruktnappar 21,92 kr/hg"), ((double)e));
        Console.WriteLine(("6. Toms stora rabarbebitar 22,22 kr/hg"), ((double)f));
        Console.WriteLine(("7. Löständer 23,00 kr/hg"), ((double)g));
        Console.WriteLine(("8. Halva Hallonlarv 28,09 kr/hg"), ((double)h));
        Console.WriteLine(("9. Toms Stor Karamella 19,03 kr/hg"), ((double)i));
        Console.WriteLine(("10. Lonka Jordgubbskulor 20,05kr/hg\n\n"), ((double)j));

        // Console.ReadKey();
        //Method for letting the user to write his choice
        Console.WriteLine("Skriv in ditt val och tryck på ENTER:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        // Function for getting the choice
        if (x == 1)
        {
            Console.WriteLine("Välj hur mycket vill du köpa:\n\n");
            Console.WriteLine("**********************************************");
            //Methods for calculating the users selection  
            Console.WriteLine("Om du köper 100 gr så blir det: {0} kr", a);
            Console.WriteLine("Om du köper 200 hg så blir det: {0} kr", a + a);
            Console.WriteLine("Om du köper 300 hg så blir det: {0} kr\n", k + a);
            Console.WriteLine(Instructions);
            Console.ReadLine();
        }
        if (x == 2)
        {
            Console.WriteLine("Välj hur mycket vill du köpa:\n\n");
            Console.WriteLine("**********************************************");
            //Methods for calculating the users selection    
            Console.WriteLine("Om du köper 100 hg så blir det: {0} kr", b);
            Console.WriteLine("Om du köper 200 hg så blir det: {0} kr", b + b);
            Console.WriteLine("Om du köper 300 hg så blir det: {0} kr\n", l + b);
            Console.WriteLine(Instructions);
            Console.ReadLine();
        }
        if (x == 3)
        {
            Console.WriteLine("Välj hur mycket vill du köpa:\n\n");
            Console.WriteLine("**********************************************");
            //Methods for calculating the users selection   
            Console.WriteLine("Om du köper 100 hg så blir det: {0} kr", c);
            Console.WriteLine("Om du köper 200 hg så blir det: {0} kr", c + c);
            Console.WriteLine("Om du köper 300 hg så blir det: {0} kr\n", m + c);
            Console.WriteLine(Instructions);
            Console.ReadLine();
        }
        if (x == 4)
        {
            Console.WriteLine("Välj hur mycket vill du köpa:\n\n");
            Console.WriteLine("**********************************************");
            //Methods for calculating the users selection    
            Console.WriteLine("Om du köper 100 hg så blir det: {0} kr", d);
            Console.WriteLine("Om du köper 200 hg så blir det: {0} kr", d + d);
            Console.WriteLine("Om du köper 300 hg så blir det: {0} kr\n", n + c);
            Console.WriteLine(Instructions);
            Console.ReadLine();
        }
        if (x == 5)
        {
            Console.WriteLine("Välj hur mycket vill du köpa:\n\n");
            Console.WriteLine("**********************************************");
            //Methods for calculating the users selection   
            Console.WriteLine("Om du köper 100 hg så blir det: {0} kr", e);
            Console.WriteLine("Om du köper 200 hg så blir det: {0} kr", e + e);
            Console.WriteLine("Om du köper 300 hg så blir det: {0} kr\n", o + e);
            Console.WriteLine(Instructions);
            Console.ReadLine();
        }
        if (x == 6)
        {
            Console.WriteLine("Välj hur mycket vill du köpa:\n\n");
            Console.WriteLine("**********************************************");
            //Methods for calculating the users selection   
            Console.WriteLine("Om du köper 100 hg så blir det: {0} kr", f);
            Console.WriteLine("Om du köper 200 hg så blir det: {0} kr", f + f);
            Console.WriteLine("Om du köper 300 hg så blir det: {0} kr\n", p + f);
            Console.WriteLine(Instructions);
            Console.ReadLine();
        }
        if (x == 7)
        {
            Console.WriteLine("Välj hur mycket vill du köpa:\n\n");
            Console.WriteLine("**********************************************");
            //Methods for calculating the users selection   
            Console.WriteLine("Om du köper 100 hg så blir det: {0} kr", g);
            Console.WriteLine("Om du köper 200 hg så blir det: {0} kr", g + g);
            Console.WriteLine("Om du köper 300 hg så blir det: {0} kr\n", q + g);
            Console.WriteLine(Instructions);
            Console.ReadLine();
        }
        if (x == 8)
        {
            Console.WriteLine("Välj hur mycket vill du köpa:\n\n");
            Console.WriteLine("**********************************************");
            //Methods for calculating the users selection   
            Console.WriteLine("Om du köper 100 hg så blir det: {0} kr", h);
            Console.WriteLine("Om du köper 200 hg så blir det: {0} kr", h + h);
            Console.WriteLine("Om du köper 300 hg så blir det: {0} kr\n", r + h);
            Console.WriteLine(Instructions);
            Console.ReadLine();
        }
        if (x == 9)
        {
            Console.WriteLine("Välj hur mycket vill du köpa:\n\n");
            Console.WriteLine("**********************************************");
            //Methods for calculating the users selection   
            Console.WriteLine("Om du köper 100 hg så blir det: {0} kr", i);
            Console.WriteLine("Om du köper 200 hg så blir det: {0} kr", i + i);
            Console.WriteLine("Om du köper 300 hg så blir det: {0} kr\n", s + i);
            Console.WriteLine(Instructions);
            Console.ReadLine();
        }
        if (x == 10)
        {
            Console.WriteLine("Välj hur mycket vill du köpa:\n\n");
            Console.WriteLine("**********************************************");
            //Methods for calculating the users selection   
            Console.WriteLine("Om du köper 100 hg så blir det: {0} kr", j);
            Console.WriteLine("Om du köper 200 hg så blir det: {0} kr", j + j);
            Console.WriteLine("Om du köper 300 hg så blir det: {0} kr\n", t + j);
            Console.WriteLine(Instructions);
            Console.ReadLine();
        }

        else
        { //If the users selects invalid choice
            Console.Clear();
            Console.WriteLine("Du gjorde inte giltigt val!\nGå tillbaka till menyn och gör ett nytt val!");
            Console.WriteLine("Tryck Enter för att gå tillbaka till menyn");
            Console.ReadKey();
        }

    }


    public static void SecondChoice()
    {
        //public static void SecondChoice(int x) {
        int x = 0;
        decimal a = 99;
        decimal b = 89;
        decimal c = 101;

        Console.Clear();
        Console.WriteLine("Har hittar du några varianter av redan gjört godipåsar:\n");
        Console.WriteLine(("1. Trolli All-in-one Godispåse 99kr"), ((decimal)a));
        Console.WriteLine(("2. Gott&Blandat Original 89kr"), ((decimal)b));
        Console.WriteLine(("3. Matador Mix Godisburk 101\n"), ((decimal)c));

        Console.WriteLine("Skriv in ditt val och tryck på ENTER:\n");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        //Method of calculation users choice 
        if (x == 1)
        {
            x = 0;
            Console.Clear();
            Console.WriteLine("Skriv in hur mycket vill du köpa och tryck på ENTER:\n");
            x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                //Methods for calculating the users selection 
                Console.WriteLine("Summan blir {0} kr\n", a);
                Console.WriteLine(Instructions);
                Console.ReadKey();
            }
            if (x == 2)
            {
                //Methods for calculating the users selection 
                Console.WriteLine("Summan blir {0} kr\n", a + a);
                Console.WriteLine(Instructions);
                Console.ReadKey();
            }
            if (x == 3)
            {
                //Methods for calculating the users selection 
                Console.WriteLine("Suman blir {0} kr\n", a + a + a);
                Console.WriteLine(Instructions);
                Console.ReadKey();
            }

        }

        if (x == 2)
        {
            x = 0;
            Console.Clear();
            Console.WriteLine("Skriv in hur mycket vill du köpa och tryck på ENTER:\n");
            x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                //Methods for calculating the users selection 
                Console.WriteLine("Summan blir {0} kr\n", b);
                Console.WriteLine(Instructions);
                Console.ReadKey();
            }
            if (x == 2)
            {
                //Methods for calculating the users selection 
                Console.WriteLine("Summan blir {0} kr\n", b + b);
                Console.WriteLine(Instructions);
                Console.ReadKey();
            }
            if (x == 3)
            {
                //Methods for calculating the users selection 
                Console.WriteLine("Summan blir {0} kr\n", b + b + b);
                Console.WriteLine(Instructions);
                Console.ReadKey();
            }
        }

        if (x == 3)
        {
            x = 0;
            Console.Clear();
            Console.WriteLine("Skriv in hur mycket vill du köpa och tryck på ENTER:\n");
            x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                //Methods for calculating the users selection 
                Console.WriteLine("Summan blir {0} kr\n", a);
                Console.WriteLine(Instructions);
                Console.ReadKey();
            }
            if (x == 2)
            {
                //Methods for calculating the users selection 
                Console.WriteLine("Summan blir {0} kr\n", a + a);
                Console.WriteLine(Instructions);
                Console.ReadKey();
            }
            if (x == 3)
            {
                //Methods for calculating the users selection 
                Console.WriteLine("Summan blir {0} kr\n", a + a + a);
                Console.WriteLine(Instructions);
                Console.ReadKey();
            }
        }
        else
        { //If the users selects invalid choice
            Console.Clear();
            Console.WriteLine("Du gjorde inte giltigt val!\nGå tillbaka till menyn och gör ett nytt val!");
            Console.WriteLine("Tryck Enter för att gå tillbaka till menyn");
            Console.ReadKey();
        }
    }

    public static void ThirdChoice()
    {
        int x = 0;
        Console.Clear();
        Console.WriteLine("Välkömma till våran hälsosammare val!\nHär hitar du en lista med fördelar av att konsumera minde socker:\n");
        // List with information
        List<string> benefitslist = new List<string>() { "Man får mer energi", "Man känner sig mättare", "Man får starkare tänder\n" };

        foreach (string i in benefitslist)
        {
            Console.Write(i);
            Console.Write("\n");
        }


        Console.WriteLine("Tryck enter för att gå vidare till våran sockerfri produkter:");
        Console.ReadLine();
        {
            decimal a = 26;
            decimal b = 24;
            decimal c = 12;


            Console.Clear();
            Console.WriteLine(("1. Pandy Candy 26kr"), ((decimal)a));
            Console.WriteLine(("2. Wellibites Päron&Melon 24 kr"), ((decimal)b));
            Console.WriteLine(("3. WW ViktVäktarna Krispiga kulor 12 kr"), ((decimal)c));
            Console.WriteLine("Skriv in ditt val: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            if (x == 1)
            {
                x = 0;
                Console.Clear();
                Console.WriteLine("Skriv in hur mycket vill du köpa och tryck på ENTER:\n");
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 1)
                {
                    //Methods for calculating the users selection 
                    Console.WriteLine("Summan blir {0} kr\n", a);
                    Console.WriteLine(Instructions);
                    Console.ReadKey();
                }
                if (x == 2)
                {
                    //Methods for calculating the users selection 
                    Console.WriteLine("Summan blir {0} kr\n", a + a);
                    Console.WriteLine(Instructions);
                    Console.ReadKey();
                }
                if (x == 3)
                {
                    //Methods for calculating the users selection 
                    Console.WriteLine("Suman blir {0} kr\n", a + a + a);
                    Console.WriteLine(Instructions);
                    Console.ReadKey();
                }
            }

            if (x == 2)
            {
                x = 0;
                Console.Clear();
                Console.WriteLine("Skriv in hur mycket vill du köpa och tryck på ENTER:\n");
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 1)
                {
                    //Methods for calculating the users selection 
                    Console.WriteLine("Summan blir {0} kr\n", b);
                    Console.WriteLine(Instructions);
                    Console.ReadKey();
                }
                if (x == 2)
                {
                    //Methods for calculating the users selection 
                    Console.WriteLine("Summan blir {0} kr\n", b + b);
                    Console.WriteLine(Instructions);
                    Console.ReadKey();
                }
                if (x == 3)
                {
                    //Methods for calculating the users selection 
                    Console.WriteLine("Suman blir {0} kr\n", b + b + b);
                    Console.WriteLine(Instructions);
                    Console.ReadKey();
                }
            }

            if (x == 3)
            {
                x = 0;
                Console.Clear();
                Console.WriteLine("Skriv in hur mycket vill du köpa och tryck på ENTER:\n");
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 1)
                {
                    //Methods for calculating the users selection 
                    Console.WriteLine("Summan blir {0} kr\n", c);
                    Console.WriteLine(Instructions);
                    Console.ReadKey();
                }
                if (x == 2)
                {
                    //Methods for calculating the users selection 
                    Console.WriteLine("Summan blir {0} kr\n", c + c);
                    Console.WriteLine(Instructions);
                    Console.ReadKey();
                }
                if (x == 3)
                {
                    //Methods for calculating the users selection 
                    Console.WriteLine("Suman blir {0} kr\n", c + c + c);
                    Console.WriteLine(Instructions);
                    Console.ReadKey();
                }

            }
        }

    }

    public static void FourthChoice()
    {
        Console.Clear();
        // Gather information about client
        Console.WriteLine("Skriv in ditt full namn och tryck på ENTER:");
        String name = Console.ReadLine();
        Console.WriteLine("Skriv in ditt email adress:");
        String email = Console.ReadLine();
        Console.WriteLine("Välj ett lösenord:");
        String password = Console.ReadLine();
        Console.WriteLine("Skriv in telefon nummer och tryck på ENTER:");
        int nummer = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Skriv in vilken stad du bor i och tryck på ENTER:");
        String place = Console.ReadLine();

        //Write out all the information
        Console.WriteLine(name + " " + email + " " + password + " " + nummer + " " + place);
        Console.ReadLine();
        Console.WriteLine("Tack för att du är med oss på Candinavia!\n");
        Console.WriteLine(Instructions);
        Console.ReadKey();


    }

    // Method of closing the program
    public static void FifthChoice()
    {
        Console.Clear();
        Console.WriteLine("Programmet avslutas!\n");
        Console.WriteLine("Tack för besöket!\n Vi hoppas att se dig igen!\n Ha en bra dag!");
        Console.WriteLine("Tryck Enter för att avsluta programmet!");
        Console.ReadKey();
        Environment.Exit(1);
    }


}