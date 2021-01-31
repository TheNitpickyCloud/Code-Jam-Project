using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            FindObjectOfType<AudioManager>().Play("jump");
            jump = true;
        }
    }
    void LateUpdate()
    {
        if(gameObject.GetComponent<Rigidbody2D>().gravityScale <= 0)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 180f);
        }
        else if (gameObject.GetComponent<Rigidbody2D>().gravityScale > 0)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0f);
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
