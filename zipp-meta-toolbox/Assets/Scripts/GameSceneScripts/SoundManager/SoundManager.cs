using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : CoreGameObject
{
    public AudioSource audioSource;
    public AudioClip defaultAudioClip;

    public void PlayAudioClip(AudioClip audioClip = null)
    {
        if (audioClip == null)
        {
            audioSource.clip = defaultAudioClip;
        }
        else
        {
            audioSource.clip = audioClip;
        }
        audioSource.Play();
    }
}
