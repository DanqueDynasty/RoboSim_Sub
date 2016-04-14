using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class HandleTransformPanel : MonoBehaviour {
    GameObject transformPanel;
	GameObject robosub;
	InputField transX;
	InputField transY;
	InputField transZ;

	InputField rotX;
	InputField rotY;
	InputField rotZ;

	// Use this for initialization
	void Start () {
		transformPanel = GameObject.Find ("TransformPanel");
		robosub = GameObject.Find ("subModel");

		transX = GameObject.Find ("Input_TransX").GetComponent<InputField> ();
		transY = GameObject.Find ("Input_TransY").GetComponent<InputField> ();
		transZ = GameObject.Find ("Input_TransZ").GetComponent<InputField> ();

		transX.onValueChanged.AddListener ( delegate {
			robo_ChangeTranslateX();
		} );
		transY.onValueChanged.AddListener (delegate {
			robo_ChangeTranslateY();
		});

		transZ.onValueChanged.AddListener (delegate {
			robo_ChangeTranslateZ();	
		});

		rotX = GameObject.Find ("Input_RotX").GetComponent<InputField> ();
		rotY = GameObject.Find ("Input_RotY").GetComponent<InputField> ();
		rotZ = GameObject.Find ("Input_RotZ").GetComponent<InputField> ();

		rotX.onValueChanged.AddListener (delegate {
			robo_ChangeRotateX();
		});

		rotY.onValueChanged.AddListener (delegate {
			robo_ChangeRotateY();	
		});

		rotZ.onValueChanged.AddListener (delegate {
			robo_ChangeRotateZ();	
		});

		transX.text = Convert.ToString (robosub.transform.position.x);
		transY.text = Convert.ToString (robosub.transform.position.y);
		transZ.text = Convert.ToString (robosub.transform.position.z);

		rotX.text = Convert.ToString (robosub.transform.rotation.x);
		rotY.text = Convert.ToString (robosub.transform.rotation.y);
		rotZ.text = Convert.ToString (robosub.transform.rotation.z);
		transformPanel.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Alpha5)) {
            Debug.Log("Toggling Visibility");
			bool state = !transformPanel.activeSelf;
			transformPanel.SetActive (state);
		}
		if (transformPanel.activeSelf) {
			transX.text = Convert.ToString (robosub.transform.position.x);
			transY.text = Convert.ToString (robosub.transform.position.y);
			transZ.text = Convert.ToString (robosub.transform.position.z);

			rotX.text = Convert.ToString (robosub.transform.rotation.x);
			rotY.text = Convert.ToString (robosub.transform.rotation.y);
			rotZ.text = Convert.ToString (robosub.transform.rotation.z);
		}
	}

	public void robo_ChangeTranslateX(){
		robosub.transform.position = new Vector3 (float.Parse(transX.text), robosub.transform.position.y, robosub.transform.position.z);
	}

	public void robo_ChangeTranslateY(){
		robosub.transform.position = new Vector3 (robosub.transform.position.x, float.Parse(transY.text), robosub.transform.position.z);
	}

	public void robo_ChangeTranslateZ(){
		robosub.transform.position = new Vector3 (robosub.transform.position.x, robosub.transform.position.y, float.Parse(transZ.text));
	}

	public void robo_ChangeRotateX(){
	
	}

	public void robo_ChangeRotateY(){
		
	}

	public void robo_ChangeRotateZ(){
		
	}
}
