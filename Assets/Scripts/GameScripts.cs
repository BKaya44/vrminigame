using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScripts : MonoBehaviour
{
    [SerializeField] AudioSource music;
    [SerializeField] Text score;
    int scoreTotal = 0;
    
    void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume")) {
            music.volume = PlayerPrefs.GetFloat("musicVolume");
        } else {
            music.volume = 0.2F;
        }
        if (PlayerPrefs.HasKey("basketballMinigameScore")) {
            scoreTotal = PlayerPrefs.GetInt("basketballMinigameScore");
        } else {
            scoreTotal = 10;
        }
    }

    void Update()
    {
        if(PlayerPrefs.GetInt("basketballMinigameScore") != scoreTotal) {
            scoreTotal = PlayerPrefs.GetInt("basketballMinigameScore");
        }
        score.text = "Score: " + scoreTotal.ToString();
    }
}
