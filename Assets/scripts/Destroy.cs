using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    void Start()
    {
        // Start the coroutine when the object is activated
        StartCoroutine(DestroyAfterDelay(6f));
    }

    IEnumerator DestroyAfterDelay(float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Destroy the game object after the delay
        Destroy(gameObject);
    }
}
