using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float timer;

    [SerializeField]
    private TextMeshProUGUI text;

    public bool timerOn = true;

    // Start is called before the first frame update
    void Start()
    {
        ResetTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn) timer += Time.deltaTime;


        text.text = (Mathf.FloorToInt(timer)).ToString();
    }

    private void ResetTimer()
    {
        timer = 0f;
    }


}
