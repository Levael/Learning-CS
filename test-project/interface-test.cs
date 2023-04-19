// Not tested

using System;

public class Program
{
    public static void Main()
    {
        Gun Desert_Eagle = new Gun();
        Console.WriteLine("Type: " + Desert_Eagle.getName(Desert_Eagle));
        for (int i = 0; i < 4; i++) Desert_Eagle.shoot();
        Desert_Eagle.reload();
        Console.WriteLine("End");
    }
}

interface IWeapon {
    void shoot();
    void reload();
    string getName(IWeapon weapon);
}

class Gun : IWeapon {
    public void shoot () {
        Console.WriteLine("shoot");
    }
    
    public void reload () {
        Console.WriteLine("reload");
    }
    
    public string getName (IWeapon weapon) {
        return weapon.GetType().ToString();
    }
    
    public void justFunc () {
        Console.WriteLine("Not necessary");
    }
}
