using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float health;

	// Use this for initialization
	void Start () {
	
	}
	
	public void DealDamage(float damage, GameObject attacker){
		health -= damage;

		if(health <= 0){
			DestroyObject();
			attacker.GetComponent<Animator> ().SetBool ("isAttacking", false);
		}
	}

	public void DestroyObject(){
		Destroy (gameObject);
	}
}
