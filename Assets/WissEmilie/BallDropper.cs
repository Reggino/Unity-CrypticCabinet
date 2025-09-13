using UnityEngine;

namespace WissEmilie
{
    public class BallDropper : MonoBehaviour
    {
        public GameObject volleyball;
        public GameObject visualController;

        void Update()
        {
            // Handle right trigger press to show left hand controller
            if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) ||
                OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
            {
                visualController.SetActive(true);
            }

            // Check for button presses to handle volleyball
            if (
                OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) ||
                OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger)
            )
            {
                volleyball.SetActive(true);
                Vector3 leftControllerPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
                volleyball.transform.position = leftControllerPosition;
                visualController.SetActive(false);
            }
        }
    }
}