/**
 * @file MovementController.cs
 * @author Mit Bailey (mitbailey99@gmail.com)
 * @brief Captures user input.
 * @version See Git tags for version information.
 * @date 2021.10.29
 *
 * @copyright Copyright (c) 2021
 * 
 */

// Enables debug prints.
#define DEBUG_PRINTS

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    // Assuming the player can only control one object at a time, this is the object which the player's inputs will affect.
    // It is public and therefore exposed in the editor.
    public GameObject ActivelyControlledObject;

    // For now, it is required that the ActivelyControlledObject has a Rigidbody2D component. This is probably best, since
    // it will simplify the movement significantly.
    private Rigidbody2D ACORigidbody;

    // NOTE: Making variables public will expose them in the editor. Changes made to the initialized value of a public
    //       variable will be ignored by Unity until it is made private, effectively forcing public variables to be changed
    //       in the editor only.
    private float HorizSensitivity = 1f;
    private float VertiSensitivity = 2f;

    // Start is called before the first frame update
    void Start()
    {
        // Unity will throw an error automatically if this fails.
        ACORigidbody = ActivelyControlledObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get the user input.
        float Horiz = Input.GetAxis("Horizontal") * HorizSensitivity;
        float Verti = Input.GetAxis("Vertical") * VertiSensitivity;

#if DEBUG_PRINTS
        if (Horiz > 0.0001f || Horiz < -0.0001f)
        {
            Debug.Log("Horiz: " + Horiz);
        }

        if (Verti > 0.0001f || Verti < -0.0001f)
        {
            Debug.Log("Verti: " + Verti);
        }
#endif // DEBUG_PRINTS

        // Apply the input forces to the ActivelyControlledObject via its Rigidbody2D component.
        ACORigidbody.AddForce(new Vector2(Horiz, Verti), ForceMode2D.Force);
    }
}
