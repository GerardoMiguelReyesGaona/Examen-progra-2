using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemento : MonoBehaviour
{
    private float moveX;
    private float moveY;
    private float moveZ;
    [SerializeField] private float movSpeed;
    [SerializeField] private float jumpHeight;
    private CharacterController controlador;
    private Vector3 velocidad;
    public float gravedad = 30f;
    public bool isGrounded;
    public Transform groundCheck;
    public float radio;
    public LayerMask whatIsGround;
    public float fallSpeed=0;
    private void Start()
    {
        controlador=GetComponent<CharacterController>();
        //PlayerJump();
        //SetGravedad();
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, radio, whatIsGround);

        if (isGrounded && velocidad.y < 0)
        {
            velocidad.y = 0;
        }
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");

        velocidad.y += gravedad * Time.deltaTime;

        Vector3 mover = transform.right * movSpeed * moveX + transform.forward * movSpeed * moveZ;

        controlador.Move(mover * Time.deltaTime);
        controlador.Move(velocidad * Time.deltaTime);
    }
    //public void PlayerJump()
    //{

    //    if (isGrounded == true && Input.GetButtonDown("Jump"))
    //    {
    //        jumpHeight =fallSpeed;
    //        moveZ = fallSpeed;
    //    }
       
    //}
    //public void SetGravedad()
    //{
    //    if (isGrounded == true)
    //    {
    //        fallSpeed = gravedad * Time.deltaTime;
    //        Debug.Log(fallSpeed);
    //        moveZ = fallSpeed;
    //    }
    //    else
    //    {
    //        fallSpeed -= gravedad * Time.deltaTime;
    //        moveZ = fallSpeed;
    //    }

    //}
}
