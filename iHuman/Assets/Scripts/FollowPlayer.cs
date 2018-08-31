using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
    public float rotationSpeed = 0.7f;
    public float smoothness = 0.1f;
    // Update is called once per frame
    void Start()
    {
        offset = transform.position - player.position;
        transform.LookAt(player);
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotationSpeed, Vector3.up);
            offset = camTurnAngle * offset;
            Vector3 newPosition = player.position + offset;
            transform.position = Vector3.Slerp(transform.position, newPosition, smoothness);
            transform.LookAt(player);
        }
        else
        {
            transform.position = player.position + offset;
        }
    }
}