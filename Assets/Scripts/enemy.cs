using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemy : MonoBehaviour

{
    public SpriteRenderer sr;
    public float speed;
    public bool goLeft = true;
    public Transform left;
    public Transform right;

    void Update()
    {
        if (goLeft == true)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
            sr.flipX = true;
        }

        if (goLeft == false)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
            sr.flipX = false;
        }
        if (transform.position.x < left.position.x)
        {
            goLeft = false;
        }
        if (transform.position.x > right.position.x)
        {
            goLeft = true;
        }
    }
}
