using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPText : MonoBehaviour
{
    private int hp = 100;
    private Text text;

    public static HPText Instance 
    { 
        get; private set; 
    }

    private void Awake()
    {
        if (Instance == null)
        {
            text = GetComponent<Text>();
            Instance = this;
            DontDestroyOnLoad(gameObject);
            text.text = "Health: " + hp.ToString();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int value)
    {
        if (hp > 0)
        {
            hp -= value;
            text.text = "Health: " + hp.ToString();
        }
    }
}
