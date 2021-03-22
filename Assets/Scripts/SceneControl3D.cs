using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#pragma warning disable CS0649

public class SceneControl3D : MonoBehaviour
{
    [SerializeField] GameObject rt, rl;
    [SerializeField] GameObject modellAsTexture;
    [SerializeField] GameObject driverDoorBtn, coDriverDoorBtn, engineCoverBtn;
    [SerializeField] int curVehicle;

    private void CheckVehicleID()
    {
        if (curVehicle == 0) //check wich vehicle to display, value found in state-class
        {
            rt.SetActive(false);
            rl.SetActive(true);
            driverDoorBtn.SetActive(true);
            coDriverDoorBtn.SetActive(true);
            engineCoverBtn.SetActive(true);
        }
        else
        {
            rt.SetActive(true);
            rl.SetActive(false);
            driverDoorBtn.SetActive(false);
            coDriverDoorBtn.SetActive(false);
            engineCoverBtn.SetActive(false);
        }
    }
    public void ClosingDelay()
    {
        modellAsTexture.GetComponent<Animator>().SetBool("upscaled", false);
        Invoke("BackToVehicle", 2);
    }
}
