using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class MoveScript : MonoBehaviour {

    public NavMeshAgent agent;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var data = PointerData(-1);

            if(!data.selectedObject)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit raycastHit;
                if (Physics.Raycast(ray, out raycastHit, 1000))
                {
                    agent.SetDestination(raycastHit.point);
                }
            }
        }
    }


    PointerEventData PointerData(int id)
    {
        var inst = EventSystem.current.currentInputModule as StandaloneModule;
        if (inst == null) return null;
        return inst.GetPointerEventData(id);
    }
}
