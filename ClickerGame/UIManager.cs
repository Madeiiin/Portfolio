using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scorePanelTxt; // Текстовое поле счета
    [Space]
    [SerializeField] private GameObject _shopPanel; // Панель магазина
    [Space]
    [SerializeField] private TextMeshProUGUI CurLvlTxt;
    [SerializeField] private TextMeshProUGUI NxtLvlTxt;
    [SerializeField] private Slider _progressBar; // Прогресс уровня


    [SerializeField] private GameObject _PanelButtonShake;
    [SerializeField] private GameObject _particalSystem;
    [SerializeField] private GameObject _Shakebutton;

    public Sprite[] BackgroundsArray;
    public GameObject BackGroundObject;
    public TextMeshProUGUI BgPriceText;
    
    public int CurrentBackGround;
    public static int[] BackgroundPriceArray = {1000, 2000, 15000, 20000, 54000, 162000, 468000, 1458000, 4500000, 5000000, 6000000, 7000000};


  
    


    private bool _isShopOpen;

    
    private void OnEnable()
    {
        CoinsManaager.OnCoinChange += ScoreTextUpdate;
      //  CoinsManaager.OnCoinChange += UpdateProgressScore;
     

        LevelProgress.OnLevelChanged += UpdateLvlIndex;
    }

    private void OnDisable()
    {
        CoinsManaager.OnCoinChange -= ScoreTextUpdate;
      ///  CoinsManaager.OnCoinChange -= UpdateProgressScore;


        LevelProgress.OnLevelChanged -= UpdateLvlIndex;
    }

    private void Awake()
    {


        CurrentBackGround =  PlayerPrefs.GetInt("CurrentBackGround", 0);
        BackGroundObject.GetComponent<Image>().sprite = BackgroundsArray[CurrentBackGround];
        BgPriceText.text = BackgroundPriceArray[CurrentBackGround].ToString();
    }

    private void Start()
    {
        
        _isShopOpen = false;
        
        CurLvlTxt.text = LevelProgress.CurrentLvlIndex.ToString();
        NxtLvlTxt.text = LevelProgress.NextLvlIndex.ToString();
        _progressBar.value = PlayerPrefs.GetFloat("UIProgressBar", 0);
        _scorePanelTxt.text = CoinsManaager._coins.ToString();
    }






    private void ScoreTextUpdate(int _scoreToAdd)
    {
        _scorePanelTxt.text = _scoreToAdd.ToString();
    }


    public void ShopMenuOpenClose()
    {
        if (!_isShopOpen)
        {
            _shopPanel.SetActive(true);
            _isShopOpen = true;
            _PanelButtonShake.SetActive(false);
     
        }
        else if (_isShopOpen)
        {
            _shopPanel.SetActive(false);
            _isShopOpen = false;
            _PanelButtonShake.SetActive(true);
        }
    }


    public void UpdateLvlIndex(int CurLvl, int NxtLvl)
    {
        CurLvlTxt.text = CurLvl.ToString();
        NxtLvlTxt.text = NxtLvl.ToString();
        
    }

    public void UpdateProgressScore()
    {
        
        int CurLvlPoints = LevelProgress.LevelPoints[LevelProgress.CurrentLvlIndex - 1];
        int PointsMore = CurLvlPoints - LevelProgress.ProgressBarScore;
        _progressBar.value = LevelProgress.ProgressBarScore * 100 / CurLvlPoints;
        PlayerPrefs.SetFloat("UIProgressBar", _progressBar.value);
      
    }



    public void ShakeClickIU()
    {
        
        Instantiate(_particalSystem, _Shakebutton.GetComponent<RectTransform>().position.normalized, quaternion.identity);

    }
    
    public void ShakePointerDown()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            return;
        }
        else
        {
            _Shakebutton.GetComponent<RectTransform>().localScale = new Vector3(1f * 0.9f, 1f * 0.9f, 0f);
            _Shakebutton.GetComponent<Image>().color = new Color(0.7843137f, 0.7843137f, 0.7843137f, 1);
        }
     
      
    }

    public void ShakePointerUp()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            return;
        }

        else
        {
            _Shakebutton.GetComponent<RectTransform>().localScale = new Vector3(1f, 1f, 0f);
            _Shakebutton.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1);
        }
 
    }

    public void UpdateBackGround()
    {
        if (CoinsManaager._coins >= BackgroundPriceArray[CurrentBackGround] && CurrentBackGround <= BackgroundsArray.Length - 2 && CoinsManaager._coins > 0)
        {
            CoinsManaager._coins -= BackgroundPriceArray[CurrentBackGround];
            CurrentBackGround++;
            BackGroundObject.GetComponent<Image>().sprite = BackgroundsArray[CurrentBackGround];
            PlayerPrefs.SetInt("CurrentBackGround", CurrentBackGround);
            BgPriceText.text = BackgroundPriceArray[CurrentBackGround].ToString();
           
            ScoreTextUpdate(CoinsManaager._coins);
        }
        else if (CurrentBackGround + 1 >= BackgroundsArray.Length  && CoinsManaager._coins > 0)
        {
            CoinsManaager._coins -= BackgroundPriceArray[CurrentBackGround];
            CurrentBackGround = 0;
            BackGroundObject.GetComponent<Image>().sprite = BackgroundsArray[CurrentBackGround];
            PlayerPrefs.SetInt("CurrentBackGround", CurrentBackGround);
            BgPriceText.text = BackgroundPriceArray[CurrentBackGround].ToString();
            //CurrentBackGround++;
            ScoreTextUpdate(CoinsManaager._coins);
        
          //  Debug.Log("Вы купили все фоны.");
        }
        else
        {
            //Debug.Log("Сэр, у вас нет денег!");
        }

    }


 
    
    
    

    private void OnApplicationQuit()
    {
       
    }
}
