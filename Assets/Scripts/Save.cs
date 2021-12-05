using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    GameObject obj;
    Transform target;
    MeshRenderer targetco;
    Renderer targetmat;

    Vector3 pos;
    Quaternion rot;
    Vector3 sc;
    Color co;
    Texture mat;
    bool tf = false;

    Vector3 pos2;
    Quaternion rot2;
    Vector3 sc2;
    Color co2;
    Texture mat2;
    bool tf2 = false;


    public void save1(GameObject x)
    {
        pos = x.gameObject.transform.position; //현재 위치 저장
        rot = x.gameObject.transform.rotation; //현재 회전률 저장
        sc = x.gameObject.transform.localScale; //현재 크기 저장
        co = x.gameObject.GetComponent<MeshRenderer>().material.color; //현재 색상 저장
        mat = x.gameObject.GetComponent<Renderer>().material.GetTexture("_MainTex"); //현재 재질 저장
        if(x.activeSelf == true) //현재 활성화 여부 저장
        {
            tf = true;
        }
    }

    public void load1(GameObject x)
    {
        obj = GameObject.Find(x.name);
        target = obj.GetComponent<Transform>();
        targetco = obj.GetComponent<MeshRenderer>();
        targetmat = obj.GetComponent<Renderer>();

        target.position = pos; //위치 불러오기
        target.rotation = rot; //회전률 불러오기
        target.localScale = sc; //크기 불러오기
        targetco.material.color = co; //색상 불러오기
        targetmat.material.SetTexture("_MainTex", mat); //재질 불러오기
        obj.SetActive(tf); //활성화 여부 불러오기
    }

    public void save2(GameObject x)
    {
        pos2 = x.gameObject.transform.position; //현재 위치 저장
        rot2 = x.gameObject.transform.rotation; //현재 회전률 저장
        sc2 = x.gameObject.transform.localScale; //현재 크기 저장
        co2 = x.gameObject.GetComponent<MeshRenderer>().material.color; //현재 색상 저장
        mat2 = x.gameObject.GetComponent<Renderer>().material.GetTexture("_MainTex"); //현재 재질 저장
        if (x.activeSelf == true) //현재 활성화 여부 저장
        {
            tf2 = true;
        }
    }

    public void load2(GameObject x)
    {
        obj = GameObject.Find(x.name);
        target = obj.GetComponent<Transform>();
        targetco = obj.GetComponent<MeshRenderer>();
        targetmat = obj.GetComponent<Renderer>();

        target.position = pos2; //위치 불러오기
        target.rotation = rot2; //회전률 불러오기
        target.localScale = sc2; //크기 불러오기
        targetco.material.color = co2; //색상 불러오기
        targetmat.material.SetTexture("_MainTex", mat2); //재질 불러오기
        obj.SetActive(tf2); //활성화 여부 불러오기
    }

    
}