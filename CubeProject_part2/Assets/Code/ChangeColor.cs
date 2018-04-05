using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

	// Use this for initialization
    public Color cColor;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetColor(string color)
    {
        switch (color)
        {
            case "red": GetComponent<Renderer>().material.color = Color.red; break;
            case "green": GetComponent<Renderer>().material.color = Color.green; break;
            case "blue": GetComponent<Renderer>().material.color = Color.blue; break;
        }
    }
}
