using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float bullet_speed = 50.0F;
    public float destroy_time = 0.5f;
    AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bul = Instantiate(bullet);
            audioData.Play(0);

            bul.gameObject.GetComponent<Transform>().position = transform.position + transform.forward + new Vector3(0, 2, 0);
            bul.gameObject.GetComponent<Transform>().LookAt(this.transform);
            bul.gameObject.GetComponent<Rigidbody>().velocity = bullet_speed * transform.forward;
            Destroy(bul, destroy_time);
        }
    }
}
