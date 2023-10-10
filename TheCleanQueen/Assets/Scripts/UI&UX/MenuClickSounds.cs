using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuClickSounds : MonoBehaviour
{
    public AudioClip[] audioClickClips, audioPaperClips;

    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ClickSound()
    {
        AudioClip clip = GetRandomClipClick();
        audioSource.PlayOneShot(clip);
    }

    public AudioClip GetRandomClipClick()
    {
        return audioClickClips[UnityEngine.Random.Range(0, audioClickClips.Length)];
    }


    public void PaperTurn()
    {
        AudioClip clip = GetRandomClipPaper();
        audioSource.PlayOneShot(clip);
    }

    public AudioClip GetRandomClipPaper()
    {
        return audioPaperClips[UnityEngine.Random.Range(0, audioPaperClips.Length)];
    }

}
