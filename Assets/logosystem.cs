using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logosystem : MonoBehaviour
{
    float dt;
    Text text;
    void Start()
    {
        text = GameObject.Find("Canvas/Text").GetComponent<Text>();
    }

    void Update()
    {
        text.color = new Color(1,1,1, Mathf.Sin(dt));
        dt += Time.deltaTime * 1.5f;
        if (dt >= 4) 
        {
            SceneManager.LoadScene("title");
        }
    }
}