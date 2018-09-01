using UnityEngine;

public class shatterOnImpact : MonoBehaviour {

    public GameObject shattered;
    public int shatterForce;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > shatterForce)
        {
            GameObject.Instantiate(shattered, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
