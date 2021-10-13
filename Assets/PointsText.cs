using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsText : MonoBehaviour
{
    private int point;
    private Text text;

    public static PointsText Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            text = GetComponent<Text>();
            Instance = this;
            DontDestroyOnLoad(gameObject);
            text.text = "Score: " + point.ToString();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int value)
    {

        point += value;
        text.text = "Score: " + point.ToString();
    }
}
