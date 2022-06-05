using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hijaiyah : MonoBehaviour
{
    public Image _asli;
    public Sprite _hijaiyah;
    public Text _namaHuruf;
    public string namaHuruf;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void changeHuruf()
    {
        _asli.sprite = _hijaiyah;
        _namaHuruf.text = namaHuruf;
    }
}
