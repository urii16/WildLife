using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemies = new GameObject[3];
    public int animalIndex;

    private float spawnRangeX = 16;
    private float spawnPositionZ;
    // Start is called before the first frame update
    void Start()
    {
        spawnPositionZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (animalIndex >= 0 && animalIndex < enemies.Length) 
        {
            if (Input.GetKeyDown(KeyCode.S)) 
            {
                Vector3 spawnPos = new Vector3(0, 0, spawnPositionZ);
                Instantiate(enemies[animalIndex], 
                    spawnPos, 
                    enemies[animalIndex].transform.rotation);
                
            }
        }
    }
}
