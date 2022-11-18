using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Vector3 gravity;
    [SerializeField] private Vector3 jumpSpeed;
    [SerializeField] private GameObject jumpSound;    

    private bool isGrounded = false;
    private Rigidbody rb;
    private GameObject newSound;
    private Animator animator;
    private bool jump;

    private void Awake()
    {
        Physics.gravity = gravity;
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();       
    }
    
    // -- Se hace presenter de la clase que da movimiento al personaje para que el playercontroller instancie y use sus métodos
    void Update()
    {
        if (jump && isGrounded)
        {
            rb.velocity = jumpSpeed; 
            isGrounded = false;
            animator.SetBool("isJumping", true);
            newSound = Instantiate(jumpSound);
            Destroy(newSound, 2);
        }
        else
        {
            animator.SetBool("isJumping", false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }        
    }

    public void Jump()
    {
        jump = true;
    }



}
