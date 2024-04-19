using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneDisab : MonoBehaviour
{
    public GameObject plane;
    
    private void Start()
    {
        StartCoroutine(Dis());
        
    }
    
    private IEnumerator Dis()
    {
        yield return new WaitForSeconds(1.5f);
        plane.SetActive(false);
        

    }
}
