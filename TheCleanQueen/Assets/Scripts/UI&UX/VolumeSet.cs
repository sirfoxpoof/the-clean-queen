using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class VolumeSet : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider masterVol, musicVol, SFXVol;
    

    public void Start()
    {
        if (PlayerPrefs.HasKey("MasterVolume"))
        {
            mixer.SetFloat("MasterVolume", PlayerPrefs.GetFloat("MasterVolume"));
            mixer.SetFloat("MusicVolume", PlayerPrefs.GetFloat("MusicVolume"));
            mixer.SetFloat("SFXVolume", PlayerPrefs.GetFloat("SFXVolume"));

            masterVol.value = PlayerPrefs.GetFloat("MasterVolume");
            musicVol.value = PlayerPrefs.GetFloat("MusicVolume");
            SFXVol.value = PlayerPrefs.GetFloat("SFXVolume");
            
        }
        
        else
        {
            SetSliders();
        }
    }

    void SetSliders()
    {
        masterVol.value = 0.5f;
        musicVol.value = 0.5f;
        SFXVol.value = 0.5f;
    }


    public void SetVolumeMaster(float sliderValue)
     {
        mixer.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MasterVolume", masterVol.value);
     }

     public void SetVolumeMusic(float sliderValue)
     {
        mixer.SetFloat("MusicVolume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MusicVolume", musicVol.value);
     }

    public void SetSFXMusic(float sliderValue)
    {
        mixer.SetFloat("SFXVolume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("SFXVolume", SFXVol.value);
    }


    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
