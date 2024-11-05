using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //tao bien luu tru audio source
    public AudioSource musicAudioSource;
    public AudioSource vfxAudioSource;
    // tao bien luu tru audio Clip
    public AudioClip musicClip;
    public AudioClip coinClip;
    public AudioClip winClip;
    public AudioClip disappearClip;
    public AudioClip gunClip;

    void Start()
    {
        musicAudioSource.clip = musicClip;
        musicAudioSource.Play();
    }
    public void PlaySFX(AudioClip sfxClip)
    {
        vfxAudioSource.clip = sfxClip;
        vfxAudioSource.PlayOneShot(sfxClip);
    }


}
