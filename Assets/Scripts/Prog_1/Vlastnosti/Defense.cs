using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defense : MonoBehaviour
{
    [SerializeField] private double defense = 0;

    public double GetDefense => defense;
}