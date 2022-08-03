using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayo : MonoBehaviour
{
    public float vel;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(new Vector3(vel*Time.deltaTime, 0),Space.Self);
    }
}
