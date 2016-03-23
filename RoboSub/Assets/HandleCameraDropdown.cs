using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HandleCameraDropdown : MonoBehaviour {
    public Camera[] cameras = new Camera[3];
    public Dropdown drpdwn;
	// Use this for initialization
	void Start () {
        drpdwn = GameObject.Find("CameraDropdown").GetComponent<Dropdown>();
        cameras[0] = GameObject.Find("Main Camera").GetComponent<Camera>();
        cameras[1] = GameObject.Find("TopDownCamera").GetComponent<Camera>();
        cameras[2] = GameObject.Find("FrontCamera").GetComponent<Camera>();

        cameras[0].gameObject.SetActive(true);
        cameras[1].gameObject.SetActive(false);
        cameras[2].gameObject.SetActive(false);
        drpdwn.onValueChanged.AddListener(delegate { valueChangedHandler(drpdwn); });
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private void valueChangedHandler(Dropdown target) {
        if (target.value == 0)
        {
            cameras[0].gameObject.SetActive(true);
            cameras[1].gameObject.SetActive(false);
            cameras[2].gameObject.SetActive(false);
        }
        else if (target.value == 1)
        {
            cameras[0].gameObject.SetActive(false);
            cameras[1].gameObject.SetActive(true);
            cameras[2].gameObject.SetActive(false);
        }
        else if (target.value == 2) {
            cameras[0].gameObject.SetActive(false);
            cameras[1].gameObject.SetActive(false);
            cameras[2].gameObject.SetActive(true);
        }
    }
}
