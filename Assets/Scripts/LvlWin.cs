using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlWin : MonoBehaviour {
	public int thisLevel = 1;
	public bool lastLevel =false;
	public void btnGotoMap () {
		if (thisLevel >= PlayerPrefs.GetInt ("UserLevel", 1) && !lastLevel) {
			PlayerPrefs.SetInt ("UserLevel", thisLevel + 1);
		}
		SceneManager.LoadScene ("_Map");
	}
}
