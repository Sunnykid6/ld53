using FMODUnity;
using FMOD.Studio;
using UnityEngine;
using UnityEngine.SceneManagement;

public class music_player : MonoBehaviour
{
    private static music_player instance;

    [SerializeField] private EventReference _mainBGMRef;

    public EventInstance _mainBGMInstance;
    private Scene _currentScene;
    private string _sceneName;


    public static music_player GetInstance()
    {
        return instance;
    }

    private void Awake()
    {
        ManageSingleton();
    }

    void ManageSingleton()
    {
        if (instance != null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }

        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        _mainBGMInstance = RuntimeManager.CreateInstance(_mainBGMRef);
        _mainBGMInstance.start();
    }

    void Update()
    {
        // Updates the name of the active scene
        _currentScene = SceneManager.GetActiveScene();
        _sceneName = _currentScene.name;

        if (_sceneName == "Tutorial")
        {
            music_player.GetInstance()._mainBGMInstance.setParameterByName("music_segment", 0);
            music_player.GetInstance()._mainBGMInstance.setParameterByName("Band", 0);
            music_player.GetInstance()._mainBGMInstance.setParameterByName("Strings", 0);
            music_player.GetInstance()._mainBGMInstance.setParameterByName("Brass", 0);
        }

        else if (_sceneName == "Level01")
        {
            music_player.GetInstance()._mainBGMInstance.setParameterByName("music_segment", 1);
            music_player.GetInstance()._mainBGMInstance.setParameterByName("Band", 1);
        }

        else if (_sceneName == "Level04")
        {
            music_player.GetInstance()._mainBGMInstance.setParameterByName("Brass", 1);            
        }
    }
}
