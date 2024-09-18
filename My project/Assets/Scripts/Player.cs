using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float speed = 5f;    


    void Start()
    {
        
    }


    void Update()
    {
        float movimentoHorizontal = 0;
        float movimentoVertical = 0;
        

        if (Input.GetKey(KeyCode.A))
        {
            movimentoHorizontal = -1;    
        }

        else if (Input.GetKey(KeyCode.D))
        {
            movimentoHorizontal = 1;
        }

    	else if (Input.GetKey(KeyCode.W))
        {
            movimentoVertical = 1;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            movimentoVertical = -1;
        }

        else
        {
            movimentoHorizontal = 0;
            movimentoVertical = 0;
        }

        transform.position += new Vector3(movimentoHorizontal, 0f, 0f) * speed * Time.deltaTime;
        transform.position += new Vector3(0f, movimentoVertical, 0f) * speed * Time.deltaTime;
    }
}
