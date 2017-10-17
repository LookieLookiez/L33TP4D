using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintToScreen : MonoBehaviour
{
    public static PrintToScreen Instance;
    public string readOut;
    public Text readOutText;

    // Use this for initialization
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        readOutText.text = readOut;
    }

    public void InputNext(char value)
    {
        readOut = readOut + value;
    }
}
