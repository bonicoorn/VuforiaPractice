using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorScript : MonoBehaviour {

    Dropdown colorsDropdown;
    public Color[] colors;
    public Renderer renderer;

    void Start()
    {
        colorsDropdown = GetComponent<Dropdown>();
        colorsDropdown.onValueChanged.AddListener(delegate {
            DropdownValueChanged(colorsDropdown);
        });
        DropdownValueChanged(colorsDropdown);
    }

    //Ouput the new value of the Dropdown into Text
    void DropdownValueChanged(Dropdown change)
    {
        renderer.material.color = colors[change.value];
    }
}
