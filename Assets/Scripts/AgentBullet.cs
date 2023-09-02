using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentBullet : MonoBehaviour
{    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);

        //// Busca un TrailRenderer en los hijos del objeto
        //TrailRenderer trailRenderer = GetComponentInChildren<TrailRenderer>();

        //if (trailRenderer != null)
        //{
        //    // Resetea el TrailRenderer
        //    trailRenderer.Clear();
        //    trailRenderer.emitting = true; // Si el trail renderer tiene auto emisi�n, reactiva la emisi�n
        //}
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.TryGetComponent<Rigidbody2D>(out Rigidbody2D rd2d))
        {
            
        }
    }
}