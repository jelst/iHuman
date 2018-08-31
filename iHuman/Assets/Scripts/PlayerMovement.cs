using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform cam;
    public Transform playerRight;
    public Transform playerLeft;
    public Rigidbody player;
    public float forwardForce;
    public float forceDivider;
    public float wPressed;
    public float aPressed;
    public float sPressed;
    public float dPressed;
    public PlayerMovement playerMovement;
    public Vector3 offset;
    public Vector3 forceOffset;
    public static Vector3 UnitY;
    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if (playerMovement.enabled == false)
        {
            playerMovement.enabled = true;
        }
    }
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            wPressed = 1;
            forceDivider = wPressed + aPressed + sPressed + dPressed;
            player.AddForce((player.position.x - cam.position.x) * forwardForce / forceDivider, 0, (player.position.z - cam.position.z) * forwardForce / forceDivider);
        }
        else
        {
            wPressed = 0;
        }
        if (Input.GetKey("a"))
        {
            aPressed = 1;
            forceDivider = wPressed + aPressed + sPressed + dPressed;
            player.AddForce((player.position.x - playerRight.position.x) * forwardForce / forceDivider, 0, (player.position.z - playerRight.position.z) * forwardForce / forceDivider);
        }
        else
        {
            aPressed = 0;
        }
        if (Input.GetKey("s"))
        {
            sPressed = 1;
            forceDivider = wPressed + aPressed + sPressed + dPressed;
            player.AddForce(-(player.position.x - cam.position.x) * forwardForce / forceDivider, 0, -(player.position.z - cam.position.z) * forwardForce / forceDivider);
        }
        else
        {
            sPressed = 0;
        }
        if (Input.GetKey("d"))
        {
            dPressed = 1;
            forceDivider = wPressed + aPressed + sPressed + dPressed;
            player.AddForce((player.position.x - playerLeft.position.x) * forwardForce / forceDivider, 0, (player.position.z - playerLeft.position.z) * forwardForce / forceDivider);
        }
        else
        {
            dPressed = 0;
        }
    }
}