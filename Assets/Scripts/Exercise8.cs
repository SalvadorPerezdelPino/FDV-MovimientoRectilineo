using UnityEngine;
using UnityEngine.InputSystem;

public class Exercise8 : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;
    public float rotationSpeed = 1.0f;
    [SerializeField] private float progress = 0.0f;
    private Vector3 previousPosition;

    [SerializeField] private InputActionReference incrementSpeedAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        previousPosition = goal.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        FollowGoalRotation();
        if (incrementSpeedAction.action.WasPerformedThisFrame())
        {
            speed += 1.0f;
        }
    }

    void FollowGoalRotation()
    {
        if (goal.transform.position == previousPosition)
        {
            progress += Time.deltaTime * rotationSpeed;
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, goal.position, step);
            Quaternion direction = Quaternion.LookRotation(goal.transform.position - this.transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, direction, progress);
        } else
        {
            progress = 0.0f;
            previousPosition = goal.transform.position;
        }
    }
}
