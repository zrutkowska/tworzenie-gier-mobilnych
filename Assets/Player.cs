using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject stick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton (0))
        {
            Vector3 v = stick.transform.localScale;
            v.y = +0.1f;
            stick.transform.localScale = v;
        }
        
    }
}
