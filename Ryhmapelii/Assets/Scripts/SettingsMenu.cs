using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour {


   // [SerializeField]
   // Music MC;

                

    void Start ()
    {
       // MC = GameObject.Find("Canvas").GetCompoment<AudioSource>();
    }
    public AudioMixer audioMixer;
    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", Mathf.Log10(volume) * 80);
       
       // audioMixer.SetFloat("volume", Mathf.Log10(volume) * 80);
    }

    public void SetFullScreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
 
}
