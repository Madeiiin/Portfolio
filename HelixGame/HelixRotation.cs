using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixRotation : MonoBehaviour
{
    public float rotationSpeed = 300f;
    public float rotationSpeedAndroid = 50f;
    public bool isMobile = false;
    
    void Awake()
    {
        if(DeviceType.IsMobileBrowser()) {
          //  Debug.Log("Открыто на телефоне");
            isMobile = true;
        }
        else 
        {
            // Debug.Log("Открыто на ПК");
        }
    }
    
    private void Update()
    {
        if (isMobile == false && Input.GetMouseButton(0))  // ПК
        {
            float mouseX = Input.GetAxisRaw("Mouse X");
            transform.Rotate(transform.position.x, -mouseX * rotationSpeed * Time.deltaTime, transform.position.z);
            
        }
        else // Мобилки
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                float XDeltaPos = Input.GetTouch(0).deltaPosition.x;
                transform.Rotate(transform.position.x, XDeltaPos * rotationSpeedAndroid * Time.deltaTime, transform.position.z);
            }
        }
        
        


    }
}
