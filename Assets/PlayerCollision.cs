using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void Update()
    {
        // Mendeteksi objek di depan pemain
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1.0f))
        {
            Collider hitCollider = hit.collider;

            // Mengecek apakah objek yang ditemui memiliki tag tertentu (misalnya, "Obstacle")
            if (hitCollider != null && hitCollider.CompareTag("Obstacle"))
            {
                // Mencegah pemain bergerak ke dalam objek dengan membatalkan perubahan posisi
                transform.position = transform.position - hit.distance * transform.forward;
            }
            else
            {
                // Objek lain yang dapat ditembus, tidak mempengaruhi pergerakan pemain
            }
        }
    }
}
