using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vlastnosti : MonoBehaviour
{
    [SerializeField] private double modifierZtratyStaminyZaCas = 1;
    private Rychlost rychlost;
    private Stamina stamina;
    private Defense defense;
    private Damage damage;
    void Start()
    {
        rychlost = new Rychlost();
        stamina = new Stamina();
        defense = new Defense();
        damage = new Damage();
    }

    private void Update()
    {
        stamina.DecreaseStamina(Time.deltaTime/(1 + modifierZtratyStaminyZaCas * 14));
        rychlost.CalcAndSetSpeed(stamina);
    }
    
    public static double CalculateDamage(Damage damage, Defense defense)
        {
            return damage.GetDamage * (1 - defense.GetDefense);
        }
}
