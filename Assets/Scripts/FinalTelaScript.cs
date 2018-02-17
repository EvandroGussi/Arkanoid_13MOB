using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalTelaScript : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col){
		SceneManager.LoadScene ("Intro");
	}
}
