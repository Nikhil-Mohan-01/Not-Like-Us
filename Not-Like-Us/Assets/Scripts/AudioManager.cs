using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] clips;
    public AudioSource audioSource;

    void Start()
    {
        //audioSource = GetComponent<AudioSource>();
    }

    public void PlayRandomClip()
    {
        if (clips.Length == 0) return;

        int randomIndex = Random.Range(0, clips.Length);
        audioSource.clip = clips[randomIndex];
        audioSource.Play();
    }

}
