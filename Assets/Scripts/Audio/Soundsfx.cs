using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundsfx : MonoBehaviour
{
    public AudioClip rightAnswer;
    public AudioClip wrongAnswer;
    public AudioClip getReward;
    public AudioClip clickButton;

    private AudioSource player;

    private void Start()
    {
        player = GetComponent<AudioSource>();
    }

    public void PlayRightAnswer()
    {
        player.PlayOneShot(rightAnswer);
    }

    public void PlayWrongAnswer()
    {
        player.PlayOneShot(wrongAnswer);
    }

    public void PlayClick()
    {
        player.PlayOneShot(clickButton, 5f);
    }

    public void PlayGetReward()
    {
        player.PlayOneShot(getReward);
    }
}
