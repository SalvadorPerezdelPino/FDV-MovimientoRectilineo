using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;
    private Vector3 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(goal.position); // Lo coloco en el update para poder jugar con el giro en tiempo real
        direction = goal.position - this.transform.position;
        this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        Debug.DrawRay(this.transform.position, direction, Color.red);
    }
}
