using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;

    private AudioSource player;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
            
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        player = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        if (currentScene.name == "Tebak Angka" || currentScene.name == "Tebak Suara" ||
           currentScene.name == "Tebak Huruf" || currentScene.name == "Belajar 1" || currentScene.name == "Belajar 2" ||
            currentScene.name == "Belajar 3" || currentScene.name == "Belajar 4" || currentScene.name == "Belajar 5")
        {
            Destroy(gameObject);
        }
    }
}
