using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class ItemPickUp : MonoBehaviour
{
    [SerializeField] private EventReference _stampSoundRef;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log(collision.gameObject);
            collision.gameObject.GetComponent<PlayerController>().setItemCheck(this.gameObject);
            RuntimeManager.PlayOneShot(_stampSoundRef, transform.position);
            Destroy(gameObject);
        }
    }
}
