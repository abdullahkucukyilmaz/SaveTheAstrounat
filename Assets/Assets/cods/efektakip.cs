using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efektakip : MonoBehaviour
{
    public GameObject karakter;
    ParticleSystem efek;
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
