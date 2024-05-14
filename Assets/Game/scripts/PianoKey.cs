using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoKey : MonoBehaviour
{
    private AudioSource _audioSource;
    public string note { get; private set; }

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();

        // Note is set by tag
        note = tag;
    }

    public void Play()
    {
        _audioSource.Play();
    }
}
