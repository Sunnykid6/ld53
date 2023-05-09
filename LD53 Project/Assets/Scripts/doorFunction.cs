using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using FMODUnity;
public class doorFunction : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Animator animator;
    [SerializeField] private LayerMask whatIsPlayer;
    [SerializeField] public int levelLoader = 0;
    [SerializeField] private EventReference _doorOpenRef;
    [SerializeField] private GameObject _doorBlocker;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics2D.OverlapCircle(transform.position, 0.2f, whatIsPlayer))
        {
            SceneManager.LoadScene(levelLoader);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && collision.gameObject.GetComponent<PlayerController>().hasDoorKey)
        {
            animator.SetBool("shouldClose", false);
            animator.SetBool("shouldOpen", true);
            _doorBlocker.GetComponent<BoxCollider2D>().enabled = false;
            RuntimeManager.PlayOneShot(_doorOpenRef, transform.position);        
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            animator.SetBool("shouldOpen", false);
            animator.SetBool("shouldClose", true);
        }
    }
}
