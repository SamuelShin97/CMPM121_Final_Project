using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freeze : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
