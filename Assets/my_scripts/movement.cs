using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    public float sensitivity = 7.0f;
    //Animator anim;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 movement;
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * sensitivity, 0));
        //transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivity, 0);
        //transform.Rotate(0, Input.GetAxis("Mouse Y") * sensitivity, 0);
        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log("in W");

            movement = Vector3.forward;
           

            rb.AddRelativeForce(movement * speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movement = Vector3.back;
            

            rb.AddRelativeForce(movement * speed);
        }
         
        

        if (Input.GetKey(KeyCode.A))
        {
            movement = Vector3.left;


            rb.AddRelativeForce(movement * speed);
        }
        else if (Input.GetKey(KeyCode.D))
        {

            movement = Vector3.right;





            rb.AddRelativeForce(movement * speed);

        }
        //else
        //{
         //   rb.velocity = Vector3.zero;
        //}



    }
}
