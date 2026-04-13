using UnityEngine;

public class RotateAndTap : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 50, 0);
    private bool isVisible = true;

    void Start()
    {
        gameObject.SetActive(isVisible);
    }

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            isVisible = !isVisible;
            gameObject.SetActive(isVisible);
        }
    }
}