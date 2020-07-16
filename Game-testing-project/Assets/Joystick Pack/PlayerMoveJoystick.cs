using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
<<<<<<< HEAD
//using UnityEngine.InputSystem;

public class PlayerMoveJoystick : MonoBehaviour
=======
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
>>>>>>> 1596286ef452722cb8e3251434365f5fff62d8c0
{
    private float horizontalMove = 0f;
    private float verticalMove = 0f;
    public Joystick joystick;
<<<<<<< HEAD
    public bool MejorSalto = false;
    public float fallMultiplayer = 0.5f;
    public float lowMultiplayer = 1f;
=======
>>>>>>> 1596286ef452722cb8e3251434365f5fff62d8c0

    Rigidbody2D Personaje;

    public float caminar = 1.25f;
    public float saltar = 3f;

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

<<<<<<< HEAD
        if (horizontalMove > 0)
=======
        if (horizontalMove>0)
>>>>>>> 1596286ef452722cb8e3251434365f5fff62d8c0
        {
            spriterenderer.flipX = false;
            anima.SetBool("Correr", true);
        }
<<<<<<< HEAD
        else if (horizontalMove < 0)
=======
        else if (horizontalMove<0)
>>>>>>> 1596286ef452722cb8e3251434365f5fff62d8c0
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
<<<<<<< HEAD
    void Jump()
    {
        if (Colided.suelover)
=======

    public void Jump()
    {
        if (Input.GetKey("space") && Colided.suelover)
>>>>>>> 1596286ef452722cb8e3251434365f5fff62d8c0
        {
            Personaje.velocity = new Vector2(Personaje.velocity.x, saltar);
            anima.SetBool("Saltar", true);
        }
<<<<<<< HEAD
        if (MejorSalto)
        {
            if (Personaje.velocity.y < 0)
            {
                Personaje.velocity += Vector2.up * Physics.gravity.y * (fallMultiplayer) * Time.deltaTime;
            }
            if (Personaje.velocity.y > 0)
            {
                Personaje.velocity += Vector2.up * Physics.gravity.y * (lowMultiplayer) * Time.deltaTime;
            }
        }

    }

=======

       
    }
>>>>>>> 1596286ef452722cb8e3251434365f5fff62d8c0
}
