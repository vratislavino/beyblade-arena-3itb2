using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rychlost : MonoBehaviour
{
    [SerializeField] private double maxSpeed = 1;
    private double speed;

    private void Start()
    {
        speed = maxSpeed;
    }

    public double GetSpeed => speed;

    public void CalcAndSetSpeed(Stamina stamina)
    {
        speed = maxSpeed - maxSpeed / Math.Max(stamina.GetStamina,1);
    }
}