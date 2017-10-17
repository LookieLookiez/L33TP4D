using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterNumbers : MonoBehaviour {

    public GameObject[] buttons;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            //empty RaycastHit object which raycast puts the hit details into
            RaycastHit hit;
            //ray shooting out of the camera from where the mouse is
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Button"))
                {
                    PrintToScreen.Instance.InputNext(hit.collider.gameObject.GetComponent<MyChar>().myChar) ;
                }
                if (hit.collider.CompareTag("Clear"))
                {
                    PrintToScreen.Instance.readOut = "";
                }
                if (hit.collider.CompareTag("Toggle"))
                {
                    
                    for (int i = 0; i < buttons.Length; i++)
                    {
                        if(buttons[i].GetComponent<MyChar>().numbers == true)
                        {
                            buttons[i].GetComponent<MyChar>().myChar = buttons[i].GetComponent<MyChar>().myLet;
                            buttons[i].GetComponent<MyChar>().numbers = false;
                        }
                        else
                        {
                            buttons[i].GetComponent<MyChar>().myChar = buttons[i].GetComponent<MyChar>().myNum;
                            buttons[i].GetComponent<MyChar>().numbers = true;
                        }
                    }
                }
            }
        }
    }

}
