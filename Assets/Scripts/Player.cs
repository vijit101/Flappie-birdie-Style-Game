using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private void OnCollisionEnter2D(Collision2D colz)
    {
        if (colz.gameObject.tag == "Obstacle")
        {
            Utils.reloadlvl();
        }
    }

    Rigidbody2D rgbd;
    public float forcez =2,movespeed = 2;
	// Use this for initialization
	void Start () {
        rgbd = GetComponent<Rigidbody2D>();
        Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
        move();
	}
    public void move()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1;
            rgbd.AddForce(Vector2.up * forcez,ForceMode2D.Impulse);
        }
    }
}
