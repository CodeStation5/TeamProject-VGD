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
        List<string> listOption = new List<string>();
        resolutions = Screen.resolutions;
        // Clear the resolutions on the dropdown list
        resolutionList.ClearOptions();

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
