using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class enemyai : MonoBehaviour
{
    public List<Transform> points;

    public int nextID=0;

    int idChangevalue =1;

    public float speed = 2;



    private void Reset()
    {
        Init();
    }

    void Init()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
        GameObject root = new GameObject(name + "_Root");
        root.transform.position =transform.position;
        transform.SetParent ( root.transform);
        
        GameObject waypoints = new GameObject("Waypoints");
        waypoints.transform.SetParent(root.transform);
        waypoints.transform.position = root.transform.position;
        GameObject p1 = new GameObject("Point1"); p1.transform.SetParent(waypoints.transform);p1.transform.position = root.transform.position;
        GameObject p2 = new GameObject("Point2"); p2.transform.SetParent(waypoints.transform);p2.transform.position = root.transform.position;

        points = new List<Transform>();
        points.Add(p1.transform);
        points.Add(p2.transform);
    }
    private void Update()
    {
        MoveToNextPoint();
    }

    void MoveToNextPoint()
    {
        Transform goalPoint = points[nextID];
        if (goalPoint.transform.position.x>transform.position.x)
            transform.localScale = new Vector3(-1,1,1);
        else
            transform.localScale = new Vector3(1,1,1); 
        transform.position = Vector2.MoveTowards(transform.position,goalPoint.position,speed*Time.deltaTime);
        if (Vector2.Distance(transform.position,goalPoint.position)<0.5f)
        {
            if (nextID ==points.Count -1)
                idChangevalue =-1;
            if (nextID == 0)
                idChangevalue =1;
            nextID+=idChangevalue;


        }
    }


}
