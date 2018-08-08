using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointInfo : MonoBehaviour {

    [SerializeField]
    private string waypointTitle;

	void Start () {
		
	}
    public string GetTitle()
    {
        if (waypointTitle != null)
        {
            return waypointTitle;
        }
        else
        {
            return "untitled";
        }
    }
	void Update () {
		
	}
}
