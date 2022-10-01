using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoOption : MonoBehaviour
{
    List<Resolution> resolutions = new List<Resolution>();
    public Dropdown resolutionDropdown;
    int resolutionNum;
    void Start()
    {
        InitUI();
    }

    void Update()
    {
        
    }

    void InitUI()
    {
        resolutions.AddRange(Screen.resolutions);
        resolutionDropdown.options.Clear(); //option¿∫ list
        foreach (Resolution item in resolutions)
        {
            Dropdown.OptionData option = new Dropdown.OptionData();
            option.text = item.width + "x" + item.height + " " + item.refreshRate + "hz";
            resolutionDropdown.options.Add(option);
        }
        resolutionDropdown.RefreshShownValue();
    }

    public void DropboxOpitonChange(int x)
    {
        resolutionNum = x;
    }
}
