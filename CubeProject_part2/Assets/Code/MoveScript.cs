using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveScript : MonoBehaviour {

    public NavMeshAgent agent;

    void Start()
    {
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButtonUp(0))
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log(ray.ToString());
            RaycastHit raycastHit;
            if (Physics.Raycast(ray, out raycastHit, 500))
            {
                agent.SetDestination(raycastHit.point);
            }
        }
    }


    //   [SerializeField]
    //   Transform destination;

    //   NavMeshAgent navMeshAgent;
    //// Use this for initialization
    //void Start () {
    //       navMeshAgent = this.GetComponent<NavMeshAgent>();

    //       if (navMeshAgent == null)
    //       {
    //           Debug.LogError("not isset" + gameObject.name);
    //       }
    //       else
    //       {
    //           SetDestination();
    //       }
    //}

    //   private void SetDestination()
    //   {
    //       if (destination != null)
    //       {
    //           Vector3 targetVector = destination.transform.position;
    //           navMeshAgent.SetDestination(targetVector);
    //       }
    //   }
}
