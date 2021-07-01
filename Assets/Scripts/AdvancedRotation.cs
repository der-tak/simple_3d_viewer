using UnityEngine;
using UnityEngine.EventSystems;

public class AdvancedRotation : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float rotationMinAngle;
    [SerializeField]
    private float rotationMaxAngle;
    private float exctractedXRotation;
    private float exctractedYRotation;


    private Controls inputSettings;

    private void Awake()
    {
        inputSettings = new Controls();
        exctractedXRotation = transform.rotation.x;
        exctractedYRotation = transform.rotation.y;
    }

    private void OnEnable()
    {
        inputSettings.Enable();
    }

    private void OnDisable()
    {
        inputSettings.Disable();
    }

    void Update()
    {
        UpdateXYRotation();
    }

    public void UpdateXYRotation()
    {
        Vector2 inputVector = inputSettings.SceneController.RotationControl.ReadValue<Vector2>() * speed * Time.deltaTime;
        exctractedXRotation += -(inputVector.y);
        exctractedYRotation += inputVector.x;
        exctractedXRotation = Mathf.Clamp(exctractedXRotation, rotationMinAngle, rotationMaxAngle);
        transform.eulerAngles = new Vector3(exctractedXRotation, exctractedYRotation, 0);
    }

    public void disableInput()
    {
        inputSettings.Disable();
    }

    public void enableInput()
    {
        inputSettings.Enable();
    }
}