using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Speed variables -- rate of forward/backward movement
    private float speed = 15.0f;
    private float turnSpeed = 15.0f;

    //Input variables
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get user Inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //forward movement
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //left&right
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        //rotation -- turning vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
