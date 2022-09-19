using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager
{ 
    [SerializeField] private int health = 1;

    public int decreaseHealthBy(int value)
    {
        health -= value;
        return health;
    }

    public int getHealth() { return health; }
    public void setHealth(int value) { this.health = value; }

}
