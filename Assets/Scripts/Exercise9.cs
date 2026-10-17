using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Exercise9 : MonoBehaviour
{
    public List<Transform> waypoints;
    private Transform goal;
    private int index = 0;
    private float progress = 0.0f;
    public float moveSpeed = 1.0f;
    public float rotationSpeed = 1.0f;
    public InputActionReference incrementSpeedAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        goal = waypoints[index];
    }

    // Update is called once per frame
    void Update()
    {
        FollowGoalRotation();
        if (Vector3.Distance(goal.transform.position, this.transform.position) < 0.001f)
        {
            NextGoal();
        }

        if (incrementSpeedAction.action.WasPerformedThisFrame())
        {
            moveSpeed += 1.0f;
        }
    }

    void FollowGoalRotation()
    {
        progress += Time.deltaTime * rotationSpeed;
        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, goal.position, step);
        Quaternion direction = Quaternion.LookRotation(goal.transform.position - this.transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, direction, progress);
    }

    void NextGoal()
    {
        progress = 0.0f;
        index = (index + 1) % waypoints.Count;
        goal = waypoints[index];
    }
}
