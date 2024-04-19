using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Adver : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowFullscreen();

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }


    public static void ShowFullscreen1()
    {
        ShowFullscreen();
    }
}
