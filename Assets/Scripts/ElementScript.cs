using UnityEngine;
using System.Collections;

public class ElementScript : MonoBehaviour {
    public string name;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	   
	}
    void OnMouseDown() {
        Global.inputs.Add(name);
        foreach (string s in Global.inputs) {
            Debug.Log(s);
        }
    }
}
