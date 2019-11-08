using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Movement1 : MonoBehaviour
{
    Rigidbody2D rigidbody2D;

    float speed = 1.5f;
    int direction = 1;
    float timer;
    float movementTime = 2.0f;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        timer = movementTime;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = rigidbody2D.position;
        timer -= Time.deltaTime;

        if(timer < 0)
        {
            direction =  -direction;
            timer = movementTime;
            animator.SetFloat("Move Y", direction);
        }

        position.y = position.y + speed * direction * Time.deltaTime;
        rigidbody2D.MovePosition(position);
    }
}
