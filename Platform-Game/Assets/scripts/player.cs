using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public float jump_force;
    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
        jump();
    }

    void move(){
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;
    }

    void jump(){
        if(Input.GetButtonDown("Jump")){
            rig.AddForce(new Vector2(0f, jump_force), ForceMode2D.Impulse);
        }
    }
}
