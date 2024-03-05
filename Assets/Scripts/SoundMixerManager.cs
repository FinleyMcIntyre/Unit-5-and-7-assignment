using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundMixerManager : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    public Slider sfxSlider;
    public Slider musicSlider;
    public Slider masterSlider;

    private void Start()
    {
        sfxSlider.value = SoundFXManager.instance.sfxVol;
        musicSlider.value = SoundFXManager.instance.musicVol;
        masterSlider.value = SoundFXManager.instance.masterVol;
        
    }

    public void SetMasterVolume(float level)
    {
        // audioMixer.SetFloat("MasterVolume", Mathf.Log10(level) * 20f);
        SoundFXManager.instance.masterVol = level;
    }

    public void SetMusicVolume(float leve)
    {
        //  audioMixer.SetFloat("MusicVolume", Mathf.Log10(level) * 20f);
        SoundFXManager.instance.musicVol = leve;
    }

    public void SetSoundFXVolume(float level)
    {
        //audioMixer.SetFloat("SoundEffectsVolume", Mathf.Log10(level) * 20f);
        SoundFXManager.instance.sfxVol = level;
    }

    private void Update()
    {
        audioMixer.SetFloat("MusicVolume", Mathf.Log10(musicSlider.value) * 20f);
        print("music vol=" + musicSlider.value );

        audioMixer.SetFloat("SoundEffectsVolume", Mathf.Log10(sfxSlider.value) * 20f);

        audioMixer.SetFloat("MasterVolume", Mathf.Log10(masterSlider.value) * 20f);

    }
}
