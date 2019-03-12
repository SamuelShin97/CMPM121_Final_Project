using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class first_person_behavior : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("wall"))
        {
            Debug.Log("collide with wall");
            Physics.IgnoreCollision(collision.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
        }

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 3, player.transform.position.z);
        transform.rotation = player.transform.rotation;
    }
}
