using UnityEngine;
using System.Collections;

public class De : MonoBehaviour {
	public GameObject other;

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player"){
			Debug.Log ("DDD");
			Destroy (other);

		}
	}

}
