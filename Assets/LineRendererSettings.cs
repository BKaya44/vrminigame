using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineRendererSettings : MonoBehaviour
{
    [SerializeField] LineRenderer rend;

    Vector3[] points;

    public GameObject panel;
    public Button btn;
    
    void Start() {
            btn.onClick.AddListener(()=> {
                //panel.col

            }
            );
        rend = gameObject.GetComponent<LineRenderer>();

        points = new Vector3[2];

        points[0] = Vector3.zero;
        points[1] = transform.position + new Vector3(0,0,20);

        rend.SetPositions(points);
        rend.enabled = true;
    }

    void Update()
    {
        AlignLineRenderer(rend);
    }

    public LayerMask layerMask;

    public bool AlignLineRenderer(LineRenderer rend)
    {
        
        Ray ray;
        ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        bool hitBtn = false;

        if (Physics.Raycast(ray, out hit, layerMask))
        {
            btn = hit.collider.gameObject.GetComponent<Button>();
            rend.startColor = Color.red;
            rend.endColor = Color.red;
            points[1] = transform.forward + new Vector3(0, 0, hit.distance);
            hitBtn = true;
        }
        else
        {
            rend.startColor = Color.green;
            rend.endColor = Color.green;
            points[1] = transform.forward + new Vector3(0, 0, 20);
            hitBtn = false;
        }

        rend.SetPositions(points);
        rend.material.color = rend.startColor;
        return hitBtn;
    }
}
