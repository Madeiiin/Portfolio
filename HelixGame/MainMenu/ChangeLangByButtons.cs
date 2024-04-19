using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public  class ChangeLangByButtons : MonoBehaviour
{
    public static Action OnChangeLanguage;



  


    public static void ChangeLangToRu()
    {
        if (Language.Instance.CurrentLanguage == "ru")
        {
            return;
        }
        else if (Language.Instance.CurrentLanguage == "en")
        {
            Debug.Log("Поменял язык на русский по кнопке");
            Language.Instance.CurrentLanguage = "ru";
          //  PlayerPrefs.SetString("Language", Language.Instance.CurrentLanguage);
            OnChangeLanguage?.Invoke();
        }
    }
       
    public static void ChangeLangToEn()
    {
        if (Language.Instance.CurrentLanguage == "en")
        {
            return;
        }
        else if (Language.Instance.CurrentLanguage == "ru")
        {
            Debug.Log("Поменял язык на английский по кнопке");
            Language.Instance.CurrentLanguage = "en";
          //  PlayerPrefs.SetString("Language", Language.Instance.CurrentLanguage);
            OnChangeLanguage?.Invoke();
        }
    }
}
