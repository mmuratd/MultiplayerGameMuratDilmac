using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.Netcode;
using UnityEngine;
using Microlight.MicroBar;

public class Health : NetworkBehaviour,IDamageable
{
    [SerializeField] public int playerHealth= 100;
    [SerializeField] public int maxHealth;
    [SerializeField] public int deadHealth;
    
    Animator animator;

    [Header("Healthbar")]
    [SerializeField] MicroBar characterHPBar;
    

    public void Damage(int damageAmount)
    {
        Debug.Log("healtte damage içi healt: " + playerHealth);
        if (IsClient)
        {
            DecreaseHealth(damageAmount);
        }
        DamageServerRpc(damageAmount); 
    }
    [ServerRpc]
    private void DamageServerRpc(int damageAmount)
    {
        DecreaseHealth(damageAmount);
        
       // PlayerHealthClientRpc(playerHealth);
        
    }

    private void DecreaseHealth(int damageAmount)
    {
        playerHealth = playerHealth - damageAmount;
        characterHPBar.UpdateHealthBar(playerHealth);
        Debug.Log("healtte damage server rpc içi healt: " + playerHealth);
        //animator.SetTrigger("Hurt");
        if (playerHealth < 1)
        {
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 10f);
        }
    }

    [ClientRpc]
    private void PlayerHealthClientRpc(int playerHealthServer)
    {
        playerHealth = playerHealthServer;
    }

    private void Awake()
    {
        animator = GetComponent<Animator>();

    }
    private void Start()
    {
        characterHPBar.Initialize(maxHealth);
    }
    void Update()
    {

    }
}
