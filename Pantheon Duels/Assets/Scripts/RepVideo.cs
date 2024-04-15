using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class RepVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void OnEnable()
    {
        videoPlayer.Play();
    }
}
