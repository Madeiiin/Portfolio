using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fadeblackout : MonoBehaviour
{
    public Animator anim;
    public GameObject plane;

    private void Start()
    {
        StartCoroutine(Plane());
    }

    private void Awake()
    {
        anim = plane.GetComponent<Animator>();
    }

    private IEnumerator Plane()
    {
        anim.SetBool("_isStart", false);
       
        yield return new WaitForSeconds(0.5f);
        

    }
    
}
