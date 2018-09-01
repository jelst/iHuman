using UnityEngine;

public class attachmentUpgrade : MonoBehaviour {
    public Transform player;
    public GameObject upgradeObject;
    public float positionX;
    public float positionY;
    public float positionZ;
    // Update is called once per frame
    void Update()
    {
        if (player.position.x < (positionX + 1) && player.position.x > (positionX - 1) && player.position.z < (positionZ + 1) && player.position.z > (positionZ - 1) && player.position.y < (positionY + 1) && player.position.y > (positionY - 1))
        {
            upgradeObject.GetComponent<BoxCollider>().enabled = true;
            upgradeObject.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
