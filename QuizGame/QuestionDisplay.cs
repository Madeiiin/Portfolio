using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestionDisplay : MonoBehaviour
{
    [SerializeField] private GameObject _screenQuestion;
    [SerializeField] private GameObject _answerA;
    [SerializeField] private GameObject _answerB;
    [SerializeField] private GameObject _answerC;
    [SerializeField] private GameObject _answerD;

    public static string NewQuestion;
    public static string NewA;
    public static string NewB;
    public static string NewC;
    public static string NewD;

    public static bool UpdateQuestion = false;



    void Update()
    {
        if (UpdateQuestion == false)
        {
            UpdateQuestion = true;
            StartCoroutine(PushTextOnScreen());  
        }
    }

    IEnumerator PushTextOnScreen()
    {
        yield return new WaitForSeconds(0.25f);
        _screenQuestion.GetComponent<TextMeshProUGUI>().text = NewQuestion;
        _answerA.GetComponent<TextMeshProUGUI>().text = NewA;
        _answerB.GetComponent<TextMeshProUGUI>().text = NewB;
        _answerC.GetComponent<TextMeshProUGUI>().text = NewC;
        _answerD.GetComponent<TextMeshProUGUI>().text = NewD;
    }
    
}
