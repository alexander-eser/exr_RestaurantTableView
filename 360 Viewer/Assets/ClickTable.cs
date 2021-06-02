using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        foreach (var touch in Input.touches)
        {
            //Input.GetMouseButton(0) || 
            if (touch.phase == TouchPhase.Began)
            {
                

            }
        }
    }

}
