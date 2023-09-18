using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSet : MonoBehaviour
{
    
    public AudioMixer mixer;
    public Slider masterVol, musicVol;

    private void Start()
    {
        if (PlayerPrefs.HasKey("MasterVolume"))
        {
            mixer.SetFloat("MasterVolume", PlayerPrefs.GetFloat("MasterVolume"));
            mixer.SetFloat("MusicVolume", PlayerPrefs.GetFloat("MusicVolume"));  
            SetSliders();
        }
        else
        {
            SetSliders();
        }
    }

    public void SetVolumeMaster(float sliderValue)
    {
        mixer.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20);

    }

    public void SetVolumeMusic(float sliderValue)
    {
        mixer.SetFloat("MusicVolume", Mathf.Log10(sliderValue) * 20);

    }

    public void SetSliders()
    {
        masterVol.value = PlayerPrefs.GetFloat("MasterVolume");
        musicVol.value = PlayerPrefs.GetFloat("MusicVolume");

    }

    public void UpdateMasterVol()
    {
        mixer.SetFloat("MasterVolume", masterVol.value);
        PlayerPrefs.SetFloat("MasterVolume", masterVol.value);
    }

    public void UpdateMusicVol()
    {
        mixer.SetFloat("MusicVolume", musicVol.value);
        PlayerPrefs.SetFloat("MusicVolume", musicVol.value);
        
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        print("fullscreen toggle");
    }


}
