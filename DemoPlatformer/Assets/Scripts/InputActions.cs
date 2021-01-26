// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Jump"",
            ""id"": ""c58c7493-7382-432e-9fc4-071c6b4b72ad"",
            ""actions"": [
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""9e37386b-fa9a-4b16-9d4a-79e648537dfe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""aec8ddbe-f6ea-40e7-8a01-01a7ced83c75"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""633cb0dc-421f-4439-9949-1ad89c33d0e2"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Land"",
            ""id"": ""1366b359-648b-411c-b649-f1a6ce4ff042"",
            ""actions"": [
                {
                    ""name"": ""sideways"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5d8e5421-df71-4188-a3be-e96945c68270"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keys"",
                    ""id"": ""df26a066-063a-432d-8371-07a547db9d0c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sideways"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""82bba294-d76c-40dc-89b6-e9a08fe4ead0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sideways"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""244fe7c0-8d52-4418-82ab-1c0995a7c8a9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sideways"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""1e8eb94d-16ec-4f5f-8113-849272f9ce60"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sideways"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ef6df326-9414-40d5-b028-0c732f1a6794"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sideways"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""44b861ce-a668-4bbc-88f6-1ddc50294362"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sideways"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controller"",
                    ""id"": ""006b4ba5-4ea8-46a6-9f54-a67642de1b03"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sideways"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""aa40e39a-85ca-430d-b1d6-0ce34dcaa62a"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sideways"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""c5b2b1d1-0a7a-4957-ae50-225a0ef9360c"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sideways"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Jump
        m_Jump = asset.FindActionMap("Jump", throwIfNotFound: true);
        m_Jump_jump = m_Jump.FindAction("jump", throwIfNotFound: true);
        // Land
        m_Land = asset.FindActionMap("Land", throwIfNotFound: true);
        m_Land_sideways = m_Land.FindAction("sideways", throwIfNotFound: true);
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

    // Jump
    private readonly InputActionMap m_Jump;
    private IJumpActions m_JumpActionsCallbackInterface;
    private readonly InputAction m_Jump_jump;
    public struct JumpActions
    {
        private @InputActions m_Wrapper;
        public JumpActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @jump => m_Wrapper.m_Jump_jump;
        public InputActionMap Get() { return m_Wrapper.m_Jump; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JumpActions set) { return set.Get(); }
        public void SetCallbacks(IJumpActions instance)
        {
            if (m_Wrapper.m_JumpActionsCallbackInterface != null)
            {
                @jump.started -= m_Wrapper.m_JumpActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_JumpActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_JumpActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_JumpActionsCallbackInterface = instance;
            if (instance != null)
            {
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
            }
        }
    }
    public JumpActions @Jump => new JumpActions(this);

    // Land
    private readonly InputActionMap m_Land;
    private ILandActions m_LandActionsCallbackInterface;
    private readonly InputAction m_Land_sideways;
    public struct LandActions
    {
        private @InputActions m_Wrapper;
        public LandActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @sideways => m_Wrapper.m_Land_sideways;
        public InputActionMap Get() { return m_Wrapper.m_Land; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LandActions set) { return set.Get(); }
        public void SetCallbacks(ILandActions instance)
        {
            if (m_Wrapper.m_LandActionsCallbackInterface != null)
            {
                @sideways.started -= m_Wrapper.m_LandActionsCallbackInterface.OnSideways;
                @sideways.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnSideways;
                @sideways.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnSideways;
            }
            m_Wrapper.m_LandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @sideways.started += instance.OnSideways;
                @sideways.performed += instance.OnSideways;
                @sideways.canceled += instance.OnSideways;
            }
        }
    }
    public LandActions @Land => new LandActions(this);
    public interface IJumpActions
    {
        void OnJump(InputAction.CallbackContext context);
    }
    public interface ILandActions
    {
        void OnSideways(InputAction.CallbackContext context);
    }
}
