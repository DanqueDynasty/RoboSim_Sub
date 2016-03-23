using UnityEngine;
using System.Collections;
using System;

public class Robo_Idle : MonoBehaviour {
    private float yBounds;

	// Use this for initialization
	void Start () {
        yBounds = 10.0f;
	}
	
	// Update is called once per frame
	void Update () {
        float y = transform.position.y;
        float _t = Time.deltaTime;
        //y += yBounds * Convert.ToFloat(Math.Sin(Convert.ToDouble(_t)));
        y += yBounds * Convert.ToSingle(Math.Sin(Convert.ToDouble(_t)));
        transform.position.Set(transform.position.x, y, transform.position.z);
	}
}
