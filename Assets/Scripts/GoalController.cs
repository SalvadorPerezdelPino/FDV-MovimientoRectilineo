using UnityEngine;
using UnityEngine.InputSystem;

public class GoalController : MonoBehaviour
{
    public float speed = 1.0f;
    [SerializeField] private InputActionReference movementAction;
    [SerializeField] private InputActionReference incrementSpeedAction;

    private Vector2 movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = movementAction.action.ReadValue<Vector2>();
        this.transform.position += new Vector3(movement.x, 0, movement.y) * speed * Time.deltaTime;
        if (incrementSpeedAction.action.WasPerformedThisFrame())
        {
            speed += 1.0f;
        }
    }
}
