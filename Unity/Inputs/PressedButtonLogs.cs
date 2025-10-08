using System.Collections.Generic;
using UnityEngine.InputSystem;
using System.Collections;
using UnityEngine;


public class PressedButtonLogs : MonoBehaviour
{
    
    public bool debug = true;
    public bool controllerDebug = true;
    private int _currentGamepadID = -1;
    private string _currentGamepadName;

    [Header("Controller inputs")]

    public bool AButton;
    public bool BButton;
    public bool XButton;
    public bool YButton;
    public bool startButton;
    public bool selectButton;
    public bool LB;
    public bool RB;
    public bool LT;
    public bool RT;
    public bool L3;
    public bool R3;
    public bool DPadUp;
    public bool DPadDown;
    public bool DPadLeft;
    public bool DPadRight;
    public bool LSUp;
    public bool LSDown;
    public bool LSLeft;
    public bool LSRight;
    public bool RSUp;
    public bool RSDown;
    public bool RSLeft;
    public bool RSRight;
            
    void Start()
    {
        if(debug) {
            if(controllerDebug) {
                if(Gamepad.current != null) {
                    _currentGamepadID = Gamepad.current.deviceId;
                    _currentGamepadName = Gamepad.current.displayName;
                    Debug.Log(Gamepad.current.displayName + " is now connected.");
                }
            }
        }
    }

    void Update()
    {
        if(debug) {
            if(controllerDebug) {
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
        }
    }

    void ControllerLog() 
    {
        if (Gamepad.current.buttonSouth.isPressed){
            AButton = true;
            if(Gamepad.current.buttonSouth.wasPressedThisFrame) {
                Debug.Log("A button has been pressed");
            }
        } else {
            AButton = false;
        }
        if (Gamepad.current.buttonEast.isPressed){
            BButton = true;
            if (Gamepad.current.buttonEast.wasPressedThisFrame){
                Debug.Log("B button has been pressed");
            }
        } else {
            BButton = false;
        }
        if (Gamepad.current.buttonNorth.isPressed){
            YButton = true;
            if (Gamepad.current.buttonNorth.wasPressedThisFrame){
                Debug.Log("Y button has been pressed");
            }
        } else {
            YButton = false;
        }
        if (Gamepad.current.buttonWest.isPressed){
            XButton = true;
            if (Gamepad.current.buttonWest.wasPressedThisFrame){
                Debug.Log("X button has been pressed");
            }
        } else {
            XButton = false;
        }
        if (Gamepad.current.leftShoulder.isPressed){
            LB = true;
            if (Gamepad.current.leftShoulder.wasPressedThisFrame){
                Debug.Log("LB has been pressed");
            }
        } else {
            LB = false;
        }
        if (Gamepad.current.leftTrigger.isPressed){
            LT = true;
            if (Gamepad.current.leftTrigger.wasPressedThisFrame){
                Debug.Log("LT has been pressed");
            }
        } else {
            LT = false;
        }
        if (Gamepad.current.rightShoulder.isPressed){
            RB = true;
            if (Gamepad.current.rightShoulder.wasPressedThisFrame){
                Debug.Log("RB has been pressed");
            }
        } else {
            RB = false;
        }
        if (Gamepad.current.rightTrigger.isPressed){
            RT = true;
            if (Gamepad.current.rightTrigger.wasPressedThisFrame){
                Debug.Log("RT has been pressed");
            }
        } else {
            RT = false;
        }
        if (Gamepad.current.startButton.isPressed){
            startButton = true;
            if (Gamepad.current.startButton.wasPressedThisFrame){
                Debug.Log("Start button has been pressed");
            }
        } else {
            startButton = false;
        }
        if (Gamepad.current.selectButton.isPressed){
            selectButton = true;
            if (Gamepad.current.selectButton.wasPressedThisFrame){
                Debug.Log("Select button has been pressed");
            }
        } else {
            selectButton = false;
        }
        if (Gamepad.current.leftStickButton.isPressed){
            L3 = true;
            if (Gamepad.current.leftStickButton.wasPressedThisFrame){
                Debug.Log("L3 has been pressed");
            }
        } else {
            L3 = false;
        }
        if (Gamepad.current.rightStickButton.isPressed){
            R3 = true;
            if (Gamepad.current.rightStickButton.wasPressedThisFrame){
                Debug.Log("R3 has been pressed");
            }
        } else {
            R3 = false;
        }
        if (Gamepad.current.dpad.right.isPressed){
            DPadRight = true;
            if (Gamepad.current.dpad.right.wasPressedThisFrame){
                Debug.Log("D-pad right has been pressed");
            }
        } else {
            DPadRight = false;
        }
        if (Gamepad.current.dpad.left.isPressed){
            DPadLeft = true;
            if (Gamepad.current.dpad.left.wasPressedThisFrame){
                Debug.Log("D-pad left has been pressed");
            }
        } else {
            DPadLeft = false;
        }
        if (Gamepad.current.dpad.up.isPressed){
            DPadUp = true;
            if (Gamepad.current.dpad.up.wasPressedThisFrame){
                Debug.Log("D-pad up has been pressed");
            }
        } else {
            DPadUp = false;
        }
        if (Gamepad.current.dpad.down.isPressed){
            DPadDown = true;
            if (Gamepad.current.dpad.down.wasPressedThisFrame){
                Debug.Log("D-pad down has been pressed");
            }
        } else {
            DPadDown = false;
        }
        if (Gamepad.current.leftStick.right.isPressed){
            LSRight = true;
            if (Gamepad.current.leftStick.right.wasPressedThisFrame){
                Debug.Log("LS has been tilted right");
            }
        } else {
            LSRight = false;
        }
        if (Gamepad.current.leftStick.left.isPressed){
            LSLeft = true;
            if (Gamepad.current.leftStick.left.wasPressedThisFrame){
                Debug.Log("LS has been tilted left");
            }
        } else {
            LSLeft = false;
        }
        if (Gamepad.current.leftStick.up.isPressed){
            LSUp = true;
            if (Gamepad.current.leftStick.up.wasPressedThisFrame){
                Debug.Log("LS has been tilted up");
            }
        } else {
            LSUp = false;
        }
        if (Gamepad.current.leftStick.down.isPressed){
            LSDown = true;
            if (Gamepad.current.leftStick.down.wasPressedThisFrame){
                Debug.Log("LS has been tilted down");
            }
        } else {
            LSDown = false;
        }
        if (Gamepad.current.rightStick.right.isPressed){
            RSRight = true;
            if (Gamepad.current.rightStick.right.wasPressedThisFrame){
                Debug.Log("[RS has been tilted right");
            }
        } else {
            RSRight = false;
        }
        if (Gamepad.current.rightStick.left.isPressed){
            RSLeft = true;
            if (Gamepad.current.rightStick.left.wasPressedThisFrame){
                Debug.Log("RS has been tilted left");
            }
        } else {
            RSLeft = false;
        }
        if (Gamepad.current.rightStick.up.isPressed){
            RSUp = true;
            if (Gamepad.current.rightStick.up.wasPressedThisFrame){
                Debug.Log("RS has been tilted up");
            }
        } else {
            RSUp = false;
        }
        if (Gamepad.current.rightStick.down.isPressed){
            RSDown = true;
            if (Gamepad.current.rightStick.down.wasPressedThisFrame){
                Debug.Log("RS has been tilted down");
            }
        } else {
            RSDown = false;
        }
    }
}
