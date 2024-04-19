using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingScore : MonoBehaviour
{
    [SerializeField] private int score;
    
    void Start()
    {
    
      
    }

    public void InstFloatText(int newScore)
    {
        Debug.Log("NewScpre" + newScore);
        Debug.Log("score" + score);
    }
}
