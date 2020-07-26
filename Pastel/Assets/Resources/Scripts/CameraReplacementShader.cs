using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraReplacementShader : MonoBehaviour
{
    public Shader replacementShader;
    public Material material;

    // Start is called before the first frame update
    void Start()
    {
        //if(replacementShader != null) Camera.main.SetReplacementShader(replacementShader, "RenderType");
    }

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, material);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
