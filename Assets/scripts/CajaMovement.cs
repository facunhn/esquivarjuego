using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    public float velocidad = 3f;
    public float pisoY = -5f;  // límite inferior
    float initialYValue;

    void Start()
    {
        initialYValue = transform.position.y;  // guarda posición original
    }

    void Update()
    {
        transform.Translate(0, -velocidad * Time.deltaTime, 0);

        if (transform.position.y <= pisoY)  // si llegó al piso...
        {
            MoveBoxToRandomPosition();       // ...vuelve al origen
        }
    }

    public void MoveBoxToRandomPosition()
    {
        Vector3 newPosition = transform.position;
        newPosition.y = initialYValue;
        transform.position = newPosition;
    }
}