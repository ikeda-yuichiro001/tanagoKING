﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class logosystem : MonoBehaviour
{

    public float speed = 0.01f;  //透明化の速さ
    float alfa;    //A値を操作するための変数
    float red, green, blue;    //RGBを操作するための変数

    // Use this for initialization
    void Start()
    {
        Invoke("ChangeScene", 3.0f);
        //Panelの色を取得
        //red = GetComponent<Image>().color.r;
        //green = GetComponent<Image>().color.g;
        //blue = GetComponent<Image>().color.b;
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Image>().color = new Color(red, green, blue, alfa);
        alfa += speed;
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("title");
    }
}