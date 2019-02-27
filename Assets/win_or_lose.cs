using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win_or_lose : MonoBehaviour
{
    public bool win = false;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            //prob have booleans set so that the game knows to put win or lose text on the screen

            SceneManager.LoadScene(2);
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            win = true;
            SceneManager.LoadScene(2);
        }
    }
}
