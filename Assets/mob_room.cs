﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mob_room : MonoBehaviour
{
    public GameObject[] static_zombies;
    AudioSource audioData;
    bool once = false;
    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && once == false)
        {
            audioData.Play(0);
            once = true;
            for (int i = 0; i < static_zombies.Length; i++)
            {
                static_zombies[i].gameObject.tag = "enemy";
                static_zombies[i].gameObject.GetComponent<freeze>().enabled = false;
                static_zombies[i].gameObject.GetComponent<enemy_health>().enabled = true;
                static_zombies[i].gameObject.GetComponent<dr_who_angel_behavior>().enabled = true;
            }
        }
    }
}
