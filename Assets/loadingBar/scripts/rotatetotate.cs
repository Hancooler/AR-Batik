using UnityEngine;
using UnityEngine.UI;

public class RotatingImage : MonoBehaviour
{
    private RectTransform rectComponent;
    private Image imageComp;

    [Header("Rotation Settings")]
    public float rotateSpeed = 200f;
    public Vector3 rotationAxis = Vector3.forward; // Default rotation axis is the z-axis
    public bool clockwise = true; // Default rotation direction is clockwise
    public float minRotation = 0f;
    public float maxRotation = 360f;

    // Use this for initialization
    void Start()
    {
        rectComponent = GetComponent<RectTransform>();
        imageComp = rectComponent.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        float currentSpeed = rotateSpeed * Time.deltaTime;
        float rotationAngle = clockwise ? currentSpeed : -currentSpeed;

        // Apply rotation, ensuring it stays within the specified limits
        rectComponent.Rotate(rotationAxis, rotationAngle);
        float currentRotation = rectComponent.eulerAngles.z; // Assuming z-axis is the rotation axis
        currentRotation = Mathf.Clamp(currentRotation, minRotation, maxRotation);
        rectComponent.eulerAngles = new Vector3(0f, 0f, currentRotation);
    }
}