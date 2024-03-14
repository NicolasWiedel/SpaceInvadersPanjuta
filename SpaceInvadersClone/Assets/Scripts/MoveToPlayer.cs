using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject gameObject = GameObject.FindWithTag("Player");
        if(gameObject != null)
        {
            Vector3 v3 = (gameObject.transform.position - transform.position).normalized;
            Vector2 v2 = new Vector2(v3.x, v3.y);
            GetComponent<Rigidbody2D>().velocity = v2 * speed;
        } 
    }
}
