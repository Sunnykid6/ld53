using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class PushBlockOnce : MonoBehaviour
{

    [SerializeField] private Transform movePoint;
    private float moveSpeed = 1f;
    [SerializeField] private LayerMask whatIsWall;
    public bool hasPushedOrPulled = false;

    [Header("FMOD Sounds")]
    [SerializeField] private EventReference _pushSoundRef;
    [SerializeField] private EventReference _pullSoundRef;

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
        if (!hasPushedOrPulled)
        {
            if (directionVector != new Vector2(0, 0))
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(directionVector.x, directionVector.y, 0), 0.2f, whatIsWall))
                {
                    //Vector3 destination = transform.position + new Vector3(directionVector.x, directionVector.y, 0);
                    //Debug.Log(destination);
                    //Debug.Log("that was destination");
                    //transform.position = Vector3.MoveTowards(transform.position, destination, moveSpeed * Time.deltaTime);
                    transform.position += new Vector3(directionVector.x, directionVector.y, 0);
                    hasPushedOrPulled = true;
                    RuntimeManager.PlayOneShot(_pushSoundRef, transform.position);
                }
            }
        }

    }
    public void pullBlock(float angle)

    {
        if (!hasPushedOrPulled)
        {
            RuntimeManager.PlayOneShot(_pullSoundRef, transform.position);

            Vector2 directionVector = new Vector2(0, 0);
            switch (angle)
            {
                case 0:
                    directionVector = new Vector2(0, 1);
                    hasPushedOrPulled = true;
                    transform.position = transform.position + new Vector3(directionVector.x, directionVector.y, 0);
                    break;
                case 90:
                    directionVector = new Vector2(-1, 0);
                    hasPushedOrPulled = true;
                    transform.position = transform.position + new Vector3(directionVector.x, directionVector.y, 0);
                    break;
                case 180:
                    directionVector = new Vector2(0, -1);
                    hasPushedOrPulled = true;
                    transform.position = transform.position + new Vector3(directionVector.x, directionVector.y, 0);
                    break;
                case 270:
                    directionVector = new Vector2(1, 0);
                    hasPushedOrPulled = true;
                    transform.position = transform.position + new Vector3(directionVector.x, directionVector.y, 0);
                    break;
            }
        }
    }
}
