using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingtossSettings : MonoBehaviour
{
    [SerializeField] GameObject ring;
    [SerializeField] Rigidbody ringBody;
    [SerializeField] private Vector3 respawnPosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter (Collision c){
        //basketballAudio.PlayOneShot(RandomClip());
        if (c.gameObject.tag == "RingScoreCone"){
            ring.transform.position = respawnPosition;
            ring.transform.rotation = new Quaternion(0,0,0,0);
            ringBody.velocity = new Vector3(0, 0, 0);
        }
    }
}
