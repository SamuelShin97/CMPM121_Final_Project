using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play_movie : MonoBehaviour
{
    public UnityEngine.Video.VideoClip videoClip;
    public Camera camera;
    // Start is called before the first frame update
    void Awake()
    {
        var videoPlayer = gameObject.AddComponent<UnityEngine.Video.VideoPlayer>();
        videoPlayer.playOnAwake = true;
        videoPlayer.isLooping = true;
        videoPlayer.clip = videoClip;
        videoPlayer.targetCamera = camera;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
