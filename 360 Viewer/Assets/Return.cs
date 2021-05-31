﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour
{
    // Start is called before the first frame update    
    void Start() { }

    // Update is called once per frame    
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Ended)
            {

                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    //Select stage    
                    if (hit.transform.name == "Sphere")
                    {
                        SceneManager.LoadScene("SampleScene");
                    }
                }
            }
        }
    }
}
