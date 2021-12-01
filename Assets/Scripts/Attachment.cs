/**
 * @file: Attachment.cs
 * @author: Ian Sodersjerna
 * @brief: Captures user input related to attachments and applies forces to the game objects 
 * @version: See Git tags for version information.
 * @date: 2021.11.24
 *
 * @copyright: Copyright (c) 2021 
 */

// Enables debug prints.
#define DEBUG_PRINTS

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attachment : MonoBehaviour
{
    public GameObject ControlledObject;

    private Rigidbody2D ACORigidbody;

    [Header("Ice Sleds")]
    [Space(10)]
    public bool Ice_sleds_Enabled = false;
    public GameObject Ice_sleds_Object;

    [Header("Jet")]
    [Space(10)]
    public bool Jet_Enabled = false;
    public GameObject Jet_Object;
    [Range(0f, 10f)]
    public float boost_force = 5f;

    [Header("Helicopter")]
    [Space(10)]
    public bool Helicopter_Enabled = false;
    public GameObject Helicopter_Object;

    [Range(0f, 10f)]
    public float lift_strength = 5f;

    [Range(0f, 10f)]
    public float roll_strength = 5f;

    private bool roll_right = false;
    private bool roll_left = false;

    [Header("Fuel")]
    [Space(10)]
    [Range(0f, 100f)]
    public float starting_fuel = 100f;
    private float current_fuel = 0f;
    [Range(0f, 1f)]
    public float fuel_drain = .05f;

    private bool activated = false;


    // Start is called before the first frame update
    void Start()
    {
        current_fuel = starting_fuel;
        ACORigidbody = ControlledObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0)
        {
            Ice_sleds_Object.SetActive(Ice_sleds_Enabled);
            Jet_Object.SetActive(Jet_Enabled);
            Helicopter_Object.SetActive(Helicopter_Enabled);
            roll_right = false;
            roll_left = false;
        }

        if (Jet_Enabled || Helicopter_Enabled)
        {
            if (Input.GetButtonDown("Boost"))
            {
                activated = true;
            }
            else if (Input.GetButtonUp("Boost"))
            {
                activated = false;
            }
            if (Helicopter_Enabled)
            {
                if (Input.GetButtonDown("RollLeft"))
                {
                    roll_left = true;
                }
                else if (Input.GetButtonUp("RollLeft"))
                {
                    roll_left = false;
                }
                if (Input.GetButtonDown("RollRight"))
                {
                    roll_right = true;
                }
                else if (Input.GetButtonUp("RollRight"))
                {
                    roll_right = false;
                }
                if (roll_left || roll_right) 
                {
                    if (current_fuel > 0)
                    {
                        var impulse = ACORigidbody.inertia;
                        if (roll_left)
                        {
                            impulse = (roll_strength * Mathf.Deg2Rad) * impulse;
                        }
                        else if (roll_right)
                        {
                            impulse = (-roll_strength * Mathf.Deg2Rad) * impulse;
                        }
                        ACORigidbody.AddTorque(impulse, ForceMode2D.Impulse);
                        current_fuel -= fuel_drain * 0.01f;
                    }
                }
            }

            if (activated)
            {
                if (current_fuel > 0)
                {
                    if (Jet_Enabled)
                    {
                        ACORigidbody.AddForce(ACORigidbody.transform.right * boost_force, ForceMode2D.Force);
                        current_fuel -= fuel_drain;
                    }
                    if (Helicopter_Enabled)
                    {
                        ACORigidbody.AddForce(ACORigidbody.transform.up * lift_strength, ForceMode2D.Force);
                        current_fuel -= fuel_drain;
                    }
                }
            }
            #if DEBUG_PRINTS
                Debug.Log("fuel remaining: " + current_fuel);
            #endif // DEBUG_PRINTS
        }
        //Debug.Log(ACORigidbody.rotation);
    }
}