using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private AudioClip buttonPress;
    [SerializeField] private AudioClip music;


   
    public void Start ()
    {
        SoundFXManager.instance.PlayMusicClip(music, transform, 1f);
    }
    public void PlayGame ()
    {
        SoundFXManager.instance.PlaySoundFXClip(buttonPress, transform, 1f);
        DontDestroyOnLoad(gameObject);
       
        SceneManager.LoadSceneAsync(2);
        
    }

    public void Options()
    {
        
        SoundFXManager.instance.PlaySoundFXClip(buttonPress, transform, 1f);
      

        //SceneManager.LoadSceneAsync(1);
        SceneManager.LoadScene(1);


    }


    public void Exit()
    {
        SoundFXManager.instance.PlaySoundFXClip(buttonPress, transform, 1f);
        
        SceneManager.LoadSceneAsync(0);
       
    }

    public void QuitGame()
    {
        SoundFXManager.instance.PlaySoundFXClip(buttonPress, transform, 1f);
        
        Application.Quit();
        
    }
}
