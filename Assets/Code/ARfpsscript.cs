using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARfpsscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Debug.Log(QualitySettings.vSyncCount);
        QualitySettings.vSyncCount = 0;
        //Debug.Log(Application.targetFrameRate);
        Application.targetFrameRate = 300;
    }

}
