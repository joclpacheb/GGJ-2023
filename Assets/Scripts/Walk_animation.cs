using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk_animation : MonoBehaviour
{

[SerializeField] private Texture texture;
float inputHorizontal;
float inputVertical;
Renderer m_Renderer;


void Start()
{

}

void FixedUpdate() {
    inputHorizontal = Input.GetAxisRaw("Horizontal");
    inputVertical = Input.GetAxisRaw("Vertical");

    if (inputHorizontal !=0)
    {
         m_Renderer = GetComponent<Renderer> ();
        m_Renderer.material.SetTexture("_MainTex", texture);

    Debug.Log("si entro");
}

}

}