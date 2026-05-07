using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    public float velocidad = 3f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, -velocidad * Time.deltaTime, 0);
    }
}