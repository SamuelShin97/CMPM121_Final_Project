using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class which_screen : MonoBehaviour
{
    public UnityEngine.Video.VideoClip videoClip;
    public new Camera camera;
    public GameObject cam;
    

    // Start is called before the first frame update
    void Start()
    {
        var videoPlayer = gameObject.AddComponent<UnityEngine.Video.VideoPlayer>();
        videoPlayer.playOnAwake = false;
        videoPlayer.isLooping = true;
        videoPlayer.clip = videoClip;
        videoPlayer.targetCamera = camera;
        videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
        //var gamescript = GameObject.Find("PlaceHolder");

    }

    // Update is called once per frame
    void Update()
    {
        
        var gamescript = (win_or_lose)FindObjectOfType(typeof(win_or_lose));
        if (gamescript.win == false && SceneManager.GetActiveScene().buildIndex == 2)
        {
            
            Debug.Log("play lose movie");
            var vp = GetComponent<UnityEngine.Video.VideoPlayer>();
            vp.Play();
        }
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("wtf");
        cam.SetActive(true);
    }
}
