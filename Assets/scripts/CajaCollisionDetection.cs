using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaCollisionDetection : MonoBehaviour
{
    public CajaMovement CajaMovementScript;
    // Start is called before the first frame update
    
    void Start()
    {
        CajaMovementScript = GetComponent<CajaMovement>();
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        {
            CajaMovementScript.MoveBoxToRandomPosition();
        }
    }
}

