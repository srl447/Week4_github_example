using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finale : MonoBehaviour {

    public static bool ends = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider end)
    {       
            ends = true;
    }
}
