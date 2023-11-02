using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiCreateObject : MonoBehaviour
{
    public GameObject canAzaltanPrefab;
    public Transform spawnPoint;

    public InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickCreateObject()
    {
        int canSayisi = int.Parse(inputField.text);
        for (int i = 0; i < canSayisi; i++)
        {
            Instantiate(canAzaltanPrefab, spawnPoint.position, Quaternion.identity);
        }
    }
}
