using System;
using System.Collections.Generic;
using System.Threading;
class game
{
    int cookies;
    int cpt;//cookies per turn
    int perClick;
    List<Upgrade> unlocked;
    List<Upgrade> upgrades;
    public game()
    {
        this.cookies = 0;
        this.cpt = 0;//upgrades will change this
        this.perClick = 1;
        this.upgrades = new List<Upgrade>();
        this.unlocked = new List<Upgrade>();
    }
    public void SetCookies(int num)
    {
        this.cookies = num;
    }
    public int GetCookies()
    {
        return(this.cookies);
    }
    public void Start()
    {
        while (true)
        {
            //input validation
            while (true)
            {
                Console.WriteLine("cookies: " + Convert.ToString(this.cookies) + " Cookies per turn: " + Convert.ToString(this.cpt));
                Console.Write("press enter to generate cookie or type shop to use shop ");
                string input = Console.ReadLine();
                if (input == "")
                {
                    this.cookies = this.cookies + this.perClick+this.cpt;
                    Console.WriteLine("You have gained " + Convert.ToString(this.perClick+this.cpt) + " cookies");
                    Thread.Sleep(200);
                    break;
                }
                if (input=="SHOP")
                {
                    Console.WriteLine("what would you like to buy?");
                    

                }
   
                else
                {
                    Console.WriteLine("invalid, learn english, go back to primary");

                }
            }
        }
    }
}