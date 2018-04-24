using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

    Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    public void SetColor(string color)
    {
        if (!renderer) Start();
        switch (color)
        {
            case "red":
                renderer.material.color = Color.red;
                break;
            case "green":
                renderer.material.color = Color.green;
                break;
            case "blue":
                renderer.material.color = Color.blue;
                break;
        }

    }
}
