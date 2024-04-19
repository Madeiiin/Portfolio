using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    public GameObject AnswerABackBlue; // Default
    public GameObject AnswerABackGreen; // Correct
    public GameObject AnswerABackRed; // Wrong
    
    public GameObject AnswerBBackBlue; 
    public GameObject AnswerBBackGreen;
    public GameObject AnswerBBackRed; 
   
    public GameObject AnswerCBackBlue; 
    public GameObject AnswerCBackGreen;
    public GameObject AnswerCBackRed; 
   
    public GameObject AnswerDBackBlue; 
    public GameObject AnswerDBackGreen;
    public GameObject AnswerDBackRed;

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;

    public AudioSource CorrectFX;
    public AudioSource WrongFX;

    public GameObject CurrentScore;
    public int ScoreValue;
    public int BestScore;
    public GameObject BestDisplay;

    public GameObject QuestionImage;

    public GameObject LosePanel;
    public GameObject GamePanel;

    public bool _islose = false;

    public GameObject ScoreLosePanel;

    public int NumbersOfQuestions = 1;
    public GameObject NumbersOfQuestionsText;

    public GameObject Music;
    public GameObject MusicButton;
    public Sprite MusicSprite1;
    public Sprite MusicSprite2;
    public bool IsMusicOn = true;

    public GameObject PanelForAdvert;
    public GameObject PanelForAdvertText;
    public int TimerNumber;
    


    [DllImport("__Internal")]
    private static extern void ShowRewarded();
    
    void Start()
    {
        StartCoroutine(DoAdver());
        BestScore = PlayerPrefs.GetInt("BestScoreQuiz");
        BestDisplay.GetComponent<TextMeshProUGUI>().text = "BEST: " + BestScore;
        QuestionGenerate.DisplayingQuestion = false;
        

    }

    void Update()
    {
        CurrentScore.GetComponent<TextMeshProUGUI>().text = "Очки: " + ScoreValue;
    }

    public void AnswerA()
    {
        if (QuestionGenerate.ActualQuestion == "A")
        {
            AnswerABackGreen.SetActive(true);
            AnswerABackBlue.SetActive(false);
            CorrectFX.Play();
            ScoreValue += 5;
            NumbersOfQuestions++;
            NumbersOfQuestionsText.GetComponent<TextMeshProUGUI>().text = "Вопрос " + NumbersOfQuestions + "/100";
            
            StartCoroutine(NextQuestion());
        }
        else
        {
            AnswerABackRed.SetActive(true);
            AnswerABackBlue.SetActive(false);
            WrongFX.Play();
            ScoreOnLosePanel();

            _islose = true;
            LosePanel.SetActive(true);
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;

        
    }
    
    public void AnswerB()
    {
        if (QuestionGenerate.ActualQuestion == "B")
        {
            AnswerBBackGreen.SetActive(true);
            AnswerBBackBlue.SetActive(false);
            CorrectFX.Play();
            ScoreValue += 5;
            NumbersOfQuestions++;
            NumbersOfQuestionsText.GetComponent<TextMeshProUGUI>().text = "Вопрос " + NumbersOfQuestions + "/100";
            StartCoroutine(NextQuestion());

        }
        else
        {
            AnswerBBackRed.SetActive(true);
            AnswerBBackBlue.SetActive(false);
            WrongFX.Play();
            _islose = true;
            ScoreOnLosePanel();

            LosePanel.SetActive(true);
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        
      
    }
    
        public void AnswerC()
    {
        if (QuestionGenerate.ActualQuestion == "C")
        {
            AnswerCBackGreen.SetActive(true);
            AnswerCBackBlue.SetActive(false);
            CorrectFX.Play();
            ScoreValue += 5;
            NumbersOfQuestions++;
            if (NumbersOfQuestions < 61)
            {
                NumbersOfQuestionsText.GetComponent<TextMeshProUGUI>().text = "Вопрос " + NumbersOfQuestions + "/100"; 
            }
            else
            {
                NumbersOfQuestionsText.GetComponent<TextMeshProUGUI>().text = "Вопрос 60/60"; 
            }
            StartCoroutine(NextQuestion());
            
        }
        else
        {
            AnswerCBackRed.SetActive(true);
            AnswerCBackBlue.SetActive(false);
            WrongFX.Play();
            _islose = true;
            ScoreOnLosePanel();

            LosePanel.SetActive(true);
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        
       
    }
        
        public void AnswerD()
    {
        if (QuestionGenerate.ActualQuestion == "D")
        {
            AnswerDBackGreen.SetActive(true);
            AnswerDBackBlue.SetActive(false);
            CorrectFX.Play();
            ScoreValue += 5;
            NumbersOfQuestions++;
            NumbersOfQuestionsText.GetComponent<TextMeshProUGUI>().text = "Вопрос " + NumbersOfQuestions + "/100";
            StartCoroutine(NextQuestion());
        }
        else
        {
            AnswerDBackRed.SetActive(true);
            AnswerDBackBlue.SetActive(false);
            WrongFX.Play();
            _islose = true;

            ScoreOnLosePanel();
            LosePanel.SetActive(true);
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        
      
    }

        IEnumerator NextQuestion()
        {
            if (BestScore < ScoreValue)
            {
                PlayerPrefs.SetInt("BestScoreQuiz", ScoreValue);
                BestScore = ScoreValue;
                BestDisplay.GetComponent<TextMeshProUGUI>().text = "BEST: " + ScoreValue;
            }
            yield return new WaitForSeconds(0.4f);
            
            QuestionImage.SetActive(false);
            
            AnswerABackGreen.SetActive(false);
            AnswerBBackGreen.SetActive(false);
            AnswerCBackGreen.SetActive(false);
            AnswerDBackGreen.SetActive(false);
            
            AnswerABackRed.SetActive(false);
            AnswerBBackRed.SetActive(false);
            AnswerCBackRed.SetActive(false);
            AnswerDBackRed.SetActive(false);
            
            AnswerABackBlue.SetActive(true);
            AnswerBBackBlue.SetActive(true);
            AnswerCBackBlue.SetActive(true);
            AnswerDBackBlue.SetActive(true);

            answerA.GetComponent<Button>().enabled = true;
            answerB.GetComponent<Button>().enabled = true;
            answerC.GetComponent<Button>().enabled = true;
            answerD.GetComponent<Button>().enabled = true;

            QuestionGenerate.DisplayingQuestion = false;
        }

  

        public void Retry()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
        }

        
        public void ShowRewarded1()
        {
            DisableMusicAdver();
            ShowRewarded();
        }

        public void RetryForAdv()
        {
            LosePanel.SetActive(false);
            EnableMusicAdver();
            answerA.GetComponent<Button>().enabled = true;
            answerB.GetComponent<Button>().enabled = true;
            answerC.GetComponent<Button>().enabled = true;
            answerD.GetComponent<Button>().enabled = true;
            AnswerABackRed.SetActive(false);
            AnswerBBackRed.SetActive(false);
            AnswerCBackRed.SetActive(false);
            AnswerDBackRed.SetActive(false);
            
            AnswerABackBlue.SetActive(true);
            AnswerBBackBlue.SetActive(true);
            AnswerCBackBlue.SetActive(true);
            AnswerDBackBlue.SetActive(true);
        }



        public void ScoreOnLosePanel()
        {
            ScoreLosePanel.GetComponent<TextMeshProUGUI>().text = "Вы проиграли и набрали " + ScoreValue + " очков.";
        }



        public void DisableEnableMusic()
        {
            if (Music.GetComponent<AudioSource>().mute == true)
            {
                Music.GetComponent<AudioSource>().mute = false;
                MusicButton.GetComponent<Image>().sprite = MusicSprite1;
                IsMusicOn = true;
            }
            else
            {
                Music.GetComponent<AudioSource>().mute = true; 
                MusicButton.GetComponent<Image>().sprite = MusicSprite2;
                IsMusicOn = false;
            }
     
        }




        IEnumerator DoAdver()
        {
            for (;;)
            {
                yield return new WaitForSeconds(70);
                PanelForAdvertText.GetComponent<TextMeshProUGUI>().text = "Реклама появится через 3";
                yield return StartCoroutine(Timer());
                Yandex.ShowFullscreen1();
          
            }
        }


        IEnumerator Timer()
        {
            TimerNumber = 3;
            PanelForAdvert.SetActive(true);
                while (TimerNumber >= 0)
                {
                    yield return new WaitForSeconds(1);
                    PanelForAdvertText.GetComponent<TextMeshProUGUI>().text = "Реклама появится через " + TimerNumber;
                    TimerNumber--;
                }

        }

        
        
        public void DisableMusicAdver()
        {
            if (IsMusicOn == true)
            {
                Music.GetComponent<AudioSource>().mute = true; 
            }
            
        }
        
        public void EnableMusicAdver()
        {
            
            if (IsMusicOn == true)
            {
                Music.GetComponent<AudioSource>().mute = false;
            }
            PanelForAdvert.SetActive(false);
        }



        
        
}

