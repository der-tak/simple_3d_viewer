using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
#pragma warning disable CS0108, CS0649 //suppress non relevant warnings

public class ZoomControl : MonoBehaviour
{
    //member variables
    Controls controls;
    float zoom;
    Mouse mouse;
    Vector3 zoomVector;
    float sliderZoom;

    //[SerializeField] InputActionAsset uiInput;
    [SerializeField] InputActionAsset sceneInput;

    //params
    [Header("Mouse Scroll Zoom")]
    [SerializeField] float zoomSpeed;
    [SerializeField] float maxZoom;
    [SerializeField] float minZoom;

    [Header("Slider Zoom")]
    [SerializeField] float defaultFOV;
    [SerializeField] float maxFOV;
    [SerializeField] Vector3 defaultScale;
    [SerializeField] float curScale;

    [Header("Camera Reference")]
    [SerializeField] Camera camera;
    private Vector3 defaultCameraPosition;

    private void Awake()
    {
        defaultScale = gameObject.transform.localScale;
        defaultCameraPosition = camera.transform.localPosition;
    }

    public void OnMouseZoom(InputAction.CallbackContext value)
    {
        SetToLimit();
        curScale = defaultScale.x;
        float inputScale = value.ReadValue<float>();

        float zoomControl = inputScale * zoomSpeed;
        curScale += zoomControl;
        gameObject.transform.localScale = new Vector3(Mathf.Clamp(curScale, minZoom, maxZoom), 
                                                      Mathf.Clamp(curScale, minZoom, maxZoom),
                                                      Mathf.Clamp(curScale, minZoom, maxZoom));
    }

    private void SetToLimit()
    {
        if (curScale > maxZoom)
        {
            curScale = maxZoom;
        }
        else if (curScale < minZoom)
        {
            curScale = minZoom;
        }
        else
        {
            return;
        }
    }

    public void SliderZoom(float zoomValue)
    {
        float newzoom = minZoom + zoomValue * (maxZoom - minZoom);

        camera.transform.localPosition = defaultCameraPosition + new Vector3(0, 0, newzoom);

        camera.fieldOfView = defaultFOV + zoomValue * (maxFOV - defaultFOV);
    }
}
