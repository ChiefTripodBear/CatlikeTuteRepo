using UnityEngine;

public class KillZone : MonoBehaviour
{
    void OnTriggerEnter(Collider enteredCollider)
    {
        if (enteredCollider.CompareTag("KillZone"))
        {
            Destroy(gameObject);
        }
    }

}
