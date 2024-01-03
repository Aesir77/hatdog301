using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon  //Damage patchnotes
{
    int damage_Sword = 5;
    int damage_Axe = 8;
    int damage_Mace = 6;

    public int Damage_Sword //Weapon damage calculator
    {
        get { return damage_Sword; }
        set { damage_Sword = value; }
    }
    public int Damage_Axe //Weapon damage calculator
    {
        get { return damage_Axe; }
        set { damage_Axe = value; }
    }
    public int Damage_Mace //Weapon damage calculator
    {
        get { return damage_Mace; }
        set { damage_Mace = value; }
    }
}
