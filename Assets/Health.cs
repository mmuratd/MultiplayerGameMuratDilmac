using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] public int health;
    [SerializeField] public int maxHealth;
    [SerializeField] public int deadHealth;


    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        if (health < 0)
        {
           
        }
    }
}
