using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_behavior : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 3, 0);
        transform.rotation = player.transform.rotation;
        if (Input.GetKeyDown(KeyCode.LeftShift) && this.gameObject.GetComponent<Light>().enabled == true)
        {
            this.gameObject.GetComponent<Light>().enabled = false;
        }
        else if(Input.GetKeyDown(KeyCode.LeftShift) && this.gameObject.GetComponent<Light>().enabled == false)
        {
            this.gameObject.GetComponent<Light>().enabled = true;
        }
    }
}
