using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_floor : MonoBehaviour

{
    // Start is called before the first frame update
    MeshRenderer mesh;
    Material mat;

    private Renderer _wall;
    public Texture2D texture;
    public Texture2D texture2;
    public Texture2D texture3;

    void Start()
    {
        _wall = GetComponent<Renderer>();
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    public void white()
    {
        mat.color = new Color(1, 1, 1);
    }

    public void yellow()
    {
        mat.color = new Color(1, 0.92f, 0.016f, 1);
    }

    public void red()
    {
        mat.color = new Color(1, 0, 0, 1);
    }

    public void pic()
    {
        _wall.material.SetTexture("_MainTex", texture);
        _wall.material.mainTextureScale = new Vector2(1, 1);
    }

    public void pic2()
    {
        _wall.material.SetTexture("_MainTex", texture2);
        _wall.material.mainTextureScale = new Vector2(1, 1);

    }

    public void pic3()
    {
        _wall.material.SetTexture("_MainTex", texture3);
        _wall.material.mainTextureScale = new Vector2(1, 1);

    }
    // Update is called once per frame

}
