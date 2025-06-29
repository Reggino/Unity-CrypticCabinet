using UnityEngine;

public class OVRControllerLogger : MonoBehaviour
{
    public GameObject volleyball;
    
    void Update()
    {
        // Check for button presses and log all data
        if (OVRInput.GetDown(OVRInput.Button.One) || OVRInput.GetDown(OVRInput.Button.Two) ||
            OVRInput.GetDown(OVRInput.Button.Three) || OVRInput.GetDown(OVRInput.Button.Four) ||
            OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) ||
            OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) ||
            OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger) ||
            OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
        {
            if (volleyball != null)
            {
                volleyball.SetActive(true);
                Vector3 leftControllerPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
                volleyball.transform.position = leftControllerPosition;
            }

            OVRInput.Controller leftController = OVRInput.Controller.LTouch;
            OVRInput.SetControllerVibration(0, 0, leftController);
            GameObject leftControllerObject = GameObject.Find("OculusHandController_L");
            if (leftControllerObject != null)
            {
                leftControllerObject.SetActive(false);
            }
        }
    }
}