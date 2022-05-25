using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeControl : MonoBehaviour
{
    public AudioSource adSource;
    public AudioClip[] adClips;
    public GameObject scrollbar;
    float scrollpos = 0;
    float [] pos;
    int navigasi = 0;

    // Start is called before the first frame update
    void Start()
    {
        PlayAudio();
    }

    public void next(){
        if (navigasi < pos.Length - 1){
            navigasi += 1;
            scrollpos = pos [navigasi];
            PlayAudio();
        }
    }

    public void prev(){
        if (navigasi > 0){
            navigasi -= 1;
            scrollpos = pos [navigasi];
            PlayAudio();
        }
        
    }

    public void PlayAudio()
    {
        adSource.clip = adClips[navigasi];
        adSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        pos = new float[transform.childCount];
        float distance = 1f / (pos.Length - 1f);
        for (int i = 0; i < pos.Length; i++) {
            pos [i] = distance * i;
        }

        if (Input.GetMouseButton (0)) {
            scrollpos = scrollbar.GetComponent<Scrollbar> ().value;
        } else {
            for (int i = 0; i < pos.Length; i++) {
                if (scrollpos < pos [i] + (distance / 2) && scrollpos > pos [i] - (distance / 2)) {
                    scrollbar.GetComponent<Scrollbar> ().value = Mathf.Lerp (scrollbar.GetComponent<Scrollbar>().value, pos[i], 0.75f);
                    navigasi = i;
                }
            }
        }
    }
}
