using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
    
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
        _wall =GetComponent<Renderer>();
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    public void white()
    {
                mat.color = new Color(1,1,1);
    }

    public void green()
    {
        mat.color = new Color(146/255f, 194/255f, 125/255f, 255/255f);
    }

    public void pink()
    {
        mat.color = new Color(245/255f, 126/255f, 131/255f, 255/255f);
    }

    public void pic()
    {
        _wall.material.SetTexture("_MainTex", texture);
        _wall.material.mainTextureScale = new Vector2(1, 1);
    }

    public void pic2()
    {
        _wall.material.SetTexture("_MainTex", texture2);
       // _wall.material.mainTextureScale = new Vector2(1.5f, 2);

    }

    public void pic3()
    {
        _wall.material.SetTexture("_MainTex", texture3);
        // _wall.material.mainTextureScale = new Vector2(1.5f, 2);

    }
    // Update is called once per frame

}
