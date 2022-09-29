﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoOption : MonoBehaviour
{
    FullScreenMode screenMode;
    List<Resolution> resolutions = new List<Resolution>();
    public Dropdown resolutionDropdown;
    public Toggle fullscreenBtn;
    public int resolutionNum;
    public GameObject panel;
    void Start()
    {
        InitUI();
    }

    void InitUI()
    {
        for (int i = 0; i < Screen.resolutions.Length; i++)
        {
            if (Screen.resolutions[i].refreshRate >= 60)
            {
                resolutions.Add(Screen.resolutions[i]);
            }
        }
        resolutionDropdown.options.Clear(); //option은 list

        int optionNum = 0;
        foreach (Resolution item in resolutions)
        {
            Dropdown.OptionData option = new Dropdown.OptionData();
            option.text = item.width + "x" + item.height + " " + item.refreshRate + "hz";
            resolutionDropdown.options.Add(option);

            if (item.width == Screen.width && item.height == Screen.height)
            {
                resolutionDropdown.value = optionNum;
            }
            optionNum++;
        }
        resolutionDropdown.RefreshShownValue();

        fullscreenBtn.isOn = Screen.fullScreenMode.Equals(FullScreenMode.FullScreenWindow) ? true : false;
    }

    public void DropboxOpitonChange(int x)
    {
        resolutionNum = x;
    }

    public void FullScreenBtn(bool isFull)
    {
        screenMode = isFull ? FullScreenMode.FullScreenWindow : FullScreenMode.Windowed;
    }

    public void OkBtnClick()
    {
        Screen.SetResolution(resolutions[resolutionNum].width, resolutions[resolutionNum].height, screenMode);
        panel.SetActive(false);
    }

    public void OnOffBtn()
    {
        if (panel.activeSelf)
        {
            panel.SetActive(false);
        }
        else if (!panel.activeSelf)
        {
            panel.SetActive(true);
        }
    }
}
