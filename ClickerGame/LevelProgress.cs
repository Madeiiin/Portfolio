using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgress : MonoBehaviour
{
    public static int CurrentLvlIndex;
    public static int NextLvlIndex;
    public static int ProgressBarScore;

    public static int[] LevelPoints = { 100, 200, 300, 400, 500, 500, 500, 500, 500, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 2000, 2000, 2000, 2000, 2000, 2000, 2000, 10000, 11000, 12000, 13000, 14000, 15000, 16000, 17000, 18000, 19000, 20000, 21000, 22000, 23000, 24000, 25000, 26000, 27000, 28000, 29000, 30000, 31000, 32000, 33000, 34000, 35000, 36000, 37000, 38000, 39000, 40000, 41000, 42000, 43000, 44000, 45000, 46000, 47000, 48000, 49000, 50000, 51000, 52000, 53000, 54000, 55000, 56000, 57000, 58000, 59000, 60000, 61000, 62000, 63000, 64000, 65000, 66000, 100000, 200000, 1000000}; // Счет для прохождения уровня

    public Sprite[] Characters;
    private Sprite CurrentSprite;
    public int CurrentSpriteIndex;
    public GameObject SpriteButton;
    
    public static Action<int, int> OnLevelChanged;


    private void Awake()
    {
  
        
        ProgressBarScore = PlayerPrefs.GetInt("ProgressBarScore", 0);
        CurrentLvlIndex = PlayerPrefs.GetInt("CurrentLvlIndex", 1);
        NextLvlIndex = PlayerPrefs.GetInt("NextLvlIndex", 2);
        CurrentSpriteIndex = PlayerPrefs.GetInt("CurrentSpriteIndex", 0);
      SpriteButton.GetComponent<Image>().sprite = Characters[CurrentSpriteIndex];

    }

   
    


    private void OnEnable()
    {
      //  CoinsManaager.OnCoinChange += ProgressOfProgressBar;
    }
    
    private void OnDisable()
    {
       //CoinsManaager.OnCoinChange -= ProgressOfProgressBar;
    }


    public void ProgressOfProgressBar ()
    {
       
      
        ProgressBarScore += 10;
        if (ProgressBarScore > LevelPoints[CurrentLvlIndex  - 1])
        {
            if (CurrentSpriteIndex < Characters.Length - 1)
            {
                CurrentSpriteIndex++;
              
            }
            else {CurrentSpriteIndex = 0;}

            CurrentLvlIndex++;
            NextLvlIndex++;
            OnLevelChanged?.Invoke(CurrentLvlIndex, NextLvlIndex);
            SpriteButton.GetComponent<Image>().sprite = Characters[CurrentSpriteIndex];
            ProgressBarScore = 0;
        
           
         
        }
        
       PlayerPrefs.SetInt("ProgressBarScore", ProgressBarScore);
       PlayerPrefs.SetInt("CurrentLvlIndex", CurrentLvlIndex);
       PlayerPrefs.SetInt("NextLvlIndex", NextLvlIndex);
       PlayerPrefs.SetInt("CurrentSpriteIndex", CurrentSpriteIndex);
    }

    
}
