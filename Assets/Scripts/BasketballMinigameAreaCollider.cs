using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketballMinigameAreaCollider : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text scoreText;
    bool visible = true;

     private Transform target = null;
    void OnTriggerEnter(Collider other) {
        Debug.Log("Made A collision");
        if (other.tag == "Player") visible = true;
    }
    
    void OnTriggerExit(Collider other) {
        if (other.tag == "Player") visible = false;
    }
    void Start()
    {
        scoreText.gameObject.SetActive(visible);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.gameObject.SetActive(visible);
    }
}
