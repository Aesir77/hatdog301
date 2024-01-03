using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum eEquippedWeapons
    {
        Sword,
        Axe,
        Mace
    }

    [Header ("Player_Stats")]
    public float baseDamage;
    public float finalDamage;

    [Header("WeaponsEquipped")]
    public eEquippedWeapons equippedWeapons;

    private void OnValidate()
    {
        #region Weapon Equipment
        Weapon weapon = new Weapon();
        switch (equippedWeapons)
        {
            case eEquippedWeapons.Sword:
                finalDamage = baseDamage + weapon.Damage_Sword; 
                break;
                case eEquippedWeapons.Axe:
                finalDamage = baseDamage + weapon.Damage_Axe;
                break;
                case eEquippedWeapons.Mace:
                finalDamage = baseDamage + weapon.Damage_Mace;
                break;
            default:
                break;
        }
        #endregion

    }




}
