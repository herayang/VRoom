using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialEditor : MonoBehaviour
{

    MeshRenderer meshRenderer;

    public Texture albedoTexture;
    public Texture normalTexture;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void ChangeAlbedoTexture()
    {
        meshRenderer.material.SetTexture("_MainTex", albedoTexture);
    }

    public void ChangeNormalTexture()
    {
        meshRenderer.material.SetTexture("_BumpMap", normalTexture);
    }

    public void MetallicSlider(float metallic)
    {
        meshRenderer.material.SetFloat("_Metallic", metallic);
    }

    public void SmoothnessSlider(float smoothness)
    {
        meshRenderer.material.SetFloat("_Glossiness", smoothness);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
