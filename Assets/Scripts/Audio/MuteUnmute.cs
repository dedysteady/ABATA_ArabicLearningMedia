using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteUnmute : MonoBehaviour
{
    private AudioSource player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        BgmMuteUnMute();

    }
    public void BgmMuteUnMute()
    {
        if (PlayerPrefs.GetInt("Backsound") == 1)
        {
            player.mute = true;
        }
        else
        {
            player.mute = false;
        }
    }

}
