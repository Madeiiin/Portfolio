using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool levelWin;

    public GameObject gameOverPanel;
    public GameObject WinPanel;

    public static int CurrentLevelIndex;
    public static int noOfPassingRings;

    public TextMeshProUGUI currentLevelText;
    public TextMeshProUGUI nextLevelText;

    public Slider ProgressBar;

    public static int CurrentScore;
    public static int ScoreOnLevelStart;
    public static int BestScore;
    public TextMeshProUGUI CurrentScoreText;

    
    public static float CurrentVolume;


    [DllImport("__Internal")]
    private static extern void ShowRewarded();
    
    
    [DllImport("__Internal")]
    private static extern void ShowFullscreen();


    public GameObject PanelForAdv;


    private bool isgameendad;
    
    
    private void Awake()
    {
        CurrentLevelIndex = PlayerPrefs.GetInt("CurrentLevelIndex", 1);
        CurrentScore = PlayerPrefs.GetInt("CurrentScore", 0);
        BestScore = PlayerPrefs.GetInt("BestScore", 0);

    }


  


    private void Start()
    {
        Time.timeScale = 1f;
   
        noOfPassingRings = 0;
        ScoreOnLevelStart = CurrentScore;
        gameOver = false;
        levelWin = false;
      
    }

    private void Update()
    {
        
        if (gameOver) 
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
       

        }

        currentLevelText.text = CurrentLevelIndex.ToString();
        nextLevelText.text = (CurrentLevelIndex + 1).ToString();

        
        
        // Обновление слайдера
        int progress = noOfPassingRings * 100 / FindObjectOfType<HelixManager>().noOfRings;
        ProgressBar.value = progress;

        
        //Обновление текста
        ScoreTextPanelUpdate();


        if (levelWin)
        {
            Time.timeScale = 0;
            WinPanel.SetActive(true);
            UpdateBestScore();
            PlayerPrefs.SetInt("CurrentScore", CurrentScore);
            PlayerPrefs.SetInt("CurrentLevelIndex", CurrentLevelIndex + 1);
            PlayerPrefs.SetInt("BestScore", BestScore);
            isgameendad = true;
        }
    }


    public void NextLevel()
    {
      //  Yandex.ShowFullscreen1();
      SceneManager.LoadScene(1);
    }
    
    
    public void PauseOnAdvert()
    {
        Time.timeScale = 0;
    }
    public void UnPauseOnAdvert()
    {
        Time.timeScale = 1;
    }
    public void ChangeSceneAfterShowAdver()
    {
       // SceneManager.LoadScene(1);
      
    }
    

    public void Retry()
    {
        ResfreshScore();
        PlayerPrefs.SetInt("CurrentScore", CurrentScore);
        PlayerPrefs.SetInt("CurrentLevelIndex", 1);
        SceneManager.LoadScene(1);

    }

    public void LoadHomeScene()
    {
        SceneManager.LoadScene(0);
    }
    
    public void LoadHomeSceneAfterLoose()
    {
        ResfreshScore();
        PlayerPrefs.SetInt("CurrentScore", CurrentScore);
        PlayerPrefs.SetInt("CurrentLevelIndex", 1);
        SceneManager.LoadScene(0);
    }

    public void ScoreTextPanelUpdate()
    {
       
        CurrentScoreText.GetComponent<TextMeshProUGUI>().text = CurrentScore.ToString();
    }

    public void ResfreshScore()
    {
        CurrentScore = 0;
    }

    public void UpdateBestScore()
    {
        if (CurrentScore > BestScore)
        {
            BestScore = CurrentScore;
        }
    }
    
    
    public void ShowRewarded1()
    {
        DisableMusicAdver();
        ShowRewarded();
    }
    public void RetryForAdv()
    {
        EnableMusicAdver();
        PlayerPrefs.SetInt("CurrentScore", ScoreOnLevelStart);
        PlayerPrefs.SetInt("CurrentLevelIndex", CurrentLevelIndex);
        PlayerPrefs.SetInt("BestScore", BestScore);
        SceneManager.LoadScene(1);
        
    }
    
    
 
 


    public  void DisableMusicAdver()
    {
     // CurrentVolume = MainMenuManager.cVolume;
     AudioListener.volume = 0;
    }

    public  void EnableMusicAdver()
    {
        AudioListener.volume =  PlayerPrefs.GetFloat("VolumeSlider", 1f);

        //  AudioListener.volume = CurrentVolume;
    }
    
  
    
    public void ShowPanelForAdv()
    {
        PanelForAdv.SetActive(true);
    }  
    
    public void HidePanelForAdv()
    {
        PanelForAdv.SetActive(false);
    }

}
