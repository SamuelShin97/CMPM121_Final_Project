using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bullet_checks : MonoBehaviour
{

    public GameObject Player;
    Spawn_Enemies spawn_enemies;
    AudioSource audioData;
    public AudioClip hitmark;
    public AudioClip zombie_death;
    Renderer rend;
    Light light;
    // Start is called before the first frame update
    void Start()
    {
        spawn_enemies = Player.gameObject.GetComponent<Spawn_Enemies>();
        audioData = GetComponent<AudioSource>();
        rend = GetComponent<Renderer>();
        light = GetComponent<Light>();
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
            //Debug.Log("destory bullet");
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("enemy"))
        {
            rend.enabled = false;
            light.enabled = false;
            audioData.PlayOneShot(hitmark);
            Debug.Log("hit enemy");
            
            collision.gameObject.GetComponent<enemy_health>().health--;
            if (collision.gameObject.GetComponent<enemy_health>().health <= 0)
            {
                audioData.PlayOneShot(zombie_death);
                //collision.gameObject.GetComponent<Transform>().position = new Vector3(1000, 1000, 1000);
                spawn_enemies.enemy_count--;
                Destroy(collision.gameObject);
            }
            
            Destroy(this.gameObject, 5F);
        }

        /*if (collision.collider.tag == "wall" || collision.collider.tag == "floor1" || collision.collider.tag == "floor2" ||
                collision.collider.tag == "floor3" || collision.collider.tag == "door1" || collision.collider.tag == "door2")
        {
            Destroy(this.gameObject);
        }*/
    }
}
