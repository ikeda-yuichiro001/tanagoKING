using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logosystem : MonoBehaviour
{

    public float speed = 0.01f;  //透明化の速さ
    public float antispeed = 0.02f;
    float alfa;    //A値を操作するための変数
    float red, green, blue;    //RGBを操作するための変数
    Text text;

    // Use this for initialization
    void Start()
    {

        Invoke("ChangeScene", 3.0f);
       

        text = GameObject.Find("Canvas/Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.color = new Color(red,green,blue,alfa);
        alfa += speed;
    }

    



    void ChangeScene()
    {
        SceneManager.LoadScene("title");
    }
}