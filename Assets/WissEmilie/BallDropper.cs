using UnityEngine;

public class OVRControllerLogger : MonoBehaviour
{
    void Update()
    {
        // Check for button presses and log all data
        if (OVRInput.GetDown(OVRInput.Button.One) || OVRInput.GetDown(OVRInput.Button.Two) ||
            OVRInput.GetDown(OVRInput.Button.Three) || OVRInput.GetDown(OVRInput.Button.Four) ||
            OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) || OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) ||
            OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger) || OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
        {
            LogAllOVRInput();
        }
    }
    
    void LogAllOVRInput()
    {
        Debug.Log("=== OVR Input Data ===");
        
        // Button states
        Debug.Log($"Button One (A/X): {OVRInput.Get(OVRInput.Button.One)}");
        Debug.Log($"Button Two (B/Y): {OVRInput.Get(OVRInput.Button.Two)}");
        Debug.Log($"Button Three (Start): {OVRInput.Get(OVRInput.Button.Three)}");
        Debug.Log($"Button Four (Menu): {OVRInput.Get(OVRInput.Button.Four)}");
        
        // Trigger values
        Debug.Log($"Primary Index Trigger: {OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger)}");
        Debug.Log($"Secondary Index Trigger: {OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger)}");
        Debug.Log($"Primary Hand Trigger: {OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger)}");
        Debug.Log($"Secondary Hand Trigger: {OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger)}");
        
        // Thumbstick values
        Debug.Log($"Primary Thumbstick: {OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick)}");
        Debug.Log($"Secondary Thumbstick: {OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick)}");
        
        // Touch states
        Debug.Log($"Primary Thumbstick Touch: {OVRInput.Get(OVRInput.Touch.PrimaryThumbstick)}");
        Debug.Log($"Secondary Thumbstick Touch: {OVRInput.Get(OVRInput.Touch.SecondaryThumbstick)}");
        Debug.Log($"Primary Index Trigger Touch: {OVRInput.Get(OVRInput.Touch.PrimaryIndexTrigger)}");
        Debug.Log($"Secondary Index Trigger Touch: {OVRInput.Get(OVRInput.Touch.SecondaryIndexTrigger)}");
        
        // Controller positions and rotations
        Debug.Log($"Left Controller Position: {OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch)}");
        Debug.Log($"Right Controller Position: {OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch)}");
        Debug.Log($"Left Controller Rotation: {OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch)}");
        Debug.Log($"Right Controller Rotation: {OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch)}");
        
        // Velocities
        Debug.Log($"Left Controller Velocity: {OVRInput.GetLocalControllerVelocity(OVRInput.Controller.LTouch)}");
        Debug.Log($"Right Controller Velocity: {OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RTouch)}");
        Debug.Log($"Left Controller Angular Velocity: {OVRInput.GetLocalControllerAngularVelocity(OVRInput.Controller.LTouch)}");
        Debug.Log($"Right Controller Angular Velocity: {OVRInput.GetLocalControllerAngularVelocity(OVRInput.Controller.RTouch)}");
        
        Debug.Log("=== End OVR Input Data ===");
    }
}
