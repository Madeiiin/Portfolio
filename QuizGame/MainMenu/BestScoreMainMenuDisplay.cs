using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BestScoreMainMenuDisplay : MonoBehaviour
{
    private int _bestScore;

    [SerializeField] private GameObject _bestScoreTextPane;
    
    private void Awake()
    {
        _bestScore = PlayerPrefs.GetInt("BestScoreQuiz");
        _bestScoreTextPane.GetComponent<TextMeshProUGUI>().text = "Ваш рекорд: " + _bestScore;
        
    }
}
