using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bilboard : MonoBehaviour
{
    private Transform cameraTransform;

    private void Awake()
    {
        cameraTransform = FindAnyObjectByType(typeof(Camera)).GetComponent<Transform>();
    }
    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(transform.position + cameraTransform.forward);
    }
}
