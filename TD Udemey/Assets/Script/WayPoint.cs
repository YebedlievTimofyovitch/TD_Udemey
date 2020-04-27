using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    Vector2Int gridPosition;

    private const int gridSize = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector2Int GetGridPos()
    {
        return new Vector2Int(
        Mathf.RoundToInt(transform.position.x / 10f) * gridSize,
        Mathf.RoundToInt(transform.position.z / 10f) * gridSize);
    }

    public int GetGridSize()
    {
        return gridSize;
    }

    public void SetTopColor(Color topColor)
    {
        MeshRenderer top = transform.Find("top").GetComponent<MeshRenderer>();
        top.material.color = topColor;
    }
}
