using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed = 2F;

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
