using System.Collections.Generic;
using UnityEngine.InputSystem;
using System.Collections;
using UnityEngine;


public class PressedButtonLogs : MonoBehaviour
{
    private int _currentGamepadID = -1;
    private string _currentGamepadName;
        
    void Start()
    {
        if(Gamepad.current != null) {
            _currentGamepadID = Gamepad.current.deviceId;
            _currentGamepadName = Gamepad.current.displayName;
            Debug.Log(Gamepad.current.displayName + " is now connected.");
        }
    }

    void Update()
    {
        if(Gamepad.current != null) {
            if(_currentGamepadID != Gamepad.current.deviceId && _currentGamepadID != -1) {
                Debug.Log(_currentGamepadName + " disconnected.");
                Debug.Log(Gamepad.current.displayName + " is now connected.");
                _currentGamepadID = Gamepad.current.deviceId;
                _currentGamepadName = Gamepad.current.displayName;
            }
            if(_currentGamepadID == -1) {
                Debug.Log(Gamepad.current.displayName + " is now connected.");
                _currentGamepadID = Gamepad.current.deviceId;
                _currentGamepadName = Gamepad.current.displayName;
            }
                ControllerLog();
        } else {
            if(_currentGamepadID != -1) {
                Debug.Log(_currentGamepadName + " disconnected.");
                _currentGamepadID = -1;
                _currentGamepadName = null;
            }
        }
    }

    void ControllerLog() 
    {
        if (Gamepad.current.buttonSouth.wasPressedThisFrame){
            Debug.Log("A button has been pressed");
        }
        if (Gamepad.current.buttonEast.wasPressedThisFrame){
            Debug.Log("B button has been pressed");
        }
        if (Gamepad.current.buttonNorth.wasPressedThisFrame){
            Debug.Log("Y button has been pressed");
        }
        if (Gamepad.current.buttonWest.wasPressedThisFrame){
            Debug.Log("X button has been pressed");
        }
        if (Gamepad.current.leftShoulder.wasPressedThisFrame){
            Debug.Log("LB has been pressed");
        }
        if (Gamepad.current.leftTrigger.wasPressedThisFrame){
            Debug.Log("LT has been pressed");
        }
        if (Gamepad.current.rightShoulder.wasPressedThisFrame){
            Debug.Log("RB has been pressed");
        }
        if (Gamepad.current.rightTrigger.wasPressedThisFrame){
            Debug.Log("RT has been pressed");
        }
        if (Gamepad.current.startButton.wasPressedThisFrame){
            Debug.Log("Start button has been pressed");
        }
        if (Gamepad.current.selectButton.wasPressedThisFrame){
            Debug.Log("Select button has been pressed");
        }
        if (Gamepad.current.leftStickButton.wasPressedThisFrame){
            Debug.Log("L3 button has been pressed");
        }
        if (Gamepad.current.rightStickButton.wasPressedThisFrame){
            Debug.Log("R3 button has been pressed");
        }
        if (Gamepad.current.dpad.right.wasPressedThisFrame){
            Debug.Log("D-pad right button has been pressed");
        }
        if (Gamepad.current.dpad.left.wasPressedThisFrame){
            Debug.Log("D-pad left button has been pressed");
        }
        if (Gamepad.current.dpad.up.wasPressedThisFrame){
            Debug.Log("D-pad up button has been pressed");
        }
        if (Gamepad.current.dpad.down.wasPressedThisFrame){
            Debug.Log("D-pad down button has been pressed");
        }
        if (Gamepad.current.leftStick.right.wasPressedThisFrame){
            Debug.Log("LS has been tilted right");
        }
        if (Gamepad.current.leftStick.left.wasPressedThisFrame){
            Debug.Log("LS has been tilted left");
        }
        if (Gamepad.current.leftStick.up.wasPressedThisFrame){
            Debug.Log("LS has been tilted up");
        }
        if (Gamepad.current.leftStick.down.wasPressedThisFrame){
            Debug.Log("LS has been tilted down");
        }
        if (Gamepad.current.rightStick.right.wasPressedThisFrame){
            Debug.Log("RS has been tilted right");
        }
        if (Gamepad.current.rightStick.left.wasPressedThisFrame){
            Debug.Log("RS has been tilted left");
        }
        if (Gamepad.current.rightStick.up.wasPressedThisFrame){
            Debug.Log("RS has been tilted up");
        }
        if (Gamepad.current.rightStick.down.wasPressedThisFrame){
            Debug.Log("RS has been tilted down");
        }
    }
}
