using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeRotation : MonoBehaviour
{
    public float rotationSpeed = 30.0f; // Speed of the rotation.
    public Transform childToRotate;
    private bool isOver = false;
    void Update()
    {
        //check if game is over
        if (isOver)
            return;
        
        // Get the world position of the mouse.
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Find the direction vector from the object to the mouse.
        Vector2 directionToMouse = (Vector2)transform.position - mousePosition;

        // Calculate the angle between the object and the mouse.
        float angle = Mathf.Atan2(directionToMouse.y, directionToMouse.x) * Mathf.Rad2Deg;

        // Rotate the object to face the mouse.
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
    
    public void GameOver()
    {
        isOver = true;
    }
}
