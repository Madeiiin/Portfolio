using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class Language : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern string GetLang();
    
    public string CurrentLanguage;

    
    public static Language Instance;

    private void Awake()
    {
       
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
            CurrentLanguage = GetLang(); // Получение языка из SDK
            //CurrentLanguage = "en"; // Получение языка БЕЗ СДК
            Debug.Log("Текущий язык Awake: " + CurrentLanguage);
           // PlayerPrefs.GetString("Language", CurrentLanguage);

        }
        else
        {
            Destroy(gameObject);
        }
        
        

    }



}
