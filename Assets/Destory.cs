using UnityEngine;
using System.Collections;

public class Destory : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		Destroy (col.gameObject);
	}
		
}
