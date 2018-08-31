using UnityEngine;

public class FlamesFollow : MonoBehaviour {

    public Transform player;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position;
        transform.rotation = player.rotation;
    }
}
