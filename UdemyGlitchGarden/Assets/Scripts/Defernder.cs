using UnityEngine;
using System.Collections;

public class Defernder : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2d(Collider2D name){
		Debug.Log (name + " trigger enter");
	}
}
