using UnityEngine;

public class Behavior : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Animator component attached to the GameObject
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Toggle activation of running animation when the "R" key is pressed
        if (Input.GetKeyDown(KeyCode.R))
        {
            ToggleParameter("isRunning");
            TurnOffOtherParameters("isRunning");
        }

        // Toggle activation of backward animation when the "B" key is pressed
        if (Input.GetKeyDown(KeyCode.B))
        {
            ToggleParameter("isBackward");
            TurnOffOtherParameters("isBackward");
        }

        // Toggle activation of jumping animation when the "J" key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleParameter("isJumping");
            TurnOffOtherParameters("isJumping");
        }

        // Toggle activation of slashing animation when the "S" key is pressed
        if (Input.GetKeyDown(KeyCode.S))
        {
            ToggleParameter("isSlashing");
            TurnOffOtherParameters("isSlashing");
        }

        // Toggle activation of stabbing animation when the "K" key is pressed
        if (Input.GetKeyDown(KeyCode.K))
        {
            ToggleParameter("isStabbing");
            TurnOffOtherParameters("isStabbing");
        }

        // Toggle activation of strafing right animation when the "E" key is pressed
        if (Input.GetKeyDown(KeyCode.D))
        {
            ToggleParameter("isStrafeR");
            TurnOffOtherParameters("isStrafeR");
        }

        // Toggle activation of strafing left animation when the "Q" key is pressed
        if (Input.GetKeyDown(KeyCode.A))
        {
            ToggleParameter("isStrafeL");
            TurnOffOtherParameters("isStrafeL");
        }

        // Toggle activation of getting hit animation when the "H" key is pressed
        if (Input.GetKeyDown(KeyCode.H))
        {
            ToggleParameter("isHit");
            TurnOffOtherParameters("isHit");
        }
    }

    // Function to toggle the given parameter
    private void ToggleParameter(string parameterName)
    {
        animator.SetBool(parameterName, !animator.GetBool(parameterName));
    }

    // Function to turn off other parameters when a specific parameter is activated
    private void TurnOffOtherParameters(string activatedParameter)
    {
        string[] allParameters = { "isRunning", "isBackward", "isJumping", "isSlashing", "isStabbing", "isStrafeR", "isStrafeL", "isHit" };

        foreach (string parameter in allParameters)
        {
            if (parameter != activatedParameter)
            {
                animator.SetBool(parameter, false);
            }
        }
    }
}
