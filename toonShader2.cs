using UnityEngine;

public class ToonShader : MonoBehaviour
{
    public Color toonColor;
    public Color toonOutlineColor;
    public float toonOutlineWidth;

    void Start()
    {
        Material material = GetComponent<Renderer>().material;
        material.shader = Shader.Find("Toon/Basic Outline");

        // Set the color of the toon shading
        material.SetColor("_Color", toonColor);

        // Set the color of the outline
        material.SetColor("_OutlineColor", toonOutlineColor);

        // Set the width of the outline
        material.SetFloat("_OutlineWidth", toonOutlineWidth);
    }
}