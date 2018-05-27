using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisCharage : MonoBehaviour {

	void Start () {
		// Run here to auto clear without btn
		// PlayerPrefs.SetInt ("UserLevel", 1);
	}
	// use with btn
	public void btnClearCache () {
		PlayerPrefs.SetInt ("UserLevel", 1);
	}
}
