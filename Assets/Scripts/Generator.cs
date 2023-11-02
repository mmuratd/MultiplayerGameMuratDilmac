using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Netcode;
using UnityEngine;
using Random = UnityEngine.Random;

public class Generator : NetworkBehaviour
{
    [SerializeField] public GameObject objectPrefab;
    [SerializeField] public Transform spawnArea;
    public float spawnInterval = 2f;
    public int numberOfObjectsToSpawn = 5;

    private float timer;

    void Update()
    {
        if (IsServer)
        {
            timer += Time.deltaTime;

            if (timer >= spawnInterval)
            {
                SpawnRandomObjectsInArea();
                timer = 0f;
            }
        }
    }

    private void SpawnRandomObjectsInArea()
    {
        for (int i = 0; i < numberOfObjectsToSpawn; i++)
        {
            Vector3 randomPosition = GetRandomPositionInArea();
            Quaternion randomRotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);

            GameObject newObject = Instantiate(objectPrefab, randomPosition, randomRotation);

            NetworkObject networkObject = newObject.GetComponent<NetworkObject>();

            if (networkObject != null)
            {
                networkObject.Spawn(true);
            }
        }
    }

    private Vector3 GetRandomPositionInArea()
    {
        Vector3 minPosition = spawnArea.position - new Vector3(10,0,10);
        Vector3 maxPosition = spawnArea.position + new Vector3(10, 0, 10);

        float randomX = Random.Range(minPosition.x, maxPosition.x);
        float randomY = spawnArea.position.y;
        float randomZ = Random.Range(minPosition.z, maxPosition.z);

        return new Vector3(randomX, randomY, randomZ);
    }

}
