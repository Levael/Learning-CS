// NOT TESTED

using System;

public class Program
{
    public static void Main()
    {
        Gun Desert_Eagle = new Gun();
        Console.WriteLine("Type: " + Desert_Eagle.getName(Desert_Eagle));
        for (int i = 0; i < 4; i++) Desert_Eagle.shoot();
        Desert_Eagle.reload();
        Console.WriteLine(Desert_Eagle.name + " " + Desert_Eagle.weight);
        Desert_Eagle.color = "red";
        Console.WriteLine(Desert_Eagle.color);
    }
}

interface IThing {
    int weight {get;}
    string color {get; set;}
}

interface IWeapon : IThing{
    void shoot();
    void reload();
    string getName(IWeapon weapon);
}

interface IName {
    string name {get;}
}

class Gun : IWeapon, IName {
    public void shoot () {
        Console.WriteLine("shoot");
    }
    
    public void reload () {
        Console.WriteLine("reload");
    }
    
    public string getName (IWeapon weapon) {
        return weapon.GetType().ToString();
    }
    
    public int weight {get => 49;}
    public string color {get; set;}
    public string name {get => "Nusha";}
    
    public void justFunc () {
        Console.WriteLine("Not necessary");
    }
}
