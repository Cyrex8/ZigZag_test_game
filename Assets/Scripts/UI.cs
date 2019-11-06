using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour
{
    public GameObject canvas;
    void Start()
    {
       
    }
    public void NewGamePressed()
    {
        SceneManager.LoadScene("Runner");
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
