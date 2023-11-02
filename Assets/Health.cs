using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.Netcode;
using UnityEngine;

public class Health : NetworkBehaviour,IDamageable
{
    [SerializeField] public int playerHealth= 100;
    [SerializeField] public int maxHealth;
    [SerializeField] public int deadHealth;

    Animator animator;

    public void Damage(int damageAmount)
    {
        DamageServerRpc(damageAmount); 
    }
    [ServerRpc]
    private void DamageServerRpc(int damageAmount)
    {
        playerHealth = playerHealth - damageAmount;
        Debug.Log("healtte damage içi healt: " + playerHealth);
        animator.SetTrigger("Hurt");
        if (playerHealth < 1)
        {
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 10f);
        }
    }

    private void Awake()
    {
        animator = GetComponent<Animator>();

    }
    void Update()
    {

    }
}
