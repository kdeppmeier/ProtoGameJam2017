using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSlider : MonoBehaviour {

    public Slider Volume;
    public AudioSource music;
    // Update is called once per frame
    void Start()
    {
        Volume.value = 0.5f;     
    }
    void Update () {
        music.volume = Volume.value;
	}
}
