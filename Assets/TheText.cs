using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TheText : MonoBehaviour
{
    Text text;
    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Finale.ends)
        {
            text.text = "I'm Sorry. I was in Pittsburgh all weekend, and I had no time to get work done.";
            
        }
    }
}
