using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidBody;
    [SerializeField] private int speed;
    [SerializeField] private float jumpForce;
    public SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public Animator anim;
    public GroundDetection gr;
    public AudioSource audioJump;
    public AudioSource audioAttack;
    public FixedJoystick joystick;
    void Update()
    {
        anim.SetBool("Running",false);
        if (Input.GetKey(KeyCode.A) || joystick.Horizontal < 0)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
            sr.flipX = true;
            anim.SetBool("Running", true);
        }
        if (Input.GetKey(KeyCode.D) || joystick.Horizontal > 0)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
            sr.flipX = false;
            anim.SetBool("Running",true);
        }
        if (Input.GetKeyDown(KeyCode.Space)&& gr.isGrounded == true) 
        {
            Jump();
        }
        if (Input.GetKey(KeyCode.E))
        {
            Attack();
        }
        anim.SetBool("IsGrounded", gr.isGrounded);
        
    }
    public void Jump()
    {
        if (gr.isGrounded == true)
        {
            rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            audioJump.Play();
        }
    }
    public void Attack()
    {
        anim.SetTrigger("Attack");
    }
}
