using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform ballPozisyon;

    void Update()
    {
        if(ballPozisyon.position.y > transform.position.y) {

            transform.position = new Vector3 (transform.position.x, ballPozisyon.position.y, transform.position.z);
        }
    }
}
