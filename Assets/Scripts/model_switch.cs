using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class model_switch : MonoBehaviour
{
    //initialization
    public GameObject[] modelList;
    int index;

    void Start()
    {
        index = 0;
        modelList[index].SetActive(true);
    }

    public void NextModel()
    {
        if (index == modelList.Length-1)
        {
            index = 0;
            modelList[modelList.Length-1].SetActive(false);
            modelList[index].SetActive(true);
        }
        else 
        {
            modelList[index].SetActive(false);
            modelList[index+1].SetActive(true);
            index += 1;
        }
        Debug.Log(index);
    }

    public void PrevModel()
    {
        if(index == 0)
        {
            index = modelList.Length-1;
            modelList[0].SetActive(false);
            modelList[index].SetActive(true);
        }
        else
        {
            modelList[index].SetActive(false);
            modelList[index-1].SetActive(true);
            index -= 1;   
        }
        Debug.Log(index);
    }
}
