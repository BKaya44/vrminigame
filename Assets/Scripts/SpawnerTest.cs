using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTest : MonoBehaviour
{
    [SerializeField]
    private GameObject basketball;
    // Start is called before the first frame update
    public Vector3 specificVector3;
    public float radius = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Physics.CheckSphere(specificVector3, radius)) {
            //Instantiate(basketball, transform.position,transform.rotation);
        }
    }
    void OnCollisionEnter (Collision c){
        if (c.gameObject.tag != "Minigame"){
            //Destroy(c.gameObject);
            Instantiate(basketball, transform.position,transform.rotation);
        }
    }
}
