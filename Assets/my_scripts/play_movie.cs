using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play_movie : MonoBehaviour
{
    public UnityEngine.Video.VideoClip videoClip;
    public new Camera camera;

    // Start is called before the first frame update
    void Awake()
    {
        var videoPlayer = gameObject.AddComponent<UnityEngine.Video.VideoPlayer>();
        videoPlayer.playOnAwake = true;
        videoPlayer.isLooping = true;
        videoPlayer.clip = videoClip;
        videoPlayer.targetCamera = camera;
        videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
        videoPlayer.waitForFirstFrame = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {

            Debug.Log("play title movie");
            var vp = GetComponent<UnityEngine.Video.VideoPlayer>();
            vp.Play();
        }
    }
}
