﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveScript : MonoBehaviour {

    public Vector3 destination;
    public Vector3 AgentCoords;
    NavMeshAgent agent;
    Animator animator;


    void Start()
    {
        //animator = agent.gameObject.GetComponent<Animator>();
        
    }

    void Update()
    {
        if (agent)
            AgentCoords = agent.transform.position;
        if (Input.GetMouseButtonUp(0))
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;
            if (Physics.Raycast(ray, out raycastHit, 1000))
            {
                agent.SetDestination(raycastHit.point);
                destination = raycastHit.point;
                if (animator)
                {
                    animator.SetTrigger("Walk");
                }
            }
        }
        if(animator)
        End();
    }

    void End()
    {
        if (agent.transform.position.x == destination.x && agent.transform.position.z == destination.z) { animator.SetTrigger("Stop");}
        
    }

    public void SetAgent(NavMeshAgent navMeshAgent)
    {
        if (agent != null)
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

    //NavMeshAgent agent;

    //void Start()
    //{
    //    agent = GetComponent<NavMeshAgent>();
    //}

    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        RaycastHit hit;

    //        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
    //        {
    //            agent.destination = hit.point;
    //        }
    //    }
    //}
}
