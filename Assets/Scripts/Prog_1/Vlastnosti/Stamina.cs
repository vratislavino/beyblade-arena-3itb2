using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stamina : MonoBehaviour
{
    [SerializeField] private double maxStamina = 1;
    private double stamina;

    private void Start()
    {
        this.stamina = maxStamina;
    }

    public double GetStamina => stamina;

    public void DecreaseStamina(double amount)
    {
        if (amount >= 0)
        {
            this.stamina -= amount;
        }
    }

    public void SetStamina(double amount)
    {
        if (amount >= 0 && amount <= maxStamina)
        {
            this.stamina = amount;
        }
    }
}