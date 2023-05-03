using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBound = 35f;
    private float botBound = -15f;

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z > topBound || this.transform.position.z < botBound) 
        {
            Destroy(gameObject);
        }
    }
}
