using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ring : MonoBehaviour
{
   private Transform player;
   public GameObject[] childRings;


   private float radius = 10f;
   private float force = 500f;

   private int currentScore;

 


   
   private void Start()
   {
  
      
      player = GameObject.FindGameObjectWithTag("Player").transform;

   }

   private void Update()
   {
      if (transform.position.y > player.position.y)
      {
         GameManager.noOfPassingRings++;
         GameManager.CurrentScore += 10;
         FindObjectOfType<AudioManager>().Play("Whoosh");
         
         for (int i = 0; i < childRings.Length; i++)
         {
            childRings[i].GetComponent<Rigidbody>().isKinematic = false;
            childRings[i].GetComponent<Rigidbody>().useGravity = true;

            Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
          
            foreach (Collider newCollider in colliders)
            {
               Rigidbody rb = newCollider.GetComponent<Rigidbody>();
               if (rb != null);
               {
                  rb.AddExplosionForce(force, transform.position, radius);
               }
            }

            childRings[i].GetComponent<MeshCollider>().enabled = false;
            childRings[i].transform.parent = null;
            Destroy(childRings[i].gameObject, 2f); // Самоуничтожение колец
            Destroy(this.gameObject, 5f); // Самоуничтожение цилиндра
         }
         this.enabled = false;
         
        
      }
   }
   
   
   
   
   

}
