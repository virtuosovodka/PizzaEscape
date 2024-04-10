using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoKey : MonoBehaviour
{
    private AudioSource _audioSource;
    private string _note;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();

        // Note is set by tag
        _note = tag;
    }

    public string Play()
    {
        _audioSource.Play();
        return _note;
    }
}
