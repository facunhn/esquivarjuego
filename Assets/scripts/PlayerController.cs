using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float limiteDerecha = 5f;
    public float limiteIzquierda = -5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
    {
        transform.Translate(2,0,0);
    }else     if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
    {
        transform.Translate(-2,0,0);
    }
     float x = Mathf.Clamp(transform.position.x, limiteIzquierda, limiteDerecha);
        transform.position = new Vector3(x, transform.position.y, transform.position.z);

    }
}
