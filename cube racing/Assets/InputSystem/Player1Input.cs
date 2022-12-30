//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/InputSystem/Player1Input.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Player1Input : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player1Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player1Input"",
    ""maps"": [
        {
            ""name"": ""Player1"",
            ""id"": ""76071af9-bb10-45cb-8320-078d732f0c37"",
            ""actions"": [
                {
                    ""name"": ""Throw"",
                    ""type"": ""Button"",
                    ""id"": ""bdb9c8ad-08b6-4c30-b11e-1f47b531f259"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""d9cf3e85-c4bd-4956-9a73-95b36e76d28c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveTouch"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b93bca39-7815-453e-8a61-e2a13d4aae47"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MovePress"",
                    ""type"": ""Button"",
                    ""id"": ""ece26387-c2bd-4dc0-ba7a-5ce9114e3f34"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveTouchPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f8749099-613b-45c6-8cec-13b32b29e40f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ThrowPress"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d37e76d0-85ef-43b3-ac62-743aa06d7f7b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ThrowPress1"",
                    ""type"": ""Button"",
                    ""id"": ""6a9517ea-43f9-487c-b7f7-3bfcce78b926"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f649bc54-edbf-4f6d-8598-66a16fc272a5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9bf63432-dca8-4617-86f0-074cceb23103"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4aba43bb-b0bb-4fce-95d1-23430a62a7b6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""46484acf-f12f-40b1-815d-620322f7f708"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bd048002-fd31-4c40-8891-90b5ef01b97f"",
                    ""path"": ""<Touchscreen>/primaryTouch"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe74b532-a2ef-4381-b982-2688e22d6062"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": ""Hold(duration=0.2,pressPoint=0.2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovePress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e07ac52e-37b3-4fb1-9b68-b5c12b33f3be"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveTouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e44752d-850a-4ab7-96a9-f16cb0253cb8"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": ""Tap(duration=0.2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThrowPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d501fdbe-1dba-4152-bc8b-f1781c9d957e"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThrowPress1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_Throw = m_Player1.FindAction("Throw", throwIfNotFound: true);
        m_Player1_Move = m_Player1.FindAction("Move", throwIfNotFound: true);
        m_Player1_MoveTouch = m_Player1.FindAction("MoveTouch", throwIfNotFound: true);
        m_Player1_MovePress = m_Player1.FindAction("MovePress", throwIfNotFound: true);
        m_Player1_MoveTouchPosition = m_Player1.FindAction("MoveTouchPosition", throwIfNotFound: true);
        m_Player1_ThrowPress = m_Player1.FindAction("ThrowPress", throwIfNotFound: true);
        m_Player1_ThrowPress1 = m_Player1.FindAction("ThrowPress1", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_Throw;
    private readonly InputAction m_Player1_Move;
    private readonly InputAction m_Player1_MoveTouch;
    private readonly InputAction m_Player1_MovePress;
    private readonly InputAction m_Player1_MoveTouchPosition;
    private readonly InputAction m_Player1_ThrowPress;
    private readonly InputAction m_Player1_ThrowPress1;
    public struct Player1Actions
    {
        private @Player1Input m_Wrapper;
        public Player1Actions(@Player1Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Throw => m_Wrapper.m_Player1_Throw;
        public InputAction @Move => m_Wrapper.m_Player1_Move;
        public InputAction @MoveTouch => m_Wrapper.m_Player1_MoveTouch;
        public InputAction @MovePress => m_Wrapper.m_Player1_MovePress;
        public InputAction @MoveTouchPosition => m_Wrapper.m_Player1_MoveTouchPosition;
        public InputAction @ThrowPress => m_Wrapper.m_Player1_ThrowPress;
        public InputAction @ThrowPress1 => m_Wrapper.m_Player1_ThrowPress1;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @Throw.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnThrow;
                @Throw.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnThrow;
                @Throw.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnThrow;
                @Move.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                @MoveTouch.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMoveTouch;
                @MoveTouch.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMoveTouch;
                @MoveTouch.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMoveTouch;
                @MovePress.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovePress;
                @MovePress.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovePress;
                @MovePress.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovePress;
                @MoveTouchPosition.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMoveTouchPosition;
                @MoveTouchPosition.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMoveTouchPosition;
                @MoveTouchPosition.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMoveTouchPosition;
                @ThrowPress.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnThrowPress;
                @ThrowPress.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnThrowPress;
                @ThrowPress.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnThrowPress;
                @ThrowPress1.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnThrowPress1;
                @ThrowPress1.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnThrowPress1;
                @ThrowPress1.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnThrowPress1;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Throw.started += instance.OnThrow;
                @Throw.performed += instance.OnThrow;
                @Throw.canceled += instance.OnThrow;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @MoveTouch.started += instance.OnMoveTouch;
                @MoveTouch.performed += instance.OnMoveTouch;
                @MoveTouch.canceled += instance.OnMoveTouch;
                @MovePress.started += instance.OnMovePress;
                @MovePress.performed += instance.OnMovePress;
                @MovePress.canceled += instance.OnMovePress;
                @MoveTouchPosition.started += instance.OnMoveTouchPosition;
                @MoveTouchPosition.performed += instance.OnMoveTouchPosition;
                @MoveTouchPosition.canceled += instance.OnMoveTouchPosition;
                @ThrowPress.started += instance.OnThrowPress;
                @ThrowPress.performed += instance.OnThrowPress;
                @ThrowPress.canceled += instance.OnThrowPress;
                @ThrowPress1.started += instance.OnThrowPress1;
                @ThrowPress1.performed += instance.OnThrowPress1;
                @ThrowPress1.canceled += instance.OnThrowPress1;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);
    public interface IPlayer1Actions
    {
        void OnThrow(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnMoveTouch(InputAction.CallbackContext context);
        void OnMovePress(InputAction.CallbackContext context);
        void OnMoveTouchPosition(InputAction.CallbackContext context);
        void OnThrowPress(InputAction.CallbackContext context);
        void OnThrowPress1(InputAction.CallbackContext context);
    }
}