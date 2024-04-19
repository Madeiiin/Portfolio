using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using Random = UnityEngine.Random;

public class QuestionGenerate : MonoBehaviour
{
    public static string ActualQuestion;
    public static bool DisplayingQuestion = false;

    public  int questionNumber = 0;
    public int questionLength = 100;
    public GameObject QuestionImage;
    public RawImage RawQuestionImage;
    public Texture[] QuestionImagesTextures = new Texture[100];

    public GameObject _endGamePanel;

  
    private AnswerButtons _answerButtons;
    private int _score;
    private GameObject Master;

    public GameObject EndGameTextPanel;
    public GameObject MusicCopy;
    

    private void Awake()
    {
        Master = GameObject.Find("MasterControl");
        MusicCopy.GetComponent<AudioSource>().mute = false;
    }

    void Start()
    {
        QuestionImage.SetActive(false);
        
        _answerButtons = Master.GetComponent<AnswerButtons>();
        
    }

    void Update()
    {
        if (DisplayingQuestion == false)
        {
            Debug.Log("Включаю отображение вопроса");
            DisplayingQuestion = true;
            //questionNumber = Random.Range(0, 5);

     
            
            if (questionNumber == 0)
            {
                QuestionDisplay.NewQuestion = "Кто изображен на картинке?";
                RawQuestionImage.texture = QuestionImagesTextures[0];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Скибиди туалет";
                QuestionDisplay.NewB = "Камерамен";
                QuestionDisplay.NewC = "Твмен";
                QuestionDisplay.NewD = "Хаги-ваги";
                ActualQuestion = "A";
            }
            if (questionNumber == 1)
            {
                QuestionDisplay.NewQuestion = "В каком году появился феномен Скибиди туалет?";
                RawQuestionImage.texture = QuestionImagesTextures[1];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "2013";
                QuestionDisplay.NewB = "2015";
                QuestionDisplay.NewC = "2023";
                QuestionDisplay.NewD = "1999";
                ActualQuestion = "C";
            }
            if (questionNumber == 2)
            {
                QuestionDisplay.NewQuestion = "Кто изображен на картинке?";
                RawQuestionImage.texture = QuestionImagesTextures[2];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Скибидист";
                QuestionDisplay.NewB = "Вантузмен";
                QuestionDisplay.NewC = "Камерамен титан";
                QuestionDisplay.NewD = "Обычный камерамен";
                ActualQuestion = "C";
            }
            if (questionNumber == 3)
            {
                QuestionDisplay.NewQuestion = "Из какого предмета выглядывают Скибидисты?";
                RawQuestionImage.texture = QuestionImagesTextures[3];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Коробка";
                QuestionDisplay.NewB = "Туалет";
                QuestionDisplay.NewC = "Холодильник";
                QuestionDisplay.NewD = "Кружка";
                ActualQuestion = "B";
            }
            if (questionNumber == 4)
            {
                QuestionDisplay.NewQuestion = "В скольких сериях появлялся полицейский Скибиди туалет?";
                RawQuestionImage.texture = QuestionImagesTextures[4];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "0-10";
                QuestionDisplay.NewB = "20-30";
                QuestionDisplay.NewC = "30-40";
                QuestionDisplay.NewD = "Во всех";
                ActualQuestion = "A";
            }
            if (questionNumber == 5)
            {
                QuestionDisplay.NewQuestion = "На чем передвигаются Скибидисты?";
                RawQuestionImage.texture = QuestionImagesTextures[5];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Машина";
                QuestionDisplay.NewB = "На ногах";
                QuestionDisplay.NewC = "Туалет";
                QuestionDisplay.NewD = "Они не передвигаются";
                ActualQuestion = "C";
            }
            if (questionNumber == 6)
            {
                QuestionDisplay.NewQuestion = "Сколько Скибидистов было во второй серии?";
                RawQuestionImage.texture = QuestionImagesTextures[6];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "0";
                QuestionDisplay.NewB = "1";
                QuestionDisplay.NewC = "2";
                QuestionDisplay.NewD = "3";
                ActualQuestion = "D";
            }
            if (questionNumber == 7)
            {
                QuestionDisplay.NewQuestion = "После скольких серий был выпущен первый сезон?";
                RawQuestionImage.texture = QuestionImagesTextures[7];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "5";
                QuestionDisplay.NewB = "1";
                QuestionDisplay.NewC = "2";
                QuestionDisplay.NewD = "3";
                ActualQuestion = "A";
            }
            if (questionNumber == 8)
            {
                QuestionDisplay.NewQuestion = "Назовите место действия шестой серии";
                RawQuestionImage.texture = QuestionImagesTextures[8];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Парк";
                QuestionDisplay.NewB = "Метро";
                QuestionDisplay.NewC = "Танцпол";
                QuestionDisplay.NewD = "Библиотека";
                ActualQuestion = "C";
            }
            if (questionNumber == 9)
            {
                QuestionDisplay.NewQuestion = "На что была отсылка в 9 серии?";
                RawQuestionImage.texture = QuestionImagesTextures[9];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "'Властелин колец'";
                QuestionDisplay.NewB = "'Трансформеры'";
                QuestionDisplay.NewC = "'Стражи галактики'";
                QuestionDisplay.NewD = "'Звездные войны'";
                ActualQuestion = "D";
            }
            if (questionNumber == 10)
            {
                QuestionDisplay.NewQuestion = "Какая музыка характерна для Скибиди вселенной?";
                RawQuestionImage.texture = QuestionImagesTextures[10];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Скибиди доп доп";
                QuestionDisplay.NewB = "Рок";
                QuestionDisplay.NewC = "Русский реп";
                QuestionDisplay.NewD = "Классисческая музыка";
                ActualQuestion = "A";
            }
            if (questionNumber == 11)
            {
                QuestionDisplay.NewQuestion = "В какой локации происходят действия 4 серии?";
                RawQuestionImage.texture = QuestionImagesTextures[11];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Больница";
                QuestionDisplay.NewB = "Частный дом";
                QuestionDisplay.NewC = "Ресторан";
                QuestionDisplay.NewD = "Парк развлечений";
                ActualQuestion = "C";
            }
            if (questionNumber == 12)
            {
                QuestionDisplay.NewQuestion = "Сколько персонажей из вселенной 'Half-life' было в 7 серии?";
                RawQuestionImage.texture = QuestionImagesTextures[12];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "0";
                QuestionDisplay.NewB = "2";
                QuestionDisplay.NewC = "1";
                QuestionDisplay.NewD = "3";
                ActualQuestion = "D";
            }
            if (questionNumber == 13)
            {
                QuestionDisplay.NewQuestion = "Какая отличительная особенность Скибидистов?";
                RawQuestionImage.texture = QuestionImagesTextures[13];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Длинные ноги";
                QuestionDisplay.NewB = "10 пальцев";
                QuestionDisplay.NewC = "Лицевая анимация";
                QuestionDisplay.NewD = "Две головы";
                ActualQuestion = "C";
            }
            if (questionNumber == 14)
            {
                QuestionDisplay.NewQuestion = "Какое название канала у автора роликов про Скибиди туалеты?";
                RawQuestionImage.texture = QuestionImagesTextures[14];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Foip?13";
                QuestionDisplay.NewB = "DaFuq!?Boom!";
                QuestionDisplay.NewC = "OKeds!?fo!";
                QuestionDisplay.NewD = "Nodlpeas";
                ActualQuestion = "B";
            }
            if (questionNumber == 15)
            {
                QuestionDisplay.NewQuestion = "Какая достопримечательность была показана в 9 серии?";
                RawQuestionImage.texture = QuestionImagesTextures[15];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Золотой туалет";
                QuestionDisplay.NewB = "Легендарный скибидист";
                QuestionDisplay.NewC = "Мудрое дерево";
                QuestionDisplay.NewD = "Золотая раковина";
                ActualQuestion = "A";
            }
            if (questionNumber == 16)
            {
                QuestionDisplay.NewQuestion = "Что будет, если сильно подкинуть Скибидиста?";
                RawQuestionImage.texture = QuestionImagesTextures[16];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Ничего";
                QuestionDisplay.NewB = "Он станет сильнее";
                QuestionDisplay.NewC = "Он станет слабее";
                QuestionDisplay.NewD = "Он взорвется";
                ActualQuestion = "D";
            }
            if (questionNumber == 17)
            {
                QuestionDisplay.NewQuestion = "Какого цвета лазер из глаз у Скибиди Джимена";
                RawQuestionImage.texture = QuestionImagesTextures[17];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Желтый";
                QuestionDisplay.NewB = "Розовый";
                QuestionDisplay.NewC = "Синий";
                QuestionDisplay.NewD = "Пурпурный";
                ActualQuestion = "A";
            }
            if (questionNumber == 18)
            {
                QuestionDisplay.NewQuestion = "Между кем был бой в 8 серии?";
                RawQuestionImage.texture = QuestionImagesTextures[18];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Люди и зомби";
                QuestionDisplay.NewB = "Скибидисты и Камерамены";
                QuestionDisplay.NewC = "Вампиры и оборотни";
                QuestionDisplay.NewD = "Оборотни и гномики";
                ActualQuestion = "B";
            }
            if (questionNumber == 19)
            {
                QuestionDisplay.NewQuestion = "Сколько типов противников у Скибидистов?";
                RawQuestionImage.texture = QuestionImagesTextures[19];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "22";
                QuestionDisplay.NewB = "13";
                QuestionDisplay.NewC = "2";
                QuestionDisplay.NewD = "4";
                ActualQuestion = "D";
            }
            if (questionNumber == 20)
            {
                QuestionDisplay.NewQuestion = "Что сделали с большим Скибидистом в 10 серии?";
                RawQuestionImage.texture = QuestionImagesTextures[20];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Смыли";
                QuestionDisplay.NewB = "Захватили";
                QuestionDisplay.NewC = "Поблагодарили";
                QuestionDisplay.NewD = "Оскорбили";
                ActualQuestion = "A";
            }
            if (questionNumber == 21)
            {
                QuestionDisplay.NewQuestion = "Является ли Скибиди туалет самым популярным роликом на канале автора?";
                RawQuestionImage.texture = QuestionImagesTextures[21];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Нет";
                QuestionDisplay.NewB = "Да";
                QuestionDisplay.NewC = "На канале только скибиди ролики";
                QuestionDisplay.NewD = "На канале нет скибиди роликов";
                ActualQuestion = "A";
            }
            if (questionNumber == 22)
            {
                QuestionDisplay.NewQuestion = "Отсылка на какого персонажа из игры 'Half-life' изображена на картинке?";
                RawQuestionImage.texture = QuestionImagesTextures[22];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Зомби";
                QuestionDisplay.NewB = "Хедкраб";
                QuestionDisplay.NewC = "Солдат Альянса";
                QuestionDisplay.NewD = "Страйдер";
                ActualQuestion = "D";
            }
            if (questionNumber == 23)
            {
                QuestionDisplay.NewQuestion = "Что было у одного из Скибидистов на голове в 11 серии?";
                RawQuestionImage.texture = QuestionImagesTextures[23];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Арбуз";
                QuestionDisplay.NewB = "Рога";
                QuestionDisplay.NewC = "Шапка";
                QuestionDisplay.NewD = "Котелок";
                ActualQuestion = "B";
            }
            if (questionNumber == 24)
            {
                QuestionDisplay.NewQuestion = "Кто изображен на картинке?";
                RawQuestionImage.texture = QuestionImagesTextures[24];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Рокет Скибиди туалет";
                QuestionDisplay.NewB = "Камерамен";
                QuestionDisplay.NewC = "Обычный Скибиди туалет";
                QuestionDisplay.NewD = "Футбольный мячик";
                ActualQuestion = "A";
            }
            if (questionNumber == 25)
            {
                QuestionDisplay.NewQuestion = "Чем автор пытался напугать зрителей в 7 серии?";
                RawQuestionImage.texture = QuestionImagesTextures[25];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Скибидистом";
                QuestionDisplay.NewB = "Твменом";
                QuestionDisplay.NewC = "Монстром";
                QuestionDisplay.NewD = "Призраком";
                ActualQuestion = "A";
            }
            if (questionNumber == 26)
            {
                QuestionDisplay.NewQuestion = "Что написано на детонаторе у Камерамена?";
                RawQuestionImage.texture = QuestionImagesTextures[26];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "ABOBA BOY";
                QuestionDisplay.NewB = "BABA BOOEY";
                QuestionDisplay.NewC = "BEBRA BEY";
                QuestionDisplay.NewD = "BOBA BOEY";
                ActualQuestion = "B";
            }
            if (questionNumber == 27)
            {
                QuestionDisplay.NewQuestion = "Что случилось с Камераменом в 15 серии?";
                RawQuestionImage.texture = QuestionImagesTextures[27];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Он научился летать";
                QuestionDisplay.NewB = "Он залез по стене";
                QuestionDisplay.NewC = "Его толкнул Скибидист";
                QuestionDisplay.NewD = "Ничего";
                ActualQuestion = "C";
            }
            if (questionNumber == 28)
            {
                QuestionDisplay.NewQuestion = "Для чего Камерамены используют это устройство?";
                RawQuestionImage.texture = QuestionImagesTextures[28];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Для разведки";
                QuestionDisplay.NewB = "Для развлечения";
                QuestionDisplay.NewC = "Для уборки территории";
                QuestionDisplay.NewD = "Для отправки в космос";
                ActualQuestion = "A";
            }
            if (questionNumber == 29)
            {
                QuestionDisplay.NewQuestion = "Что было на голове у большого Скибидиста в 10 серии?";
                RawQuestionImage.texture = QuestionImagesTextures[29];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Шляпа";
                QuestionDisplay.NewB = "Шапка";
                QuestionDisplay.NewC = "Нимб";
                QuestionDisplay.NewD = "Конус";
                ActualQuestion = "C";
            }
            if (questionNumber == 30)
            {
                QuestionDisplay.NewQuestion = "Сколько существует сезонов Скибиди туалета?";
                RawQuestionImage.texture = QuestionImagesTextures[30];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "17";
                QuestionDisplay.NewB = "4";
                QuestionDisplay.NewC = "2";
                QuestionDisplay.NewD = "45";
                ActualQuestion = "A";
            }
            if (questionNumber == 31)
            {
                QuestionDisplay.NewQuestion = "Что за устройство в руке у Камерамена?";
                RawQuestionImage.texture = QuestionImagesTextures[31];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Телефон";
                QuestionDisplay.NewB = "Планшет";
                QuestionDisplay.NewC = "Ноутбук";
                QuestionDisplay.NewD = "Компьютер";
                ActualQuestion = "B";
            }
            if (questionNumber == 32)
            {
                QuestionDisplay.NewQuestion = "Отсылка на какую игру изображена на картинке?";
                RawQuestionImage.texture = QuestionImagesTextures[32];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "'Counter-Strike'";
                QuestionDisplay.NewB = "'Serious Sam'";
                QuestionDisplay.NewC = "'Death Stranding'";
                QuestionDisplay.NewD = "'Dota 2'";
                ActualQuestion = "A";
            }
            if (questionNumber == 33)
            {
                QuestionDisplay.NewQuestion = "Какой Скибиди туалет громче всех поет?";
                RawQuestionImage.texture = QuestionImagesTextures[33];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Обычный Скибидист";
                QuestionDisplay.NewB = "Большой Скибидист";
                QuestionDisplay.NewC = "Полицейский туалет Скибиди";
                QuestionDisplay.NewD = "Не имеет значения";
                ActualQuestion = "D";
            }
            if (questionNumber == 34)
            {
                QuestionDisplay.NewQuestion = "Укажите какого типа атаки НЕТ у Скибидистов";
                RawQuestionImage.texture = QuestionImagesTextures[34];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Пожирание";
                QuestionDisplay.NewB = "Ковровая бомбардировка";
                QuestionDisplay.NewC = "Разрушение";
                QuestionDisplay.NewD = "Всасывание";
                ActualQuestion = "B";
            }
            if (questionNumber == 35)
            {
                QuestionDisplay.NewQuestion = "Какую шею имеют Скибидисты?";
                RawQuestionImage.texture = QuestionImagesTextures[35];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Маленькую";
                QuestionDisplay.NewB = "Обычную";
                QuestionDisplay.NewC = "Длинную";
                QuestionDisplay.NewD = "Нет шеи";
                ActualQuestion = "C";
            }
            if (questionNumber == 36)
            {
                QuestionDisplay.NewQuestion = "Назовите отличительную особенность беспилотных Скибиди туалетов";
                RawQuestionImage.texture = QuestionImagesTextures[36];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Солнцезащитные очки";
                QuestionDisplay.NewB = "Перчатки";
                QuestionDisplay.NewC = "Сланцы";
                QuestionDisplay.NewD = "Зонтик";
                ActualQuestion = "A";
            }
            if (questionNumber == 37)
            {
                QuestionDisplay.NewQuestion = "Какой формы вакуумный Скибидист?";
                RawQuestionImage.texture = QuestionImagesTextures[37];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Квадрат";
                QuestionDisplay.NewB = "Прямоугольный треугольник";
                QuestionDisplay.NewC = "Овал";
                QuestionDisplay.NewD = "Круг";
                ActualQuestion = "B";
            }
            if (questionNumber == 38)
            {
                QuestionDisplay.NewQuestion = "Как называется трехместный Скибиди туалет?";
                RawQuestionImage.texture = QuestionImagesTextures[38];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Дуэт";
                QuestionDisplay.NewB = "Триплет";
                QuestionDisplay.NewC = "Квартет";
                QuestionDisplay.NewD = "Квинтет";
                ActualQuestion = "B";
            }
            if (questionNumber == 39)
            {
                QuestionDisplay.NewQuestion = "Какого цвета галстук у Скибиди мутанта?";
                RawQuestionImage.texture = QuestionImagesTextures[39];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Красного";
                QuestionDisplay.NewB = "Зеленого";
                QuestionDisplay.NewC = "Синего";
                QuestionDisplay.NewD = "Фиолетового";
                ActualQuestion = "A";
            }
            if (questionNumber == 40)
            {
                QuestionDisplay.NewQuestion = "Назовите отличительную особенность огнедышащих Скибидистов";
                RawQuestionImage.texture = QuestionImagesTextures[40];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Корпус из черного металла и атаки огнем";
                QuestionDisplay.NewB = "Корпус из золота";
                QuestionDisplay.NewC = "Отствутвие кнопки смыва";
                QuestionDisplay.NewD = "Возможность дышать под водой";
                ActualQuestion = "A";
            }
            if (questionNumber == 41)
            {
                QuestionDisplay.NewQuestion = "Какое количество просмотров на самом популярном ролике автора?";
                RawQuestionImage.texture = QuestionImagesTextures[41];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "1-2м";
                QuestionDisplay.NewB = "3-10м";
                QuestionDisplay.NewC = "10-30м";
                QuestionDisplay.NewD = "30-100м";
                ActualQuestion = "D";
            }
            if (questionNumber == 42)
            {
                QuestionDisplay.NewQuestion = "Сколько видео в плейлисте 'Skibidi Toilet Series'(Август 2023)?";
                RawQuestionImage.texture = QuestionImagesTextures[42];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "1-10";
                QuestionDisplay.NewB = "10-20";
                QuestionDisplay.NewC = "30-40";
                QuestionDisplay.NewD = "40-100";
                ActualQuestion = "D";
            }
            if (questionNumber == 43)
            {
                QuestionDisplay.NewQuestion = "Укажите несуществующий способ уничтожения Скибидиста";
                RawQuestionImage.texture = QuestionImagesTextures[43];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Смывание";
                QuestionDisplay.NewB = "Выбрасывание";
                QuestionDisplay.NewC = "Солнечный удар";
                QuestionDisplay.NewD = "Самоуничтожение";
                ActualQuestion = "C";
            }
            if (questionNumber == 44)
            {
                QuestionDisplay.NewQuestion = "Как можно захватить разум Скибидистов?";
                RawQuestionImage.texture = QuestionImagesTextures[44];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "С помощью их же песни";
                QuestionDisplay.NewB = "Гипнозом";
                QuestionDisplay.NewC = "Никак";
                QuestionDisplay.NewD = "Телевизором прицепиться к затылку";
                ActualQuestion = "D";
            }
            if (questionNumber == 45)
            {
                QuestionDisplay.NewQuestion = "Как Скибидсты захватывают разум?";
                RawQuestionImage.texture = QuestionImagesTextures[45];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Маленький Скибидист на шее";
                QuestionDisplay.NewB = "Гипноз";
                QuestionDisplay.NewC = "Заклинание";
                QuestionDisplay.NewD = "За деньги";
                ActualQuestion = "A";
            }
            if (questionNumber == 46)
            {
                QuestionDisplay.NewQuestion = "Чем заканчивается каждая серия?";
                RawQuestionImage.texture = QuestionImagesTextures[46];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Веселым котиком";
                QuestionDisplay.NewB = "Песней";
                QuestionDisplay.NewC = "Страшным лицом";
                QuestionDisplay.NewD = "Скримером";
                ActualQuestion = "D";
            }
            if (questionNumber == 47)
            {
                QuestionDisplay.NewQuestion = "Сколько может существовать вариаций Скибидистов?";
                RawQuestionImage.texture = QuestionImagesTextures[47];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Пять";
                QuestionDisplay.NewB = "Бесконечно";
                QuestionDisplay.NewC = "Не больше 10";
                QuestionDisplay.NewD = "Больше 20";
                ActualQuestion = "B";
            }
            if (questionNumber == 48)
            {
                QuestionDisplay.NewQuestion = "Какой жест олицетворяет победу над Скибидистами?";
                RawQuestionImage.texture = QuestionImagesTextures[48];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Поднятый большой палец вверх";
                QuestionDisplay.NewB = "Танец из «Фортнайта»";
                QuestionDisplay.NewC = "Жест «Peace»";
                QuestionDisplay.NewD = "Большим пальцем вниз";
                ActualQuestion = "A";
            }
            if (questionNumber == 49)
            {
                QuestionDisplay.NewQuestion = "Какая защита есть у Скибидистов против твменов?";
                RawQuestionImage.texture = QuestionImagesTextures[49];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Бронированная маска";
                QuestionDisplay.NewB = "Закрытые глаза";
                QuestionDisplay.NewC = "Солнцезащитные очки";
                QuestionDisplay.NewD = "Быстрое перемещение";
                ActualQuestion = "C";
            }
            if (questionNumber == 50)
            {
                QuestionDisplay.NewQuestion = "Кто является главным противником Скибидистов";
                RawQuestionImage.texture = QuestionImagesTextures[50];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Камерамены";
                QuestionDisplay.NewB = "Сиреноголовый";
                QuestionDisplay.NewC = "Слендермен";
                QuestionDisplay.NewD = "Скелет";
                ActualQuestion = "A";
            }
            if (questionNumber == 51)
            {
                QuestionDisplay.NewQuestion = "Кто такие «Скибидисты?";
                RawQuestionImage.texture = QuestionImagesTextures[51];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Мутанты";
                QuestionDisplay.NewB = "Пришельцы";
                QuestionDisplay.NewC = "Призраки";
                QuestionDisplay.NewD = "Роботы";
                ActualQuestion = "B";
            }
            if (questionNumber == 52)
            {
                QuestionDisplay.NewQuestion = "Как можно победить Скибидиста?";
                RawQuestionImage.texture = QuestionImagesTextures[52];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Спеть с ним песню";
                QuestionDisplay.NewB = "Ударить";
                QuestionDisplay.NewC = "Нажать на кнопку «Смыть»";
                QuestionDisplay.NewD = "Убежать";
                ActualQuestion = "C";
            }
            if (questionNumber == 53)
            {
                QuestionDisplay.NewQuestion = "Какое оружие есть у Скибидистов?";
                RawQuestionImage.texture = QuestionImagesTextures[53];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Лазерные глаза";
                QuestionDisplay.NewB = "Пистолет";
                QuestionDisplay.NewC = "Нож";
                QuestionDisplay.NewD = "Громкий крик";
                ActualQuestion = "A";
            }
            if (questionNumber == 54)
            {
                QuestionDisplay.NewQuestion = "Какой самый сильный противник Скибидистов?";
                RawQuestionImage.texture = QuestionImagesTextures[54];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Колонкамен";
                QuestionDisplay.NewB = "ТВмен";
                QuestionDisplay.NewC = "Камерамен";
                QuestionDisplay.NewD = "Обычные солдаты";
                ActualQuestion = "B";
            }
            if (questionNumber == 55)
            {
                QuestionDisplay.NewQuestion = "Могут ли Скибидисты захватывать разум других персонажей?";
                RawQuestionImage.texture = QuestionImagesTextures[55];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Да";
                QuestionDisplay.NewB = "Нет";
                QuestionDisplay.NewC = "Могут краткосрочно";
                QuestionDisplay.NewD = "Могут навсегда";
                ActualQuestion = "A";
            }
            if (questionNumber == 56)
            {
                QuestionDisplay.NewQuestion = "Как можно освободить человека от Скибидиста внутри?";
                RawQuestionImage.texture = QuestionImagesTextures[56];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Танцами";
                QuestionDisplay.NewB = "Песней «Скибиди»";
                QuestionDisplay.NewC = "Лекарством";
                QuestionDisplay.NewD = "Синим лазером камероменов";
                ActualQuestion = "D";
            }
            if (questionNumber == 57)
            {
                QuestionDisplay.NewQuestion = "Чем можно  загипнотизировать Скибидистов?";
                RawQuestionImage.texture = QuestionImagesTextures[57];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Заклинанием";
                QuestionDisplay.NewB = "Свечением из экрана ТВмена";
                QuestionDisplay.NewC = "Громкой музыкой";
                QuestionDisplay.NewD = "Танцем";
                ActualQuestion = "B";
            }
            if (questionNumber == 58)
            {
                QuestionDisplay.NewQuestion = "Где происходят основные действия вторжения?";
                RawQuestionImage.texture = QuestionImagesTextures[58];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "В городе";
                QuestionDisplay.NewB = "В космосе";
                QuestionDisplay.NewC = "В горах";
                QuestionDisplay.NewD = "На острове";
                ActualQuestion = "A";
            }
            if (questionNumber == 59)
            {
                QuestionDisplay.NewQuestion = "На какие устройства есть игра про «Скибидистов» (официальная)";
                RawQuestionImage.texture = QuestionImagesTextures[59];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Компьютер";
                QuestionDisplay.NewB = "На VR шлем";
                QuestionDisplay.NewC = "Телефон";
                QuestionDisplay.NewD = "Игровая приставка";
                ActualQuestion = "C";
            }
            if (questionNumber == 60)
            {
                QuestionDisplay.NewQuestion = "Как происходит самоуничтожение Скибидиста?";
                RawQuestionImage.texture = QuestionImagesTextures[60];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Скибидист смывает сам себя";
                QuestionDisplay.NewB = "Скибидист растворяется";
                QuestionDisplay.NewC = "Скибидист становится изгоем";
                QuestionDisplay.NewD = "У него нет такой способиности";
                ActualQuestion = "A";
            }
            if (questionNumber == 61)
            {
                QuestionDisplay.NewQuestion = "Чем можно подорвать Скибидиста?";
                RawQuestionImage.texture = QuestionImagesTextures[61];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Бомбой или пушкой";
                QuestionDisplay.NewB = "Луком";
                QuestionDisplay.NewC = "Ножом";
                QuestionDisplay.NewD = "Сковородкой";
                ActualQuestion = "A";
            }
            if (questionNumber == 62)
            {
                QuestionDisplay.NewQuestion = "В чем заключается ранение кнопкой смыва?";
                RawQuestionImage.texture = QuestionImagesTextures[62];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "В слабом дергании кнопки смыва";
                QuestionDisplay.NewB = "В сильном дергании кнопки смыва";
                QuestionDisplay.NewC = "В среднем дергании кнопки смыва";
                QuestionDisplay.NewD = "В отрывании кнопки смыва";
                ActualQuestion = "B";
            }
            if (questionNumber == 63)
            {
                QuestionDisplay.NewQuestion = "Каким огнем можно сжечь Скибидиста?";
                RawQuestionImage.texture = QuestionImagesTextures[63];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Тёмным";
                QuestionDisplay.NewB = "Ледяным";
                QuestionDisplay.NewC = "Электрическим";
                QuestionDisplay.NewD = "Обычным";
                ActualQuestion = "D";
            }
            if (questionNumber == 64)
            {
                QuestionDisplay.NewQuestion = "В каком сезоне появились Скибидисты-писсуары?";
                RawQuestionImage.texture = QuestionImagesTextures[64];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "1";
                QuestionDisplay.NewB = "2";
                QuestionDisplay.NewC = "3";
                QuestionDisplay.NewD = "4";
                ActualQuestion = "A";
            }
            if (questionNumber == 65)
            {
                QuestionDisplay.NewQuestion = "Что представляет из себя ТвВумен?";
                RawQuestionImage.texture = QuestionImagesTextures[65];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Женская версия ТвМена";
                QuestionDisplay.NewB = "Женская версия Скибидиста";
                QuestionDisplay.NewC = "Женская версия Камерамена";
                QuestionDisplay.NewD = "Женская версия Спикермена";
                ActualQuestion = "A";
            }
            if (questionNumber == 66)
            {
                QuestionDisplay.NewQuestion = "Какое оружие есть у ТвВумен?";
                RawQuestionImage.texture = QuestionImagesTextures[66];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Меч";
                QuestionDisplay.NewB = "Пистолет";
                QuestionDisplay.NewC = "Топор";
                QuestionDisplay.NewD = "Большое количество способностей";
                ActualQuestion = "D";
            }
            if (questionNumber == 67)
            {
                QuestionDisplay.NewQuestion = "Кто является протагонистом в Скибиди серии?";
                RawQuestionImage.texture = QuestionImagesTextures[67];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Скибидисты";
                QuestionDisplay.NewB = "Агенты";
                QuestionDisplay.NewC = "Твмены";
                QuestionDisplay.NewD = "ТвВумены";
                ActualQuestion = "B";
            }
            if (questionNumber == 68)
            {
                QuestionDisplay.NewQuestion = "Какого цвета костюм у Камерамена?";
                RawQuestionImage.texture = QuestionImagesTextures[68];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Белого";
                QuestionDisplay.NewB = "Зеленого";
                QuestionDisplay.NewC = "Черного";
                QuestionDisplay.NewD = "Синего";
                ActualQuestion = "C";
            }
            if (questionNumber == 69)
            {
                QuestionDisplay.NewQuestion = "Начиная с какого эпизода появились Твмены?";
                RawQuestionImage.texture = QuestionImagesTextures[69];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "10-20";
                QuestionDisplay.NewB = "20-30";
                QuestionDisplay.NewC = "30-40";
                QuestionDisplay.NewD = "40-50";
                ActualQuestion = "C";
            }
            if (questionNumber == 70)
            {
                QuestionDisplay.NewQuestion = "Укажите несуществующего агента";
                RawQuestionImage.texture = QuestionImagesTextures[70];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Камерамен";
                QuestionDisplay.NewB = "Камера паук";
                QuestionDisplay.NewC = "Камера табуретка";
                QuestionDisplay.NewD = "Твмен";
                ActualQuestion = "C";
            }
            if (questionNumber == 71)
            {
                QuestionDisplay.NewQuestion = "Какая защита лица есть у Скибидистов?";
                RawQuestionImage.texture = QuestionImagesTextures[71];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Выезжающая маска";
                QuestionDisplay.NewB = "Корона";
                QuestionDisplay.NewC = "Очки";
                QuestionDisplay.NewD = "Золотые зубы";
                ActualQuestion = "A";
            }
            if (questionNumber == 72)
            {
                QuestionDisplay.NewQuestion = "В скольких эпизодах появлялась ТвВумен?";
                RawQuestionImage.texture = QuestionImagesTextures[72];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "1";
                QuestionDisplay.NewB = "2";
                QuestionDisplay.NewC = "3";
                QuestionDisplay.NewD = "4";
                ActualQuestion = "B";
            }
            if (questionNumber == 73)
            {
                QuestionDisplay.NewQuestion = "В какой серии впервые появился глючный Скибидист?";
                RawQuestionImage.texture = QuestionImagesTextures[73];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "1";
                QuestionDisplay.NewB = "10";
                QuestionDisplay.NewC = "20";
                QuestionDisplay.NewD = "29";
                ActualQuestion = "D";
            }
            if (questionNumber == 74)
            {
                QuestionDisplay.NewQuestion = "Сколько голов у Скибиди гидры?";
                RawQuestionImage.texture = QuestionImagesTextures[74];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "2";
                QuestionDisplay.NewB = "3";
                QuestionDisplay.NewC = "4";
                QuestionDisplay.NewD = "5";
                ActualQuestion = "D";
            }
            if (questionNumber == 75)
            {
                QuestionDisplay.NewQuestion = "Что на руках у Скибиди мутанта?";
                RawQuestionImage.texture = QuestionImagesTextures[75];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Когти";
                QuestionDisplay.NewB = "Ногти";
                QuestionDisplay.NewC = "Лезвия";
                QuestionDisplay.NewD = "Безнопилы";
                ActualQuestion = "A"; 
            }
            if (questionNumber == 76)
            {
                QuestionDisplay.NewQuestion = "Кто является более разумным?";
                RawQuestionImage.texture = QuestionImagesTextures[76];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Скибиди туалет";
                QuestionDisplay.NewB = "Скибиди писсуар";
                QuestionDisplay.NewC = "Скибиди полотенце";
                QuestionDisplay.NewD = "Агент";
                ActualQuestion = "D";
            }
            if (questionNumber == 77)
            {
                QuestionDisplay.NewQuestion = "В каком эпизоде появился Скибиди шпион";
                RawQuestionImage.texture = QuestionImagesTextures[77];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "28";
                QuestionDisplay.NewB = "29";
                QuestionDisplay.NewC = "30";
                QuestionDisplay.NewD = "31";
                ActualQuestion = "A";
            }
            if (questionNumber == 78)
            {
                QuestionDisplay.NewQuestion = "Какое животное есть у Скибидистов?";
                RawQuestionImage.texture = QuestionImagesTextures[78];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Скибиди крот";
                QuestionDisplay.NewB = "Скибиди Собака";
                QuestionDisplay.NewC = "Скибиди кот";
                QuestionDisplay.NewD = "Скибиди хомяк";
                ActualQuestion = "C";
            }
            if (questionNumber == 79)
            {
                QuestionDisplay.NewQuestion = "Сколько рук у Скибиди осминога?";
                RawQuestionImage.texture = QuestionImagesTextures[79];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "1";
                QuestionDisplay.NewB = "2";
                QuestionDisplay.NewC = "3";
                QuestionDisplay.NewD = "4";
                ActualQuestion = "D";
            }
            if (questionNumber == 80)
            {
                QuestionDisplay.NewQuestion = "Что ТвВумен может делать своей головой?";
                RawQuestionImage.texture = QuestionImagesTextures[80];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Прикрепляться к Скибидисту";
                QuestionDisplay.NewB = "Показывать фильмы";
                QuestionDisplay.NewC = "Убавлять звук";
                QuestionDisplay.NewD = "Разговаривать";
                ActualQuestion = "A";
            }
            if (questionNumber == 81)
            {
                QuestionDisplay.NewQuestion = "В каком эпизоде появился Скибиди осьминог?";
                RawQuestionImage.texture = QuestionImagesTextures[81];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "32";
                QuestionDisplay.NewB = "33";
                QuestionDisplay.NewC = "44";
                QuestionDisplay.NewD = "43";
                ActualQuestion = "C";
            }
            if (questionNumber == 82)
            {
                QuestionDisplay.NewQuestion = "Для чего был создан Скибиди паразит?";
                RawQuestionImage.texture = QuestionImagesTextures[82];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Для развлечения";
                QuestionDisplay.NewB = "Для заражаения";
                QuestionDisplay.NewC = "Для разведки";
                QuestionDisplay.NewD = "Для отступления";
                ActualQuestion = "B";
            }
            if (questionNumber == 83)
            {
                QuestionDisplay.NewQuestion = "Чья голова находится у Скибиди ученого?";
                RawQuestionImage.texture = QuestionImagesTextures[83];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Айзека Кляйнера";
                QuestionDisplay.NewB = "Гордона Фримена";
                QuestionDisplay.NewC = "Скибидиста";
                QuestionDisplay.NewD = "Твмена";
                ActualQuestion = "A";
            }
            if (questionNumber == 84)
            {
                QuestionDisplay.NewQuestion = "Кто создал Скибиди мутанта?";
                RawQuestionImage.texture = QuestionImagesTextures[84];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Твмен";
                QuestionDisplay.NewB = "Скибиди ученый";
                QuestionDisplay.NewC = "Колонкамен";
                QuestionDisplay.NewD = "Обычный Скибидист";
                ActualQuestion = "B";
            }
            if (questionNumber == 85)
            {
                QuestionDisplay.NewQuestion = "Кого может телепортировать ТвВумен?";
                RawQuestionImage.texture = QuestionImagesTextures[85];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Только себя";
                QuestionDisplay.NewB = "Себя и своих союзников";
                QuestionDisplay.NewC = "Врагов";
                QuestionDisplay.NewD = "Врагов и предметы";
                ActualQuestion = "B";
            }
            if (questionNumber == 86)
            {
                QuestionDisplay.NewQuestion = "Кто может заражать агентов?";
                RawQuestionImage.texture = QuestionImagesTextures[86];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Обычный Скибидист";
                QuestionDisplay.NewB = "Твмен";
                QuestionDisplay.NewC = "ТвВумен";
                QuestionDisplay.NewD = "Скибидист ученый";
                ActualQuestion = "D";
            }
            if (questionNumber == 87)
            {
                QuestionDisplay.NewQuestion = "Какого размера Скибиди паразит?";
                RawQuestionImage.texture = QuestionImagesTextures[87];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Очень маленький";
                QuestionDisplay.NewB = "Маленький";
                QuestionDisplay.NewC = "Большой";
                QuestionDisplay.NewD = "Очень большой";
                ActualQuestion = "A";
            }
            if (questionNumber == 88)
            {
                QuestionDisplay.NewQuestion = "Укажите способность, которой нет у глючного Скибидиста";
                RawQuestionImage.texture = QuestionImagesTextures[88];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Полет";
                QuestionDisplay.NewB = "Высокая скорость";
                QuestionDisplay.NewC = "Огромная сила";
                QuestionDisplay.NewD = "Невидимость";
                ActualQuestion = "D";
            }
            if (questionNumber == 89)
            {
                QuestionDisplay.NewQuestion = "В каких двух эпизодах не было агентов?";
                RawQuestionImage.texture = QuestionImagesTextures[89];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "1, 3";
                QuestionDisplay.NewB = "4, 54";
                QuestionDisplay.NewC = "23, 43";
                QuestionDisplay.NewD = "11, 26";
                ActualQuestion = "A";
            }
            if (questionNumber == 90)
            {
                QuestionDisplay.NewQuestion = "Из частей кого сделан Скибиди мутант?";
                RawQuestionImage.texture = QuestionImagesTextures[90];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Агентов";
                QuestionDisplay.NewB = "Скибидистов";
                QuestionDisplay.NewC = "Скибиди ученых";
                QuestionDisplay.NewD = "Твменов";
                ActualQuestion = "A";
            }
            if (questionNumber == 91)
            {
                QuestionDisplay.NewQuestion = "В каком эпизоде впервые появился Скибиди паразит?";
                RawQuestionImage.texture = QuestionImagesTextures[91];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "10";
                QuestionDisplay.NewB = "20";
                QuestionDisplay.NewC = "30";
                QuestionDisplay.NewD = "40";
                ActualQuestion = "C";
            }
            if (questionNumber == 92)
            {
                QuestionDisplay.NewQuestion = "В каком эпизоде появился Скибиди кот?";
                RawQuestionImage.texture = QuestionImagesTextures[92];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "48";
                QuestionDisplay.NewB = "23";
                QuestionDisplay.NewC = "16";
                QuestionDisplay.NewD = "11";
                ActualQuestion = "C";
            }
            if (questionNumber == 93)
            {
                QuestionDisplay.NewQuestion = "Что может делать ТвВумен своим лучем?";
                RawQuestionImage.texture = QuestionImagesTextures[93];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Оглушать противников";
                QuestionDisplay.NewB = "Замораживать противников";
                QuestionDisplay.NewC = "Притягивать предметы";
                QuestionDisplay.NewD = "Он позволяет ей летать";
                ActualQuestion = "C";
            }
            if (questionNumber == 94)
            {
                QuestionDisplay.NewQuestion = "В каких эпизодах появлялся Скибиди мутант?";
                RawQuestionImage.texture = QuestionImagesTextures[94];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "33, 37";
                QuestionDisplay.NewB = "21, 24";
                QuestionDisplay.NewC = "14, 43";
                QuestionDisplay.NewD = "50, 51";
                ActualQuestion = "A";
            }
            if (questionNumber == 95)
            {
                QuestionDisplay.NewQuestion = "Какая прическа у глючного Скибидиста?";
                RawQuestionImage.texture = QuestionImagesTextures[95];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Косы";
                QuestionDisplay.NewB = "Каре";
                QuestionDisplay.NewC = "Кроп";
                QuestionDisplay.NewD = "Он лысый";
                ActualQuestion = "D";
            }
            if (questionNumber == 96)
            {
                QuestionDisplay.NewQuestion = "Какого цвета рубашка у экстренного агента?";
                RawQuestionImage.texture = QuestionImagesTextures[96];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Зеленого";
                QuestionDisplay.NewB = "Синего";
                QuestionDisplay.NewC = "Черного";
                QuestionDisplay.NewD = "Белого";
                ActualQuestion = "D";
            }
            if (questionNumber == 97)
            {
                QuestionDisplay.NewQuestion = "Что может выдержать маска Скибидиста?";
                RawQuestionImage.texture = QuestionImagesTextures[97];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Лазерной пушки";
                QuestionDisplay.NewB = "Луча Твмена";
                QuestionDisplay.NewC = "Луча ТвВумен";
                QuestionDisplay.NewD = "Только обычный выстрел";
                ActualQuestion = "A";
            }
            if (questionNumber == 98)
            {
                QuestionDisplay.NewQuestion = "Анонс какого персонажа произошел в 2021 году?";
                RawQuestionImage.texture = QuestionImagesTextures[98];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Колонкамена";
                QuestionDisplay.NewB = "Скибиди туалета";
                QuestionDisplay.NewC = "Твмена";
                QuestionDisplay.NewD = "Камерамена";
                ActualQuestion = "D";
            }
            if (questionNumber == 99)
            {
                QuestionDisplay.NewQuestion = "Кто является антагонистами в Скибиди серии?";
                RawQuestionImage.texture = QuestionImagesTextures[99];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Скибидисты";
                QuestionDisplay.NewB = "Агенты";
                QuestionDisplay.NewC = "Твмены";
                QuestionDisplay.NewD = "ТвВумены";
                ActualQuestion = "A";
            }
             /*if (questionNumber == 100)
            {
                QuestionDisplay.NewQuestion = "Какого цвета луч у ТвВумен?";
                RawQuestionImage.texture = QuestionImagesTextures[59];
                QuestionImage.SetActive(true);
                QuestionDisplay.NewA = "Фиолетовый";
                QuestionDisplay.NewB = "Зеленый";
                QuestionDisplay.NewC = "Красный";
                QuestionDisplay.NewD = "Желтый";
                ActualQuestion = "A";
            }*/







            if (questionNumber < questionLength)
            {
                questionNumber++;
            }
            else
            {
                Debug.Log("Игра окончена");
                _endGamePanel.SetActive(true);
                //MusicCopy.GetComponent<AudioSource>().mute = true; // Вручную мьютим музыку
                Yandex.ShowFullscreen1();
                
                _score = _answerButtons.ScoreValue;
                EndGameTextPanel.GetComponent<TextMeshProUGUI>().text = "Поздравляем, вы завершили игру и ответили правильно на все вопросы и набрали " + _score + " очков!" ;

            }
            QuestionDisplay.UpdateQuestion = false;
            
         
        }
    }
}
