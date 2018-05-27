using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesTran : MonoBehaviour {

	public GameObject[] levelBtn;

	void Start(){
		foreach (GameObject ele in levelBtn) {
			ele.SetActive (false);
		}
		for (int i = 0; i < PlayerPrefs.GetInt ("UserLevel", 1) ; i++) {
			levelBtn [i].SetActive (true);
		}
	}

	public void btnloadScenes (string lvl) {
		SceneManager.LoadScene (lvl);
	}
}
