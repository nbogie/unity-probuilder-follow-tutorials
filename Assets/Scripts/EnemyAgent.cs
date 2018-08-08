using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAgent : MonoBehaviour {
    GameObject[] waypoints;
    NavMeshAgent agent;

    private float lastSetDestTime;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        waypoints = GameObject.FindGameObjectsWithTag("Waypoint");
    }

    void Start () {
        SetRandomDestination();
        InvokeRepeating("SetRandomDestinationIfIdle", 1f, 8f);
	}
    private void SetRandomDestinationIfIdle()
    {
        if (Time.realtimeSinceStartup > lastSetDestTime + 7)
        {
            SetRandomDestination();
        }
        else
        {
            //too soon since last change, so do nothing.
        }
    }

    private void SetRandomDestination()
    {

        //List<GameObject> goList =  new List<GameObject>(waypoints);
        //GameObject found = goList.Find(go => go.name == "TunnelEnd");

        GameObject picked = waypoints[Random.Range(0, waypoints.Length)];
        WaypointInfo waypointInfo = picked.GetComponent<WaypointInfo>();
        if (waypointInfo)
        {
            string title = waypointInfo.name;
            Debug.Log(name + " dest: " + title);
        }
        agent.SetDestination(picked.transform.position);
        lastSetDestTime = Time.realtimeSinceStartup;
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SetRandomDestination();
        }
	}
}
