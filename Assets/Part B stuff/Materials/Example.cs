using UnityEngine;

public class Example : MonoBehaviour
{
    public Cubemap texture;

    void Start()
    {
        // Create a new Cubemap texture.
        texture = new Cubemap(128, TextureFormat.RGBA32, false);
    }
}