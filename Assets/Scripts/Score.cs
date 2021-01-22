using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] GameObject effect;
    [SerializeField] AudioSource scoreSound;
    void Start()
    {
        //Check if player has basketball minigame score
        if (!PlayerPrefs.HasKey("basketballMinigameScore")) {
            PlayerPrefs.SetInt("basketballMinigameScore", 0);
            PlayerPrefs.Save();
        }
        effect.SetActive(false);
    }

    void OnTriggerEnter (Collider c){
        //Check if object is basketball
        if (c.gameObject.tag == "Ball"){
            setBasketballScore(getBasketballScore() + 1);
            effect.SetActive(true);
        } else {
            effect.SetActive(false);
        }
    }

    void setBasketballScore(int score){
        PlayerPrefs.SetInt("basketballMinigameScore", score);
        PlayerPrefs.Save();
    }

    int getBasketballScore(){
        return PlayerPrefs.GetInt("basketballMinigameScore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
