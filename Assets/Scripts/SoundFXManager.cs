using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXManager : MonoBehaviour
{
    public static SoundFXManager instance;
    [SerializeField] private AudioSource soundFXObject;
    [SerializeField] private AudioSource musicObject;

    public float musicVol, sfxVol, masterVol;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            musicVol = 0.5f;
            sfxVol = 0.5f;
            masterVol = 0.5f;

            print("reset volume vars");

        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySoundFXClip(AudioClip audioClip, Transform spawnTransform, float volume)
    {
        //spawan in gameobject 
        AudioSource audioSource = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);
        DontDestroyOnLoad(audioSource);


        //assign the audioclip
        audioSource.clip = audioClip;

        //assign the volume
        audioSource.volume = sfxVol;

        //play sound
        audioSource.Play();

        //get length of sound FX clip
        float clipLength = audioSource.clip.length;

        //destroy the clip after it is done playing
        Destroy(audioSource.gameObject, clipLength);

    }

    public void  PlayMusicClip(AudioClip audioClip, Transform spawnTransform, float volume)
    {
        //spawan in gameobject 
        AudioSource audioSource = Instantiate(musicObject, spawnTransform.position, Quaternion.identity);
        DontDestroyOnLoad(audioSource);


        //assign the audioclip
        audioSource.clip = audioClip;

        //assign the volume
        audioSource.volume = 1f;// musicVol;

        //play sound
        audioSource.Play();

        //get length of sound FX clip
        float clipLength = audioSource.clip.length;

        //destroy the clip after it is done playing
        Destroy(audioSource.gameObject, clipLength);

    }

    private void Update()
    {
        

        
        
    }
}
