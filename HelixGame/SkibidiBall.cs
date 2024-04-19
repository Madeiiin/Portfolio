using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class SkibidiBall : MonoBehaviour
{
    private Rigidbody rb;
    public float bounceForce = 400f;

    public GameObject splitPrefab;

    private AudioManager audioManager;

    public static Action OnWin;

    public bool isBallTouchFloor;
    
    
    private void Start()
    { 
        audioManager = FindObjectOfType<AudioManager>();
       rb = GetComponent<Rigidbody>();
       isBallTouchFloor = false;
    }

    private void OnCollisionEnter(Collision other)
    {
    
        rb.velocity = new Vector3(rb.velocity.x, bounceForce * Time.deltaTime, rb.velocity.z);

        StartCoroutine(LandCor());
        
        
        GameObject newSplit = Instantiate(splitPrefab,new Vector3(transform.position.x, other.transform.position.y + 0.19f, transform.position.z), Quaternion.Euler(90, 0, 0));
        newSplit.transform.localScale = Vector3.one * Random.Range(0.8f, 1.2f); // Размер пятна
        newSplit.transform.parent = other.transform;
        Destroy(newSplit.gameObject, 5f);
        
        
       string materialName = other.transform.GetComponent<MeshRenderer>().material.name;
       
 

       if (materialName == "Safe (Instance)")
       {
        //  Debug.Log("Safe position"); 
       }
       
       if (materialName == "Unsafe (Instance)")
       {
           GameManager.gameOver = true;
           audioManager.Play("GameOver");
       }
       
       if (materialName == "LastRing (Instance)" && !GameManager.levelWin)
       {
           GameManager.levelWin = true;
           audioManager.Play("LevelWin");
           OnWin?.Invoke();
       }

       
       
       
    }
    
    IEnumerator LandCor()
    {
        if (isBallTouchFloor == false)
        {
            audioManager.Play("Land");
            isBallTouchFloor = true;
        }
        yield return new WaitForSeconds(0.15f);
        isBallTouchFloor = false;
    }
}
