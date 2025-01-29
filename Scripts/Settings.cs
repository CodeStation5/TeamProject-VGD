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

    // At the games start, configure the games resolution
    private void Start()
    {
        // Create list of resolutions
        List<string> listOption = new List<string>();
        resolutions = Screen.resolutions;
        int currentResolution = 0;

        // Clear the resolutions on the dropdown list
        resolutionList.ClearOptions();

        // For each resolution element, add to the dropdown list of resolutions
        for (int i = 0; i < resolutions.Length; i++)
        {
            string resOption = resolutions[i].width + "x" + resolutions[i].height;
            listOption.Add(resOption);

            // Checking to see if a dropdown lists resolution is equal to the games current resolution
            if (resolutions[i].width == Screen.currentResolution.width && 
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolution = i;
            }
        }
        // Add the resolutions to the drop list and refresh the shown list ingame
        resolutionList.AddOptions(listOption);
        resolutionList.value = currentResolution;
        resolutionList.RefreshShownValue();
    }

    public void ResolutionControl(int setResolution)
    {
        // Set the games resolution and check to set the game to full screen
        Resolution resolution = resolutions[setResolution];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void VolumeConrol(float volume)
    {   
        // Set game volume in options menu to the value in the options menu slider
        audioControl.SetFloat("VolumeControl", volume);

    }

    public void FullScreenControl(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }


}
