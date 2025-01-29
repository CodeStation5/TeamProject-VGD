using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public Dropdown resolutionList;
    public AudioMixer audioControl;
    Resolution[] resolutions;

    private void Start()
    {
        // Create list of resolutions
        List<string> listOption = new List<string>();
        resolutions = Screen.resolutions;
        // Clear the resolutions on the dropdown list
        resolutionList.ClearOptions();

        // For each resolution element, add to the dropdown list of resolutions
        for (int i = 0; i < resolutions.Length; i++)
        {
            string resOption = resolutions[i].width + "x" + resolutions[i].height;
            listOption.Add(resOption);
        }
    }
    public void ControlVolume(float volume)
    {   
        // Set game volume in options menu to the value in the options menu slider
        audioControl.SetFloat("VolumeControl", volume);
    }

    public void FullScreenControl(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
