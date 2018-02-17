using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockScript : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col){
		Destroy (gameObject);
	}
}
