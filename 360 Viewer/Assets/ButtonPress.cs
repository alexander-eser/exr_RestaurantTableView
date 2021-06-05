using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPress : MonoBehaviour
{
    bool state;
    
    // Start is called before the first frame update    
    void Start()
    {
       GetComponent<Renderer>().enabled = false;
       
       foreach (Transform child in transform) {
            child.gameObject.SetActive(false);
       }
    }

    // Update is called once per frame    
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                if (Camera.main != null)
                {
                    state = !state;
                    Ray ray = Camera.main.ScreenPointToRay(touch.position);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.transform.tag == "Button")
                        {
                            
                            foreach (Transform child in transform)
                            {
                                child.gameObject.SetActive(state); 
                                
                            }

                        }
                    }
                }
            }
        }
    }
    
}
