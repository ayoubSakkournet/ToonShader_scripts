using UnityEngine;

public class ToonShader : MonoBehaviour {

    public Material toonMaterial;

    void Start () {
        MeshRenderer[] meshRenderers = GetComponentsInChildren<MeshRenderer>();

        foreach (MeshRenderer renderer in meshRenderers) {
            renderer.material = toonMaterial;
        }
    }
}
