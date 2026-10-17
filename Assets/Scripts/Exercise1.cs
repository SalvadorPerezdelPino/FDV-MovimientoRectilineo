using UnityEngine;
using UnityEngine.UIElements;

public class Exercise1 : MonoBehaviour
{
    public Vector3 goal;

    public float multiplier;

    private Vector3 planePosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // this.transform.Translate(goal);
        // Con valores de multiplier mayores que 1, el goal tiende a infinito
        // Con valores de multiplier menores que 1, el goal tiende a desplazarse en las unidades del vector
        // goal = goal * multiplier;
        MoveAsPlane();
    }

    void MoveAsPlane()
    {
        planePosition = planePosition + new Vector3(0.1f, 0.01f, 0f) * Time.deltaTime;
        this.transform.Translate(planePosition);
    }
}
