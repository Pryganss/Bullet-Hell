using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    [SerializeField]
    private GameObject text;

    private float timer = 0f;

    public Timer Timer; 

    void Start()
    {
        Timer.timerOn = false;
        text.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey && timer > 1)
        {
            SceneManager.LoadScene("default");
        } else timer += Time.deltaTime;
    }
}
