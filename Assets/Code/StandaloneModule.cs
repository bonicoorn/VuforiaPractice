using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StandaloneModule : StandaloneInputModule {

    public PointerEventData GetPointerEventData(int id)
    {
        return GetLastPointerEventData(id);
    }
}
