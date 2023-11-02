using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;


public class DealDamage : NetworkBehaviour
{

    [SerializeField] private int attackPower = 10;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ontriggera girdi.");
        var hit = other.GetComponent<IDamageable>();

        if (hit != null)
        {
            Debug.Log("ontriggera girdi. ve hit null de�il");
            hit.Damage(attackPower);
        }
    }

}
