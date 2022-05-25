using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameratakip : MonoBehaviour
{
    public GameObject karakter;
    public Camera anakamera;
    Vector3 mesafe;
    void Start()
    {
        mesafe = transform.position - karakter.transform.position;
    }
    void Update()
    {
        transform.position = karakter.transform.position + mesafe;

    }
}
