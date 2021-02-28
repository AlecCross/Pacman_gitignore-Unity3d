// GENERATED AUTOMATICALLY FROM 'Assets/InputSystems/XboxOneController/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""a1f1561d-403e-4c2a-9ceb-4ac8dc70189f"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a16b5f35-5af8-46bc-a577-af97a94e6478"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MenuPause"",
                    ""type"": ""Button"",
                    ""id"": ""2966054c-6d10-4438-bf03-edede1c18ddc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveUpDpad"",
                    ""type"": ""Button"",
                    ""id"": ""ac36c132-d011-4e57-8e10-1b1d1e7a5428"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveDownDpad"",
                    ""type"": ""Button"",
                    ""id"": ""b9968f81-29d1-43c7-abd1-43d8f34a9995"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeftDpad"",
                    ""type"": ""Button"",
                    ""id"": ""99050f76-fc9f-4712-bd1a-0859e2e3c594"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRightDpad"",
                    ""type"": ""Button"",
                    ""id"": ""325575ac-68fc-43ca-8134-970a84789a39"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""abb0f2c3-cd84-4c50-9770-46d3438c22b3"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUpDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4f09cd6-1418-408a-8db2-3a103be1b5ce"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDownDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1894eed5-8e34-4465-aac6-816dc02941b2"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeftDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b367be8-aa5d-451e-a1c8-8e1faa8d1909"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRightDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76826075-8bf8-4c57-a2bf-97eff670a74f"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b4180cf-a126-401f-addc-a4095aa694e0"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuPause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay_MenuPause = m_Gameplay.FindAction("MenuPause", throwIfNotFound: true);
        m_Gameplay_MoveUpDpad = m_Gameplay.FindAction("MoveUpDpad", throwIfNotFound: true);
        m_Gameplay_MoveDownDpad = m_Gameplay.FindAction("MoveDownDpad", throwIfNotFound: true);
        m_Gameplay_MoveLeftDpad = m_Gameplay.FindAction("MoveLeftDpad", throwIfNotFound: true);
        m_Gameplay_MoveRightDpad = m_Gameplay.FindAction("MoveRightDpad", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Jump;
    private readonly InputAction m_Gameplay_MenuPause;
    private readonly InputAction m_Gameplay_MoveUpDpad;
    private readonly InputAction m_Gameplay_MoveDownDpad;
    private readonly InputAction m_Gameplay_MoveLeftDpad;
    private readonly InputAction m_Gameplay_MoveRightDpad;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputAction @MenuPause => m_Wrapper.m_Gameplay_MenuPause;
        public InputAction @MoveUpDpad => m_Wrapper.m_Gameplay_MoveUpDpad;
        public InputAction @MoveDownDpad => m_Wrapper.m_Gameplay_MoveDownDpad;
        public InputAction @MoveLeftDpad => m_Wrapper.m_Gameplay_MoveLeftDpad;
        public InputAction @MoveRightDpad => m_Wrapper.m_Gameplay_MoveRightDpad;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @MenuPause.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMenuPause;
                @MenuPause.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMenuPause;
                @MenuPause.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMenuPause;
                @MoveUpDpad.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveUpDpad;
                @MoveUpDpad.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveUpDpad;
                @MoveUpDpad.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveUpDpad;
                @MoveDownDpad.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveDownDpad;
                @MoveDownDpad.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveDownDpad;
                @MoveDownDpad.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveDownDpad;
                @MoveLeftDpad.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveLeftDpad;
                @MoveLeftDpad.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveLeftDpad;
                @MoveLeftDpad.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveLeftDpad;
                @MoveRightDpad.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveRightDpad;
                @MoveRightDpad.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveRightDpad;
                @MoveRightDpad.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveRightDpad;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MenuPause.started += instance.OnMenuPause;
                @MenuPause.performed += instance.OnMenuPause;
                @MenuPause.canceled += instance.OnMenuPause;
                @MoveUpDpad.started += instance.OnMoveUpDpad;
                @MoveUpDpad.performed += instance.OnMoveUpDpad;
                @MoveUpDpad.canceled += instance.OnMoveUpDpad;
                @MoveDownDpad.started += instance.OnMoveDownDpad;
                @MoveDownDpad.performed += instance.OnMoveDownDpad;
                @MoveDownDpad.canceled += instance.OnMoveDownDpad;
                @MoveLeftDpad.started += instance.OnMoveLeftDpad;
                @MoveLeftDpad.performed += instance.OnMoveLeftDpad;
                @MoveLeftDpad.canceled += instance.OnMoveLeftDpad;
                @MoveRightDpad.started += instance.OnMoveRightDpad;
                @MoveRightDpad.performed += instance.OnMoveRightDpad;
                @MoveRightDpad.canceled += instance.OnMoveRightDpad;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMenuPause(InputAction.CallbackContext context);
        void OnMoveUpDpad(InputAction.CallbackContext context);
        void OnMoveDownDpad(InputAction.CallbackContext context);
        void OnMoveLeftDpad(InputAction.CallbackContext context);
        void OnMoveRightDpad(InputAction.CallbackContext context);
    }
}
