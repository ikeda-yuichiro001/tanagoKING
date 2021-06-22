using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class off_line_kari_system : MonoBehaviour
{
    void Start()
    {
        Invoke("ChangeScene", 1.5f);
    }
    void Update()
    {
     
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("endroll");
    }
}
