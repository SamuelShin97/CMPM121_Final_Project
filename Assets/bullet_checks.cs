using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bullet_checks : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //do nothing
        }

        /*if (collision.gameObject.CompareTag("wall"))
        {
            Debug.Log("destory bullet");

            Destroy(this.gameObject);
        }*/
        if (collision.gameObject.transform.parent != null && collision.gameObject.transform.parent.CompareTag("wall"))
        {
            Debug.Log("destory bullet");
            Destroy(this.gameObject);
        }

        /*if (collision.collider.tag == "wall" || collision.collider.tag == "floor1" || collision.collider.tag == "floor2" ||
                collision.collider.tag == "floor3" || collision.collider.tag == "door1" || collision.collider.tag == "door2")
        {
            Destroy(this.gameObject);
        }*/
    }
}
