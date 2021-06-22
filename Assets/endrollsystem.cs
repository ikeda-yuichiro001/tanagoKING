using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class endrollsystem : MonoBehaviour
{
    float tnp;
    public float timer;
    public float speed;
    void Start()
    {
        tnp = 0f;
    }
    void Update()
    {
        this.transform.position += new Vector3(0, Time.deltaTime*speed, 0);
        tnp += Time.deltaTime;
        if (transform.position.y >= 1500)
        {
            SceneManager.LoadScene("logo");
        }
    }
}
