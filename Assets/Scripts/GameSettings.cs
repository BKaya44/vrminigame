using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{
    
    [SerializeField] private AudioSource music;
    [SerializeField] private Toggle musicToggle;
    [SerializeField] private Slider musicSlider;

    void start(){
        musicSlider.maxValue = 1; 
        musicSlider.minValue = 0;
    }
    void Update() {
        if (PlayerPrefs.HasKey("music")) {
            if(musicToggle.isOn){
                PlayerPrefs.SetInt("music", 1);
                musicToggle.isOn = true;
                music.enabled = true;
            } else {
                PlayerPrefs.SetInt("music", 0);
                musicToggle.isOn = false;
                music.enabled = false;
            }
        }
    }

    void OnEnable() {
        musicSlider.onValueChanged.AddListener(delegate { changeVolume(musicSlider.value); });
    }

    public void changeVolume(float volume){
        music.volume = volume;
        PlayerPrefs.SetFloat("musicVolume", volume);
        PlayerPrefs.Save();
    }
    
    public void Awake () {
        //Check if player has music key and makes one if user doesn't have one.
        if (!PlayerPrefs.HasKey("musicVolume")) {
            PlayerPrefs.SetFloat("musicVolume", 0);
            PlayerPrefs.Save();
        } else {
            music.volume = PlayerPrefs.GetFloat("musicVolume");
            musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        }
        if (!PlayerPrefs.HasKey("music")) {
            PlayerPrefs.SetInt("music", 1);
            musicToggle.isOn = true;
            music.enabled = true;
            PlayerPrefs.Save();
        } else {
            //Check if music is turned on or not.
            if (PlayerPrefs.GetInt ("music") == 0) {
                music.enabled = false;
                musicToggle.isOn = false;
            } else {
                music.enabled = true;
                musicToggle.isOn = true;
            }
        }
  }

}
