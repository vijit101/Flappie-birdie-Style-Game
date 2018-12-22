using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPad : MonoBehaviour {
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Utils.loadnextlvl();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
