using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValText : MonoBehaviour {
    public GameObject button;
    private Text myText;
	// Use this for initialization
	void Start () {
        myText = this.gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        myText.text = button.GetComponent<MyChar>().myChar.ToString();
	}
}
