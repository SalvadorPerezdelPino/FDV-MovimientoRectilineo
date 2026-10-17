using UnityEngine;
using UnityEngine.InputSystem;

public class Exercise7 : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;
    public float accuracy = 0.01f;
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
        //direction = goal.position - this.transform.position;
        /*if(direction.magnitude > accuracy)
        {
            this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }*/
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, goal.position, step);
    }
}
