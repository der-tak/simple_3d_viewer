using UnityEngine;

public class RotateOtherDoor : MonoBehaviour
{
    public float degreesPerSecond = 40f;
    public float rotationDegreesAmount = 80f;
    private float totalRotation = 0;
    bool open;
    // Use this for initialization
    void Start()
    {
        open = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if we haven't reached the desired rotation, swing

        if (open && Mathf.Abs(totalRotation) < Mathf.Abs(rotationDegreesAmount))
        {
            SwingOpen();
        }
        else if(!open && Mathf.Abs(totalRotation) >= 1.0f)
        {
            SwingClose();
        }
    }

    private void SwingOpen()
    {
        float currentAngle = transform.rotation.eulerAngles.y;
        transform.rotation = Quaternion.AngleAxis(currentAngle - (Time.deltaTime * degreesPerSecond), Vector3.up);
        totalRotation -= Time.deltaTime * degreesPerSecond;
    }

    private void SwingClose()
    {
        float currentAngle = transform.rotation.eulerAngles.y;
        transform.rotation = Quaternion.AngleAxis(currentAngle + (Time.deltaTime * degreesPerSecond), Vector3.up);
        totalRotation += Time.deltaTime * degreesPerSecond;
    }

    public void SetDoor()
    {
        if (!open) open = true;
        else open = false;
    }
}
