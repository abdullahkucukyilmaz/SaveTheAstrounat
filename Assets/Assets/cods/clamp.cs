using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clamp : MonoBehaviour
{
    float xpozisyon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        xpozisyon = Mathf.Clamp(transform.position.x, -12f, 12f);
        transform.position = new Vector3(xpozisyon, transform.position.y, transform.position.z);
        

    }

}

