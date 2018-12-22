using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsmove : MonoBehaviour {
    Rigidbody2D rgbd2d;
	// Use this for initialization
	void Start () {
        rgbd2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rgbd2d.velocity = new Vector2(-1, 0);
	}
}
