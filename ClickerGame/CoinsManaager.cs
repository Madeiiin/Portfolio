using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CoinsManaager : MonoBehaviour
{
    public static int _coins;

    public int _numberCoinsClick;
    public GameObject[] ClicksShop_PanelArray;
    public int panel_id;

    public int panel0;
    public int panel1;
    public int panel2;
    public int panel3;
    public int panel4;
    public int panel5;


    public GameObject AudioManager;


    public GameObject BackgroundMusicObject;
    public GameObject MusicButton;
    public Sprite UnMuteButton;
    public Sprite MuteButton;
    public bool isMuted;



    public GameObject AdButton;
    
    
    public static Action<int> OnCoinChange;

    

    [DllImport("__Internal")]
    private static extern void ShowRewarded();
    
    
    [DllImport("__Internal")]
    private static extern void ShowFullscreen();
    
    private void Awake()
    {
        //PlayerPrefs.DeleteAll();

        _coins = PlayerPrefs.GetInt("Coins", 0);
        //_coins = 1000000000;
        _numberCoinsClick = PlayerPrefs.GetInt("_numberCoinsClick", 5);

        panel0 = PlayerPrefs.GetInt("Panel0", 0);
            panel1 = PlayerPrefs.GetInt("Panel1", 0);
        panel2 = PlayerPrefs.GetInt("Panel2", 0);
            panel3 = PlayerPrefs.GetInt("Panel3", 0);
        panel4 = PlayerPrefs.GetInt("Panel4", 0);
            panel5 = PlayerPrefs.GetInt("Panel5", 0);
        

        
        
    }
    
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void OnBeforeSceneLoadRuntimeMethod()
    {
        Adver.ShowFullscreen1();
    }

    private void Start()
    {

        isMuted = false;
        DisplayBoughtElements();
        
        
        
     
    }


    public void GrimasaClicked()
    {
        _coins += _numberCoinsClick;
        AudioManager.GetComponent<AudioSource>().Play();

        PlayerPrefs.SetInt("Coins", _coins);
        OnCoinChange?.Invoke(_coins);
    }


    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("Coins", _coins);
    }



    public void buyClick(int price)
    {
        if (_coins > 0 && _coins >= price)
        {
            if (price == 500)
            {
                panel_id = 0;
                _numberCoinsClick += 5;
                PlayerPrefs.SetInt("Panel0", 1);
            }

            else if (price == 1500)
            {
                panel_id = 1;
                _numberCoinsClick += 10;
                PlayerPrefs.SetInt("Panel1", 1);
            }
            else if (price == 4500)
            {
                panel_id = 2;
                _numberCoinsClick += 20;
                PlayerPrefs.SetInt("Panel2", 1);
            }
            else if (price == 13500)
            {
                panel_id = 3;
                _numberCoinsClick += 30;
                PlayerPrefs.SetInt("Panel3", 1);
            }
            else if (price == 40500)
            {
                panel_id = 4;
                _numberCoinsClick += 50;
                PlayerPrefs.SetInt("Panel4", 1);
            }
            else if (price == 121500)
            {
                panel_id = 5;
                _numberCoinsClick += 100;
                PlayerPrefs.SetInt("Panel5", 1);
            }
            
            


            ClicksShop_PanelArray[panel_id].SetActive(true);
            _coins -= price;
            OnCoinChange?.Invoke(_coins);
            PlayerPrefs.SetInt("Coins",   _coins);
            PlayerPrefs.SetInt("_numberCoinsClick",   _numberCoinsClick);
        }
    
    }


    
    

    public void DisplayBoughtElements()
    {
        
        
        
        if (panel0 == 1)
        {
            ClicksShop_PanelArray[0].SetActive(true);
        }
        if (panel1 == 1)
        {
            ClicksShop_PanelArray[1].SetActive(true);
        }
        if (panel2 == 1)
        {
            ClicksShop_PanelArray[2].SetActive(true);
        }
        if (panel3 == 1)
        {
            ClicksShop_PanelArray[3].SetActive(true);
        }
        if (panel4 == 1)
        {
            ClicksShop_PanelArray[4].SetActive(true);
        }
        if (panel5 == 1)
        {
            ClicksShop_PanelArray[5].SetActive(true);
        }
    }





    public void MuteUnMuteMusic()
    {
        if (isMuted == true)
        {
            MusicButton.GetComponent<Image>().sprite = MuteButton;
            BackgroundMusicObject.GetComponent<AudioSource>().mute = false;
            isMuted = false;
        }
        else if (isMuted == false)
        {
            MusicButton.GetComponent<Image>().sprite = UnMuteButton;
            BackgroundMusicObject.GetComponent<AudioSource>().mute = true;
            isMuted = true;
        }
     
    }

    
    

 
    public void ShowRewarded1()
    {
        DisableMusicAdver();
        Time.timeScale = 0;
        ShowRewarded();
    }
    public void AdDoubleCoins()
    {
        Time.timeScale = 1;
        EnableMusicAdver();
        _coins += 5000;
        OnCoinChange?.Invoke(_coins);
        PlayerPrefs.SetInt("Coins",   _coins);
      
    }

  
    
    
    public void DisableMusicAdver()
    {
        AudioListener.volume = 0;
        
    }

    public void EnableMusicAdver()
    {
        AudioListener.volume = 1;
        
    }


    
    
    

}
