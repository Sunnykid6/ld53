using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //fields to help move the character and animations
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    private Vector2 movement;
    [SerializeField] private float moveSpeed;
    [SerializeField] Transform Player;

    //Fields for interaction for pushing blocks
    [SerializeField] private Transform interactOrigin;
    [SerializeField] private Transform interactPos;
    [SerializeField] private Transform movePoint;
    private readonly Collider2D[] hitColliders = new Collider2D[3];
    [SerializeField] private LayerMask whatIsInteractable;
    [SerializeField] private LayerMask whatIsWall;
    [SerializeField] private int numFound;
    private PushBlock pushblock;
    private bool pushBlockCheck = false;


    private void Awake()
    {
        playerMovement = new PlayerMovement();
    }

    private void OnEnable()
    {
        playerMovement.Enable();
    }

    private void OnDisable()
    {
        playerMovement.Disable();
    }
    void Start()
    {
        movePoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(Player.position, movePoint.position) <= 0.05f)
        {
            movement = playerMovement.tileMovement.Movement.ReadValue<Vector2>();
            //clamp the other ends so that we can't move diagonally 
            if (Mathf.Abs(movement.x) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(movement.x, 0f, 0f), 0.2f, whatIsWall))
                {
                    movePoint.position += new Vector3(movement.x, 0f, 0f);
                    movement.y = 0;
                }
            }
            else if (Mathf.Abs(movement.y) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, movement.y, 0f), 0.2f, whatIsWall))
                {
                    movePoint.position += new Vector3(0, movement.y, 0f);
                    movement.x = 0;
                }
            }
        }
        numFound = Physics2D.OverlapCircleNonAlloc(interactPos.position, 0.2f, hitColliders, whatIsInteractable);
        if (numFound > 0)
        {
            if (playerMovement.tileMovement.MoveBox.ReadValue<float>() == 1)
            {
                pushblock = hitColliders[0].GetComponent<PushBlock>();
                pushblock.pushBlock(movement);
            }
        }
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.magnitude);
        

    }
    private void FixedUpdate()
    {

        changeInteractDirection();
        Player.position = Vector3.MoveTowards(Player.position, movePoint.position, moveSpeed * Time.deltaTime);

    }

    private void changeInteractDirection()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            interactOrigin.localRotation = Quaternion.Euler(0, 0, 90);
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            interactOrigin.localRotation = Quaternion.Euler(0, 0, -90);
        }
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            interactOrigin.localRotation = Quaternion.Euler(0, 0, 180);
        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            interactOrigin.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }

    private void blockPush()
    {
        if (pushBlockCheck)
        {

        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(interactPos.position, 0.2f);
    }

}