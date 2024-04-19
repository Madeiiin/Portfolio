using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Yandex : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowFullscreen();

    public static float CurrentVolume;
    
    private AudioManager audioManager;
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }


    public static void ShowFullscreen1()
    {
        ShowFullscreen();
    }


    
    
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void OnBeforeSceneLoadRuntimeMethod()
    {
      //  ShowFullscreen1();
    }
    
    
    
    
    /*public static void DisableMusicAdver()
    {
        Debug.Log("Вырубаю музыку по причине реклама");
        CurrentVolume = AudioListener.volume;
        AudioListener.volume = 0;
    }

    public static void EnableMusicAdver()
    {
 
        Debug.Log("ВКЛЮЧАЮ музыку по причине реклама");
        Debug.Log("Текущая громкость - " + CurrentVolume.ToString());

  
        AudioListener.volume = CurrentVolume;
    }*/
    
    
    
}
