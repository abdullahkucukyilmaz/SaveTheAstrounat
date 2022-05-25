using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clone : MonoBehaviour
{
    public GameObject astroid1;
    void Start()
    {
        
        Destroy(astroid1, 9999);
        
    }

    public void OnColliderEnter(Collider coliider)
    {
        if (coliider.gameObject.name == "astroid1")
        {
            Destroy(astroid1);
        }
    }
}