using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBlock : MonoBehaviour
{
    [SerializeField] private Transform movePoint;
    private float moveSpeed = 1f;
    [SerializeField] private LayerMask whatIsWall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pushBlock(Vector2 directionVector)

    {
        Debug.Log("this is the direction vector");
        Debug.Log(directionVector);
        if(directionVector != new Vector2(0, 0))
        {
            if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(directionVector.x, directionVector.y, 0), 0.2f, whatIsWall))
            {
                //Vector3 destination = transform.position + new Vector3(directionVector.x, directionVector.y, 0);
                //Debug.Log(destination);
                //Debug.Log("that was destination");
                //transform.position = Vector3.MoveTowards(transform.position, destination, moveSpeed * Time.deltaTime);
                transform.position += new Vector3(directionVector.x, directionVector.y, 0);
            }
        }

    }
}
