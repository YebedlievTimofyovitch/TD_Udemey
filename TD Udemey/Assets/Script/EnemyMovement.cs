using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<WayPoint> path;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveAlongWaypoints());
    }

    private IEnumerator MoveAlongWaypoints()
    {
        foreach (WayPoint point in path)
        {
            transform.position = point.transform.position;
            yield return new WaitForSeconds(1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
