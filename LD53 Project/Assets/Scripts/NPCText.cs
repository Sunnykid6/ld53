using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCText : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private LayerMask whatisPlayer;
    [SerializeField] private Transform interactPos;
    [SerializeField] private float interactRange;
    [SerializeField] private UIPrompt uiPrompt;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics2D.OverlapCircle(interactPos.position, interactRange, whatisPlayer))
        {
            if (!uiPrompt.isDisplayed)
            {
                uiPrompt.openPanel();

            }
        }
        else
        {
            if (uiPrompt.isDisplayed)
            {
                uiPrompt.closePanel();
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(interactPos.position, interactRange);
    }
}
