using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thanos : MonoBehaviour
{
    Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown("e")) anim.SetBool("Chasquea", true);
    }
}
