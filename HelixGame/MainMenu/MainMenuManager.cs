using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public TextMeshProUGUI Txt_bestScore;
    public int CurrentBestScore;

    public GameObject OptionsPanel;
    public GameObject RuLangButton;
    public GameObject EnLangButton;
    public Slider VolumeSlider;

    public bool isOptionsOpen;

    public static float cVolume;
    
    private void Awake()
    {
        OptionsPanel.SetActive(false);
        isOptionsOpen = false;
        VolumeSlider.value = PlayerPrefs.GetFloat("VolumeSlider", 1f);
        AudioListener.volume = VolumeSlider.value;
        CurrentBestScore = PlayerPrefs.GetInt("BestScore", 0);
        BestScoreDisplay();
        

    }


    
    private void Update()
    {
        cVolume = VolumeSlider.value;
        
        if (isOptionsOpen == true)
        {
            VolumeChange();
        }
       
    }


    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void BestScoreDisplay()
    {
        Txt_bestScore.text = CurrentBestScore.ToString();
    }


    public void OptionsMenuOpen()
    {
        OptionsPanel.SetActive(true);
        isOptionsOpen = true;
    }

    public void OptionsMenuClose()
    {
        OptionsPanel.SetActive(false);
        isOptionsOpen = false;
    }


    public void VolumeChange()
    {
        AudioListener.volume = VolumeSlider.value;
        PlayerPrefs.SetFloat("VolumeSlider", VolumeSlider.value);
    }
    
    
 
}
