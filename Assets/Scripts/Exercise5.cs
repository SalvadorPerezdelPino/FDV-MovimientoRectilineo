using UnityEngine;
using UnityEngine.InputSystem;

public class Exercise5 : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;
    private Vector3 direction;
    [SerializeField] private InputActionReference incrementSpeedAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        FollowGoal();
        if (incrementSpeedAction.action.WasPerformedThisFrame())
        {
            speed += 1.0f;
        }
    }

    void FollowGoal()
    {
        this.transform.LookAt(goal.position);
        direction = goal.position - this.transform.position;
        this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }
}
