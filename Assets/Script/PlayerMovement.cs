using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]float steerspeed = 0.1f;
    [SerializeField]float movespeed = 0.05f;
    [SerializeField] float nitrospeed = 1.8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal")*steerspeed*Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * movespeed* Time.deltaTime;
        if (Input.GetKey("left shift"))
        {
            moveAmount = moveAmount * nitrospeed;
        }
        if (moveAmount <= 0) { 
            moveAmount = 0;
            steerAmount = 0.0001f;
        }
        transform.Rotate(0, 0, - steerAmount);
        transform.Translate(0, moveAmount, 0);
        
    }
}
