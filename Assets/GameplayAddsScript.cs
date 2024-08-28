using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class GameplayAddsScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("AdditionsSet"))
        {
            if (PlayerPrefs.GetInt("endless") == 1)
            {
                endless.isOn = true;
            }
            else
            {
                endless.isOn = false;
            }
            if (PlayerPrefs.GetInt("freeplay") == 1)
            {
                free.isOn = true;
            }
            else
            {
                free.isOn = false;
            }
            if (PlayerPrefs.GetInt("nightTime") == 1)
            {
                nightTime.isOn = true;
            }
            else
            {
                nightTime.isOn = false;
            }
            if (PlayerPrefs.GetInt("speedy") == 1)
            {
                speedy.isOn = true;
            }
            else
            {
                speedy.isOn = false;
            }
        }
        else
        {
            PlayerPrefs.SetInt("AdditionsSet", 1);
        }
        if (!PlayerPrefs.HasKey("AdditionsSet"))
        {
            PlayerPrefs.SetInt("AdditionsSet", 1);
            return;
        }
    }

    // Token: 0x06000062 RID: 98 RVA: 0x00003850 File Offset: 0x00001C50
    private void Update()
    {
        if (free.isOn)
        {
            PlayerPrefs.SetInt("freeplay", 1);
        }
        else
        {
            PlayerPrefs.SetInt("freeplay", 0);
        }
        if (endless.isOn)
        {
            PlayerPrefs.SetInt("endless", 1);
        }
        else
        {
            PlayerPrefs.SetInt("endless", 0);
        }
        if (nightTime.isOn)
        {
            PlayerPrefs.SetInt("nightTime", 1);
        }
        else
        {
            PlayerPrefs.SetInt("nightTime", 0);
        }
        if (speedy.isOn)
        {
            PlayerPrefs.SetInt("speedy", 1);
        }
        else
        {
            PlayerPrefs.SetInt("speedy", 0);
        }
    }

    // Token: 0x04000070 RID: 112
    public Toggle endless;

    public Toggle free;

    public Toggle nightTime;

    public Toggle speedy;
}
