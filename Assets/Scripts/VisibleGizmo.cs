using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleGizmo : MonoBehaviour {
    [SerializeField]
    private Color c;
	
    void Start () {
		
	}
    private void OnDrawGizmos()
    {
        Gizmos.color = c;
        Gizmos.DrawWireSphere(transform.position, 0.8f);
    }

}
