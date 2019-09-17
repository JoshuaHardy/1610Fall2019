using UnityEngine;
public class Movement : MonoBehaviour
{
    public float speed = 1f;
    public float gravity = 3f;
    public float jumpSpeed = 10f;

    private int jumpCount = 1;
    
    private Vector3 position;
    public CharacterController controller;
    void Update()
    {
        position.x = speed*Input.GetAxis("Horizontal");

        if (!controller.isGrounded )
        {
            position.y -= gravity;
        }
        else
        {
            jumpCount = 1;
        }

        if (Input.GetButtonDown("Jump") && jumpCount > 0)
        {
            position.y = jumpSpeed;
            jumpCount--;
        }
        controller.Move(position*Time.deltaTime);
    }
}