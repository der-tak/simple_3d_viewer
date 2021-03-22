using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class RotationControl : MonoBehaviour
{
    [Header("Sub Behaviours")]
   // public PlayerMovementBehaviour playerMovementBehaviour;

    [Header("Parameters")]
    [SerializeField] float moveSpeed = 0.3f;
    [SerializeField] float minXRot = -25f;
    [SerializeField] float maxXRot = 35f;
    [SerializeField] float smoothRotationSpeed = 5.0f;

    //member variables for y-rotation
    private Vector3 rawAxisYRotation;
    private Vector3 curYRotation;
    private Vector3 smoothInputYRotation;

    //member variables for x/y-rotation
    private Vector3 rawAxisXYRotation;
    private Vector3 curXYRotation;
    private Vector3 smoothInputXYRotation;

    private Quaternion defaultRotation;

    private void Awake()
    {
        defaultRotation = gameObject.transform.localRotation;
        curYRotation = new Vector3(defaultRotation.x, defaultRotation.y, defaultRotation.z);
        curXYRotation = new Vector3(defaultRotation.x, defaultRotation.y, defaultRotation.z);
    }

    public void OnRotationYAxis(InputAction.CallbackContext value)
    {
        Vector2 inputRotation = value.ReadValue<Vector2>();
        rawAxisYRotation = new Vector3(0.0f, inputRotation.x * moveSpeed, 0.0f);

        //add rotation value for every frame
        curYRotation += rawAxisYRotation;
    }

    public void OnRotationXYAxis(InputAction.CallbackContext value)
    {
        Vector2 inputRotation = value.ReadValue<Vector2>();
        rawAxisXYRotation = new Vector3(-inputRotation.y * moveSpeed, inputRotation.x * moveSpeed, 0.0f); //prepared for touch control

        //add rotation value for every frame
        curXYRotation += rawAxisXYRotation;
    }

    private void Update()
    {
        SetToLimit();
        CalculateXYRotationInputSmoothing();
        ClampXRotation();
        UpdateXYRotation();
    }

    private void SetToLimit()
    {
        if (curXYRotation.x > maxXRot)
        {
            curXYRotation.x = maxXRot;
        }
        else if (curXYRotation.x < minXRot)
        {
            curXYRotation.x = minXRot;
        }
        else
        {
            return;
        }
    }

    private void CalculateYRotationInputSmoothing()
    {
        smoothInputYRotation = Vector3.Lerp(smoothInputYRotation, rawAxisYRotation, smoothRotationSpeed * Time.deltaTime);
    }

    private void CalculateXYRotationInputSmoothing()
    {
        smoothInputXYRotation = Vector3.Lerp(smoothInputXYRotation, rawAxisXYRotation, smoothRotationSpeed * Time.deltaTime);
    }

    private void ClampXRotation()
    {
        smoothInputXYRotation = new Vector3 (Mathf.Clamp(smoothInputXYRotation.x, minXRot, maxXRot), smoothInputXYRotation.y, smoothInputXYRotation.z);
    }

    private void UpdateYRotation()
    {
        curYRotation += smoothInputYRotation;
        gameObject.transform.localRotation = Quaternion.Euler(0.0f, curYRotation.y, 0.0f);
    }

    private void UpdateXYRotation()
    {
        curXYRotation += smoothInputXYRotation;
        gameObject.transform.localRotation = Quaternion.Euler(curXYRotation.x, curXYRotation.y, 0.0f);
    }

    public void ResetRotation() //TODO update seems to intefere with this one
    {
        gameObject.transform.localRotation = Quaternion.Lerp(gameObject.transform.localRotation, defaultRotation, 1.5f);
    }
}
