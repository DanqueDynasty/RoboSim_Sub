using UnityEngine;
using System.Collections;

public class RoboMove : MonoBehaviour {

    //Waypoints gathered from socket information here;
    Vector3 wayPoint,nextPoint;
    private bool jobComplete;
    private bool activate;
    private float SPEED = 10.0f;
    

	// Use this for initialization
	void Start () {
        //Get waypoint information here
        nextPoint = new Vector3(20.0f, 0.0f, 20.0f);
        wayPoint = new Vector3(0.0f, 0.0f, 3.0f);
        jobComplete = false;
        activate = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)){ activate = !activate; }
        if (activate)
        {
            float step = SPEED * Time.deltaTime;
            Vector3 direction = wayPoint - transform.position;
            if (!jobComplete)
            {
                transform.position = Vector3.MoveTowards(transform.position, wayPoint, step);
                Quaternion newRot = Quaternion.LookRotation(Vector3.RotateTowards(transform.forward, direction, step, 0.0f));
                transform.rotation = Quaternion.Slerp(transform.rotation, newRot, step);
                if (transform.position == wayPoint) { jobComplete = true; }
            }
            else {
                //Get New point
                wayPoint = nextPoint;
                jobComplete = false;
            }
        }
	}
}
