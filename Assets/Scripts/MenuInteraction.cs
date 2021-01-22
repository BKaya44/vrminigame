using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuInteraction : MonoBehaviour
{
    public Button play, exit;
    
    void Start() {
        play.onClick.AddListener(() => loadGame(1));
        exit.onClick.AddListener(() => closeGame());
    }

    void Update() {
    }

    private void loadGame(int scene){
        SceneManager.LoadScene(scene);
    }

    private void closeGame(){
        Application.Quit();
    }
}
