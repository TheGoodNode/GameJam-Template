using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{

    public GameObject[] tutorials;
    private int currentTutorialToShow = 0;

    void Start()
    {
        foreach (var tutorial in tutorials)
        {
            tutorial.SetActive(false);
        }
        ShowFirstTutorial();
    }

    public void SwitchToNextTutorial()
    {
        if (currentTutorialToShow == tutorials.Length - 1)
        {
            Debug.LogWarning("The amount of tutorials are finished");
            return;
        }
        HideTutorial();
        currentTutorialToShow += 1;
        ShowTutorial();
    }

    public void ShowFirstTutorial()
    {
        tutorials[0].SetActive(true);
    }

    private void ShowTutorial()
    {
        tutorials[currentTutorialToShow].SetActive(true);
    }

    private void HideTutorial()
    {
        tutorials[currentTutorialToShow].SetActive(false);
    }
}
