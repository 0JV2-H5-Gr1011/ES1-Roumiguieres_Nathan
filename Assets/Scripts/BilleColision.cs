using UnityEngine;

public class BilleCollision : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Destructible"))
        {

            Destroy(collision.gameObject);
        }
    }
}