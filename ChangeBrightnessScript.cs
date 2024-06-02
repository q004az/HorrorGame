using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBrightnessScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeBrightness(float var)
    {
        Text text = GetComponent<Text>();
        text.text = "Освещение " + (var * 100);
    }
}
