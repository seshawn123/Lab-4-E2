using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAudioPlayer : MonoBehaviour
{
    private AudioSource audSource;
    public AudioClip audClip;

    private void Awake()
    {
        audSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        ClickPoint.clicked += PlayAudio;
        ClickHP.clicked += PlayAudio;
    }

    private void OnDisable()
    {
        ClickPoint.clicked -= PlayAudio;
        ClickHP.clicked -= PlayAudio;
    }

    private void PlayAudio()
    {

        audSource.PlayOneShot(audClip);
    }
}