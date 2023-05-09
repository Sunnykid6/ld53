using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using FMODUnity;
using FMOD.Studio;

public class NPCText : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private LayerMask whatisPlayer;
    [SerializeField] private Transform interactPos;
    [SerializeField] private float interactRange;
    [SerializeField] private UIPrompt uiPrompt;
    [SerializeField] private Collider2D[] player = new Collider2D[1];
    [SerializeField]private int npcNumber;

    private Scene _currentScene;
    private string _sceneName;

    private int numPlayer;

    public TMP_Text speech;
    public string[] dialogue;
    private int dialogueIndex = 0;

    public float wordSpeed;
    public string theKey = "Circle";
    public bool hasItem = false;

    private Coroutine _typingCoroutine;

    [Header("FMOD Sounds")]
    [SerializeField] private EventReference _npcChatRef;
    [SerializeField] private EventReference _stampDeliverRef;

    // Update is called once per frame
    void Update()
    {
        // Updates the name of the active scene
        _currentScene = SceneManager.GetActiveScene();
        _sceneName = _currentScene.name;

        numPlayer = Physics2D.OverlapCircleNonAlloc(interactPos.position, interactRange, player, whatisPlayer);
        //Debug.Log(numPlayer);
        if (numPlayer > 0)
        {
            if (player[0].GetComponent<PlayerController>().inventory.Count > 0  && player[0].GetComponent<PlayerController>().inventory[0] == theKey)
            {
                hasItem = true;
                dialogueIndex = 1;
                if (!player[0].GetComponent<PlayerController>().hasDoorKey)
                {
                    player[0].GetComponent<PlayerController>().inventory.Add("key");
                    player[0].GetComponent<PlayerController>().hasDoorKey = true;
                    RuntimeManager.PlayOneShot(_stampDeliverRef, transform.position);
                }

                SetMusicParameter();
            }
            if (!uiPrompt.isDisplayed)
            {
                speech.text = "";
                uiPrompt.openPanel();
                _typingCoroutine = StartCoroutine(Typing());

            }
        }
        else
        {
            if (uiPrompt.isDisplayed)
            {
                uiPrompt.closePanel();
                StopCoroutine(_typingCoroutine);
            }
        }
    }

    // Sets FMOD parameters to change the music according to which level is currently loaded
    private void SetMusicParameter()
    {
        if(_sceneName == "Level02")
        {
            music_player.GetInstance()._mainBGMInstance.setParameterByName("Strings", 1);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(interactPos.position, interactRange);
    }

    IEnumerator Typing()
    {
        foreach(char letter in dialogue[dialogueIndex].ToCharArray())
        {
            speech.text += letter;
            RuntimeManager.PlayOneShot(_npcChatRef, transform.position);
            yield return new WaitForSeconds(wordSpeed);
        }
    }
}
