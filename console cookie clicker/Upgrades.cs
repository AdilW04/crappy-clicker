using System;
//workers like in normal cookie clicker
class Upgrade
{
    int cptBoost;
    int price;
    string name;
    public Upgrade(int p,string n,int c)
    {
        this.cptBoost = c;
        this.price = p;
        this.name = n;
        
    }
}