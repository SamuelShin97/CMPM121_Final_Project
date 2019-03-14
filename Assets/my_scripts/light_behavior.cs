﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_behavior : MonoBehaviour
{
    public GameObject player;
    public bool light_on;
    AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        light_on = true;
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 3, 0);
        transform.rotation = player.transform.rotation;
        if (Input.GetKeyDown(KeyCode.LeftShift) && this.gameObject.GetComponent<Light>().enabled == true)
        {
            audioData.Play(0);
            light_on = false;
            this.gameObject.GetComponent<Light>().enabled = false;
        }
        else if(Input.GetKeyDown(KeyCode.LeftShift) && this.gameObject.GetComponent<Light>().enabled == false)
        {
            audioData.Play(0);
            light_on = true;
            this.gameObject.GetComponent<Light>().enabled = true;
        }
    }
}