using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour
{
    Dictionary<Vector2Int, WayPoint> grid = new Dictionary<Vector2Int, WayPoint>();

    // Start is called before the first frame update
    void Start()
    {
        LoadBlocks();
    }

    private void LoadBlocks()
    {
        WayPoint[] waypoints = FindObjectsOfType<WayPoint>();
        foreach(WayPoint waypoint in waypoints)
        {
            bool isOverLapping = grid.ContainsKey(waypoint.GetGridPos());
            if(isOverLapping)
            {
                Debug.LogError("blocks are overlapping");
                return;
            }

            waypoint.SetTopColor(Color.yellow);

            grid.Add(waypoint.GetGridPos(), waypoint);
            print(grid.Count);
        }
    }
}
