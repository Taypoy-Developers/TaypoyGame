using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoveJoystick : MonoBehaviour
{
    private float horizontalMove = 0f;
    private float verticalMove = 0f;
    public Joystick joystick;

    Rigidbody2D Personaje;

    public float caminar = 1.25f;
    public float saltar = 5f;

    float posX, posY;
    public SpriteRenderer spriterenderer;
    public Animator anima;
    void Start()
    {
        Personaje = GetComponent<Rigidbody2D>();
        posX = transform.position.x;
        posY = transform.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalMove = joystick.Horizontal * caminar;
        transform.position += new Vector3(horizontalMove, 0, 0) * Time.deltaTime * caminar;

        if (horizontalMove>0)
        {
            spriterenderer.flipX = false;
            anima.SetBool("Correr", true);
        }
        else if (horizontalMove<0)
        {
            spriterenderer.flipX = true;
            anima.SetBool("Correr", true);
        }
        else
        {
            anima.SetBool("Correr", false);
            anima.SetBool("Saltar", false);
        }
        //falta incluirla condicion de salto
    }

    public void Jump()
    {
        if (Colided.suelover)
        {
            Personaje.velocity = new Vector2(Personaje.velocity.x, saltar);
            anima.SetBool("Saltar", true);
        }

    
    }
}
