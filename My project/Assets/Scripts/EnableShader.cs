using UnityEngine;
using UnityEngine.Rendering.Universal;

public class EnableShader : MonoBehaviour
{
    [SerializeField] private bool enableShader;
    [SerializeField] private ScriptableRendererFeature fullscreenFeature;

    void Update()
    {
        if (fullscreenFeature != null)
        {
            fullscreenFeature.SetActive(enableShader);
        }
    }
}