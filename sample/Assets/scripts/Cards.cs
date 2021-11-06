using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Cards : MonoBehaviour
{
    public void Start()
    {
        print("starting");
    }
    public void followMouse() {//built in unity method
      
            transform.position = Input.mousePosition;
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
