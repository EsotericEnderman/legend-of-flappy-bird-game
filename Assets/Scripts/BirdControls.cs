using Unity.VisualScripting;
using UnityEngine;

public class BirdControls : MonoBehaviour
{

    private readonly KeyCode upButton = KeyCode.Space;

    private new Rigidbody2D rigidbody;

    private readonly float jumpForce = 5F;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown((int) MouseButton.Left) || Input.GetKeyDown(upButton))
        {
            rigidbody.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.GameOver();
    }
}
