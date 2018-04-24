using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class MoveScript : MonoBehaviour {

    Vector3 destination;
    NavMeshAgent agent;
    Animator animator;
    bool hasMove;

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
                    if (raycastHit.collider.tag != "UI")
                    {
                        agent.SetDestination(raycastHit.point);
                        destination = raycastHit.point;
                        if (animator && !hasMove)
                        {
                            animator.SetTrigger("Walk");
                            hasMove = true;
                        }
                    }

                }
            }
        }

        if(hasMove && animator)
        End();
    }

    void End()
    {
        if(Vector3.Distance(agent.transform.position,destination)<0.1f)
        {
            animator.SetTrigger("Stop");
            hasMove = false;
        }        
    }

    public void SetAgent(NavMeshAgent navMeshAgent)
    {
        if (agent)
        {
            var temp = navMeshAgent;
            temp.transform.position = agent.transform.position;
            agent = temp;
            agent.SetDestination(destination);
        }
        else
        {
            agent = navMeshAgent;
        }
        
    }

    public void SetAnimator(Animator animator)
    {
        this.animator = animator;
    }

    PointerEventData PointerData(int id)
    {
        var inst = EventSystem.current.currentInputModule as StandaloneModule;
        if (inst == null) return null;
        return inst.GetPointerEventData(id);
    }
}
