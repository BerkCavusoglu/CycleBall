using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn: MonoBehaviour
{
  
    public static float turnSpeed = 0.15f;
    
    void Update()
    {
        transform.Rotate (0,0, turnSpeed);
        
    }
}
