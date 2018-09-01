using UnityEngine;

public class contactEnable : MonoBehaviour {
    public Transform player;
    public GameObject enabledObject;
    public float positionX;
    public float positionY;
    public float positionZ;
    // Update is called once per frame
    void Update()
    {
        if (player.position.x < (positionX + 1) && player.position.x > (positionX - 1) && player.position.z < (positionZ + 1) && player.position.z > (positionZ - 1) && player.position.y < (positionY + 1) && player.position.y > (positionY - 1))
        {
            enabledObject.SetActive(true);
        }
    }
}
