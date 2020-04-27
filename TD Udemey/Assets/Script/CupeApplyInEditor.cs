using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(WayPoint))]


public class CupeApplyInEditor : MonoBehaviour
{
    WayPoint wayPoint;

    private void Awake()
    {
        wayPoint = GetComponent<WayPoint>();
    }

    private void Start()
    {
        
    }

    void Update()
    {
        SnapPosition();

        UpdateLabelAndName();
    }

    private void SnapPosition()
    {
        int gridSize = wayPoint.GetGridSize();
        transform.position = new Vector3(wayPoint.GetGridPos().x,0f,wayPoint.GetGridPos().y);
    }

    private void UpdateLabelAndName()
    {
        TextMesh posText;
        posText = GetComponentInChildren<TextMesh>();
        string cubeName = wayPoint.GetGridPos().x + "," + wayPoint.GetGridPos().y;
        gameObject.name = cubeName;
        posText.text = cubeName;
    }
}
