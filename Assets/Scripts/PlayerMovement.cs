using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float controlSpeed = 10f;
    [SerializeField] float xClapmRange = 20f;
    [SerializeField] float yClapmRange = 10f;

    [SerializeField] float controllRollFactor = 20f;
    [SerializeField] float controllPitchFactor = 20f;
    Vector2 movement;

    void Update()
    {
        ProcessTranslation();
        ProcessRotation();
    }



    public void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }
    private void ProcessTranslation()
    {
        float xOffset = movement.x * Time.deltaTime * controlSpeed;
        float yOffset = movement.y * Time.deltaTime * controlSpeed;

        float rawXPost = transform.localPosition.x + xOffset;
        float rawYPost = transform.localPosition.y + yOffset;

        float clampedXPost = Mathf.Clamp(rawXPost,-xClapmRange, xClapmRange);
        float clampedYPost = Mathf.Clamp(rawYPost,-yClapmRange, yClapmRange);

        transform.localPosition = new Vector3(clampedXPost, clampedYPost, 0f);
    }
    private void ProcessRotation()
    {
        Quaternion targetRotation = Quaternion.Euler(-controllPitchFactor * movement.y, 0f, controllRollFactor * movement.x);
        transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, Time.deltaTime * 10f);
    }
}
