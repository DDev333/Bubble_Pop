using UnityEngine;

public class BubbleMover : MonoBehaviour
{
    public float speed = 2.0f;

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime); 
    }
}
