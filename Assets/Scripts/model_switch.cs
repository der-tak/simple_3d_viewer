using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class model_switch : MonoBehaviour
{
    //initialization
    [SerializeField] TextMeshProUGUI label;
    [SerializeField] TextMeshProUGUI log;
    [SerializeField] GameObject[] modelList;
    int index;

    void Start()
    {
        DisableAllModels();

        index = 0;
        modelList[index].SetActive(true);
        label.text = modelList[index].name;
        log.text = "Log: " + index;
    }

    private void DisableAllModels()
    {
        for (int i = 0; i <= modelList.Length-1; i++)
        {
            modelList[i].SetActive(false);
        }
    }

    public void NextModel()
    {
        CheckForEnd();
        stringOutput();
    }

    private void CheckForEnd()
    {
        if (index == modelList.Length - 1)
        {
            index = 0;
            modelList[modelList.Length - 1].SetActive(false);
            modelList[index].SetActive(true);
        }
        else
        {
            modelList[index].SetActive(false);
            modelList[index + 1].SetActive(true);
            index += 1;
        }
    }

    public void PrevModel()
    {
        checkForStart();
        stringOutput();
    }

    private void stringOutput()
    {
        label.text = modelList[index].name;
        log.text = "Log: " + index;
    }

    private void checkForStart()
    {
        if (index == 0)
        {
            index = modelList.Length - 1;
            modelList[0].SetActive(false);
            modelList[index].SetActive(true);
        }
        else
        {
            modelList[index].SetActive(false);
            modelList[index - 1].SetActive(true);
            index -= 1;
        }
    }
}
