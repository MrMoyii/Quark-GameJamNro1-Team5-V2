using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour, IPlayerView 
{

    [SerializeField] private Vector3 gravity;
    [SerializeField] private Vector3 jumpSpeed;
    [SerializeField] private GameObject jumpSound;
    [SerializeField] private float laneDistance;
    [SerializeField] private GameObject rightPosition, leftPosition, centerPosition;

    private bool isGrounded = false;
    private Rigidbody rb;
    private GameObject newSound;
    private Animator animator;
    private bool jump;
    private int desireLine = 0;
    private bool left, right;
    private float targetPositionRight, targetPositionLeft, targetPositionCenter;
    private Vector3 vectorPosition;

    IPlayerPresenter presenter;

    private void Awake()
    {
        Physics.gravity = gravity; 
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        presenter = new PlayerPresenter(this);

        targetPositionCenter = centerPosition.transform.position.z;
        targetPositionLeft   = leftPosition.transform.position.z;
        targetPositionRight = rightPosition.transform.position.z;
    }

    void Update()
    {
        if (jump && isGrounded)
        {
            rb.velocity = jumpSpeed;
            isGrounded = false;
            animator.SetBool("isJumping", true);
            newSound = Instantiate(jumpSound);
            Destroy(newSound, 2);
            jump = false;
        }
        else
        {
            animator.SetBool("isJumping", false);
        }


        if (desireLine == 1 && left)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, targetPositionLeft);
            left = false;
            right = true;
        }

        if (desireLine == -1 && right)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, targetPositionRight);
            left = true;
            right = false; 
        }

        if (desireLine == 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, targetPositionCenter);            
        }        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }

    public void DoJump()
    {
        jump = true;
    }

    public void PlayAnimation(string name)
    {
        if (name == "Jump")
        { 
            animator.SetBool("isJumping", true);
        }
    }

    public void Left() 
    {        
        if (desireLine < 1)
        {
            desireLine++;
            left = true;
        }    
    }

    public void Right()
    {        
        if (desireLine > -1)
        {
            desireLine--;
            right = true;
        }
    }

    public void User_Event_Jump()
    {
        presenter.Jump();
    }

    public void User_Event_Move_Left()
    {
        presenter.MoveLeft();
    }

    public void User_Event_Move_Right()
    {        
        presenter.MoveRight();
    }
}

