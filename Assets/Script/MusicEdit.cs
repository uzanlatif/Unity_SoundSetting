using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicEdit : MonoBehaviour
{
    public Slider SliderAmbience;
    public Slider SliderMusic;
    float volumeAmbience;
    float volumeMusic;

    public void Start()
    {
        FindObjectOfType<AudioManager>().Play("Ambience");
        FindObjectOfType<AudioManager>().Play("Music");
    }

    public void ChangeVlmAmbience(){

        volumeAmbience = SliderAmbience.value;
        FindObjectOfType<AudioManager>().ChangeVolume("Ambience",volumeAmbience);

    }

    public void ChangeVlmMusic(){

        volumeMusic = SliderMusic.value;
        FindObjectOfType<AudioManager>().ChangeVolume("Music",volumeMusic);

    }
}
