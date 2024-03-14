using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float speed = 10F;

    public void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(h, v);
        GetComponent<Rigidbody2D>().velocity = direction.normalized * speed;

        GetComponent<Animator>().SetBool("isFlyingUp", (v > 0));
        GetComponent<Animator>().SetBool("isFlyingLeft", (h < 0));
        GetComponent<Animator>().SetBool("isFlyingRight", (h > 0));

    }
}
