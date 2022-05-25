using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class sonsuzyol : MonoBehaviour
{
    public GameObject plane;
    private void OnTriggerEnter(Collider other)
    {
        transform.localScale += new Vector3(0f, 0f, 60f);
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
