using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    float speed = 5f;    
    private Animator anim;

    private Rigidbody2D rig; 

    void Start()
    {
        anim = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
    }


    void Update()
    {

        

        if (Input.GetKey(KeyCode.A))
        {
            rig.velocity = Vector2.left * speed; 
            anim.SetBool("isRun", true);
            transform.eulerAngles = new Vector2(0f, 180f);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rig.velocity = Vector2.right * speed; 
            anim.SetBool("isRun", true);          
            transform.eulerAngles = new Vector2(0f, 0f);
        }

        else if (Input.GetKey(KeyCode.Space))
        {

        }

        else
        {
            anim.SetBool("isRun", false);
        }
    }
}
