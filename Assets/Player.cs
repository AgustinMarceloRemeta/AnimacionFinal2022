using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public float speed, speed2;
    Animator anim;
    Rigidbody2D rb;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed* Time.deltaTime;
        transform.Translate(new Vector2 (horizontal, 0),Space.World);
        if (horizontal != 0) anim.SetBool("Caminar", true);
        else anim.SetBool("Caminar", false);
        if (horizontal < 0) transform.rotation =  Quaternion.Euler(0, 180,0);
        else transform.rotation = Quaternion.Euler(0, 0, 0);

        float vertical = Input.GetAxis("Vertical") * speed2 * Time.deltaTime;
        if (vertical > 0)
        {
            transform.Translate(new Vector3(0, vertical));
            anim.SetBool("Salto", true);
            anim.SetBool("Caminar", false);
            rb.gravityScale = 0;
        }
        else
        {
            anim.SetBool("Salto", false);
            rb.gravityScale = 1;
        }
    }
    private void OnDisable()
    {
        anim.SetBool("Salto", false);
    }
}
