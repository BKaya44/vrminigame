using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLightController : MonoBehaviour
{
    float duration = 5.0f;
    [SerializeField]Color firstColor = Color.blue;
    [SerializeField]Color secondColor = Color.yellow;
    Light lightController;
    
    void Start()
    {
        lightController = GetComponent<Light>();
    }

    void Update()
    {
        float delay = Mathf.PingPong(Time.time, duration) / duration;
        lightController.color = Color.Lerp(firstColor, secondColor, delay);

    }
}
