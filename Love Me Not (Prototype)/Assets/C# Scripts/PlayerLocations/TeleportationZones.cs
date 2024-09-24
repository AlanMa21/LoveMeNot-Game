using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationZones : MonoBehaviour
{
    public Vector2 teleportDestination;
    public bool shouldResetVelocity = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Teleport(other.gameObject);
        }
    }

    private void Teleport(GameObject player)
    {
        player.transform.position = teleportDestination;

        if (shouldResetVelocity)
        {
            Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = Vector2.zero;
            }
        }
    }
}
