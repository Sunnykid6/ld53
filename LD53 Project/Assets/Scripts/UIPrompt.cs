using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPrompt : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject uiPanel;
    public bool isDisplayed = false;
    void Start()
    {
        uiPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void openPanel()
    {
        uiPanel.SetActive(true);
        isDisplayed = true;
    }
    
    public void closePanel()
    {
        uiPanel.SetActive(false);
        isDisplayed = false;
    }
}
