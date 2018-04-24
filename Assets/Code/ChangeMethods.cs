using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMethods : MonoBehaviour {

    Renderer renderer;
    MeshFilter meshFilter;

    void Start()
    {
        meshFilter = gameObject.GetComponent<MeshFilter>();
        renderer = GetComponent<Renderer>();
    }

    public void ChangeObject(Mesh mesh)
    {
        meshFilter.mesh = mesh;
    }

    public void ChangeColor(string color)
    {
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
