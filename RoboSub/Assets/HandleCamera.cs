using UnityEngine;
using System.Collections;

public class HandleCamera : MonoBehaviour {
    public Camera[] cameras = new Camera[3];

	// Use this for initialization
	void Start () {
        cameras[0] = GameObject.Find("Main Camera").GetComponent<Camera>();
        cameras[1] = GameObject.Find("TopDownCamera").GetComponent<Camera>();
        cameras[2] = GameObject.Find("FrontCamera").GetComponent<Camera>();

        cameras[0].gameObject.SetActive(true);
        cameras[1].gameObject.SetActive(false);
        cameras[2].gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            cameras[0].gameObject.SetActive(true);
            cameras[1].gameObject.SetActive(false);
            cameras[2].gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            cameras[0].gameObject.SetActive(false);
            cameras[1].gameObject.SetActive(true);
            cameras[2].gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)) {
            cameras[0].gameObject.SetActive(false);
            cameras[1].gameObject.SetActive(false);
            cameras[2].gameObject.SetActive(true);
        }
    }
}
