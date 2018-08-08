using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseVisControl : MonoBehaviour {
    [SerializeField]
    private List<GameObject> components;
    int currentLevel;

    void Start () {
        currentLevel = components.Count;
	}
    void ChangeLevel(int inc)
    {
        currentLevel = Mathf.Clamp(currentLevel + inc, 0, components.Count - 1);
        int ix = 0;
        foreach (GameObject go in components)
        {
            go.SetActive(ix <= currentLevel);
            ix++;
        }
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeLevel(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeLevel(-1);
        }

	}
}
