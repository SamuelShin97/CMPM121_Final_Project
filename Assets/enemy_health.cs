using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class enemy_health : MonoBehaviour
{
    public int health = 3;
    AudioSource audioData;
    
    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //int play_noise = Random.Range(0, 2000);
        if(health <= 0)
        {
            audioData.Play(0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            SceneManager.LoadScene(2);
        }
    }
}
