using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
 
    
    Rigidbody rb;
   
    int donus = 200;
    float rotationX = 270;
    int rokethiz = 50;


    void Start()
    {
        

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        rotationX += Input.GetAxis("Horizontal") * donus * Time.deltaTime;
        rotationX = Mathf.Clamp(rotationX, 250, 300);
        transform.rotation = Quaternion.Euler(rotationX, 90, 90);

       


        rb.velocity = new Vector3(0, 0, rokethiz);
      
        




        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(0.09f, 0, 0);

            
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-0.09f, 0, 0);
           
        }


    }
}
