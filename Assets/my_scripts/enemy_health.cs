using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class enemy_health : MonoBehaviour
{
    public int health = 3;
    AudioSource audioData;
    //public GameObject player;
    //AudioSource audioData;
    
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
            //audioData.Play(0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && this.enabled == true)
        {
            audioData.Play(0);
            Debug.Log("died");
            StartCoroutine(LoadLevel(2, 1f));
            GameObject player = GameObject.Find("Player");
            player.GetComponent<Shoot>().enabled = false;
            player.GetComponent<movement>().enabled = false;
            GameObject.Find("Spot Light").GetComponent<light_behavior>().enabled = false;
            GameObject camera = GameObject.Find("MainCamera");
            camera.GetComponent<first_person_behavior>().enabled = false;
            camera.GetComponent<Transform>().position = new Vector3(10000, 1000, 0);
            //SceneManager.LoadScene(2);
        }
    }

    IEnumerator LoadLevel(int index, float _delay)
    {
        yield return new WaitForSeconds(_delay);
        Cursor.visible = true;
        SceneManager.LoadScene(index);
    }
}
