using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 10.0f;

    public float xRange = 16.0f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Movimiento del player
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);


        if (transform.position.x < -xRange) 
        {
            //Sale por la izquierda
            transform.position = new Vector2(-xRange,
                transform.position.y);
        }

        if ( transform.position.x > xRange)
        {
            //Sale por la derecha
            transform.position = new Vector2(xRange,
                transform.position.y);
        }

        //Acciones del player
        if (Input.GetKey(KeyCode.Space)) 
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }
}
