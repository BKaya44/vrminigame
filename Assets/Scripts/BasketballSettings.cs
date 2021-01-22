using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballSettings : MonoBehaviour
{
    [SerializeField] AudioSource basketballAudio;
    [SerializeField] AudioClip[] basketballSoundClips;
    [SerializeField] Rigidbody basketballBody;
    [SerializeField] private Vector3 respawnPosition;
    [SerializeField] GameObject basketball;
    void Start() {
        basketballAudio = GetComponent<AudioSource>();
        basketballBody = GetComponent<Rigidbody>();
    }

    void Update() {
     
    }

    void OnCollisionEnter (Collision c){
        basketballAudio.PlayOneShot(RandomClip());
        if (c.gameObject.tag != "Minigame"){
            basketball.transform.position = respawnPosition;
            basketball.transform.rotation = new Quaternion(0,0,0,0);
            basketballBody.velocity = new Vector3(0, 0, 0);
        }
    }
    AudioClip RandomClip(){
        return basketballSoundClips[Random.Range(0, basketballSoundClips.Length)];
    }
}
