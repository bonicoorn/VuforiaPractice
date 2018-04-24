using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeFiguresScript : MonoBehaviour {

    Dropdown figuresDropdown;
    public Mesh[] meshes;
    public MeshFilter meshFilter;

    void Start()
    {
        figuresDropdown = GetComponent<Dropdown>();
        figuresDropdown.onValueChanged.AddListener(delegate {
            DropdownValueChanged(figuresDropdown);
        });
    }

    //Ouput the new value of the Dropdown into Text
    void DropdownValueChanged(Dropdown change)
    {
        meshFilter.mesh = meshes[change.value];
    }
}
