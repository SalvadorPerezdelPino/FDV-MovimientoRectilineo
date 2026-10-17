using UnityEngine;

public class Excercise2 : MonoBehaviour
{
    public Vector3 goal;
    public float speed = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(goal.normalized * speed * Time.deltaTime);
    }
}
