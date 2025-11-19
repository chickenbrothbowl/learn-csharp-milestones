using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Name;
    public int Exp;
    public Character()
    {
        Name = "Not assigned";
    }
    public Character(string name)
    {
        this.Name = name;
    }
}

public class Paladin : Character
{
    public Paladin(string name) : base(name)
    {
    }
}