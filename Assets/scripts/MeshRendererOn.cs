using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeshRendererOn : MonoBehaviour
{
    // Reference to the Mesh Renderer component
    private MeshRenderer meshRenderer;
    bool isEnabled = false;

    void Start()
    {
        // Get the Mesh Renderer component attached to this GameObject
        meshRenderer = GetComponent<MeshRenderer>();
        
        // Ensure we have a valid Mesh Renderer component
        if (meshRenderer == null)
        {
            Debug.LogError("Mesh Renderer component not found on this GameObject.");
            return;
        }

        // Initially, disable the Mesh Renderer
        meshRenderer.enabled = false;
    }

    void OnMouseDown()
    { 
        // enable the lights and make sure this will happen once.
        if (!isEnabled) 
        {
            meshRenderer.enabled = !meshRenderer.enabled;
            isEnabled = !isEnabled;
            EndGame();
        }
    }

    void EndGame() {
        SceneManager.LoadScene("endScene");
    }
}
