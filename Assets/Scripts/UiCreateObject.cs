using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class UiCreateObject : NetworkBehaviour
{
 
    [SerializeField] private Transform spawnedObjectPrefab;
    public TMP_InputField inputField;

    private Transform spawnedObjectTransform;


    [ServerRpc(RequireOwnership = false)]
    public void CreateObjectServerRpc(int canSayisi)
    {
        for (int i = 0; i < canSayisi; i++)
        {
            Debug.Log("CreateObjectServerRpc called with canCount: ");
            spawnedObjectTransform = Instantiate(spawnedObjectPrefab);
            spawnedObjectTransform.GetComponent<NetworkObject>().Spawn(true);
        }
      
       
    }


    public void OnClickCreateObject()
    {
        int canSayisi = int.Parse(inputField.text);
        Debug.Log("onclick button kýsmý" + canSayisi);

        CreateObjectServerRpc(canSayisi);
        
        
        
    }
}
