using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public GameObject projectilePrefab;
    /// <summary>
    /// /////////////////////////
    /// </summary>
    private float topBound = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   // Negative = These if statements keep the player inbound (Imaginary walls), set a variable called xRange, this makes sure that the player stays inbound 
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //Positive = These if statements keep the player inbound (Imaginary walls), set a variable called xRange, this makes sure that the player stays inbound 
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //SPacebar allows you to span food objects at enemies
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        ///////////////////////////////////////
     

        //This makes the player move left and right at a speed of 10, 10 comes from the float variable speed
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right *  horizontalInput * Time.deltaTime * speed);
    }
}
