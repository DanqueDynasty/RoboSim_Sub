using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HandleArenaEditor : MonoBehaviour {
    GameObject arenaPanel;
    Button optButton;
	// Use this for initialization
	void Start () {
        arenaPanel = GameObject.Find("SceneEditorPanel");
        optButton = GameObject.Find("EditSceneBtn").GetComponent<Button>();
        arenaPanel.SetActive(false);
        optButton.onClick.AddListener(delegate { toggleArenaPanel(); });
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void toggleArenaPanel() {
        arenaPanel.SetActive(!arenaPanel.activeSelf);
    }
}
