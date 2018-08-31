using UnityEngine;
using UnityEngine.UI;

public class Fuel : MonoBehaviour
{
    public Image fuelImage;
    public float fuelAmount = 100f;
    public float jumpForce = 200000f;
    public Rigidbody player;
    public Transform playerLauncher;
    public PlayerMovement playerMovement;
    public GameObject flames;
    
    void FixedUpdate()
    {
        if (fuelAmount != 100)
        {
            fuelAmount++;
            fuelImage.fillAmount = fuelAmount / 100;
            if (fuelAmount == 30)
            {
                flames.SetActive(false);
            }
        }
        else if (Input.GetKey("space") && fuelAmount == 100)
        {
            fuelAmount = 0;
            flames.SetActive(true);
            playerMovement.enabled = false;
            player.AddExplosionForce(jumpForce * Time.deltaTime, playerLauncher.position, 5);
            fuelImage.fillAmount = fuelAmount / 100;
        }
       
    }
}