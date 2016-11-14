using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

	private float currentSpeed;
	private GameObject currentTarget;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * currentSpeed * Time.deltaTime, Space.World);
	}

	void OnTriggerEnter2D(Collider2D name){
		//Debug.Log (name + " trigger enter");
	}

	public void SetSpeed(float speed) {
		currentSpeed = speed;
	}

	// Called from the Animator at time of the acutal attack
	public void StrikeCurrentTarget(float damage){
		Debug.Log ("Hit for " + damage + " dmg");
		currentTarget.GetComponent<Health> ().DealDamage (damage, gameObject);
	}

	public void Attack(GameObject obj){
		currentTarget = obj;

	}
}
