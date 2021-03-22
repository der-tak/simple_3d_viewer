// GENERATED AUTOMATICALLY FROM 'Assets/Settings/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""SceneController"",
            ""id"": ""3a1fa04f-c466-4e23-89ae-cb67abb0a656"",
            ""actions"": [
                {
                    ""name"": ""RotationControl"",
                    ""type"": ""PassThrough"",
                    ""id"": ""beb0d4f5-1755-4d99-8e9b-6cb1e3c93ec8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""51739d57-748d-436b-b37d-1263632ab547"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ZoomMouse"",
                    ""type"": ""Value"",
                    ""id"": ""3bb18ed0-e849-4078-a3e0-a8a2d1647b22"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""KeyboardInput"",
                    ""id"": ""022d2f62-fa18-4837-aeae-e85b376d9b24"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationControl"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5be3ca52-e94f-4287-82ad-1f5432f4389b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""74f938ac-efdf-4803-9f31-eeb478f1cc50"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ac019d6d-01ad-4033-9180-66a7754276ba"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d85b52e6-d6a6-4aeb-b95c-375e9349f79b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""726e61d3-b002-49fd-a1dd-089f5c553bc0"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5910472d-225d-4cf0-a20f-0ecdee77c893"",
                    ""path"": ""<Touchscreen>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8cb394aa-6d17-4842-994c-ac967b829cde"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6e98672-6da4-418d-b109-3a58c1b9c9b1"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c46e221a-4c0e-47c3-a940-ecca13317be9"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZoomMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // SceneController
        m_SceneController = asset.FindActionMap("SceneController", throwIfNotFound: true);
        m_SceneController_RotationControl = m_SceneController.FindAction("RotationControl", throwIfNotFound: true);
        m_SceneController_Click = m_SceneController.FindAction("Click", throwIfNotFound: true);
        m_SceneController_ZoomMouse = m_SceneController.FindAction("ZoomMouse", throwIfNotFound: true);
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

    // SceneController
    private readonly InputActionMap m_SceneController;
    private ISceneControllerActions m_SceneControllerActionsCallbackInterface;
    private readonly InputAction m_SceneController_RotationControl;
    private readonly InputAction m_SceneController_Click;
    private readonly InputAction m_SceneController_ZoomMouse;
    public struct SceneControllerActions
    {
        private @Controls m_Wrapper;
        public SceneControllerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotationControl => m_Wrapper.m_SceneController_RotationControl;
        public InputAction @Click => m_Wrapper.m_SceneController_Click;
        public InputAction @ZoomMouse => m_Wrapper.m_SceneController_ZoomMouse;
        public InputActionMap Get() { return m_Wrapper.m_SceneController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SceneControllerActions set) { return set.Get(); }
        public void SetCallbacks(ISceneControllerActions instance)
        {
            if (m_Wrapper.m_SceneControllerActionsCallbackInterface != null)
            {
                @RotationControl.started -= m_Wrapper.m_SceneControllerActionsCallbackInterface.OnRotationControl;
                @RotationControl.performed -= m_Wrapper.m_SceneControllerActionsCallbackInterface.OnRotationControl;
                @RotationControl.canceled -= m_Wrapper.m_SceneControllerActionsCallbackInterface.OnRotationControl;
                @Click.started -= m_Wrapper.m_SceneControllerActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_SceneControllerActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_SceneControllerActionsCallbackInterface.OnClick;
                @ZoomMouse.started -= m_Wrapper.m_SceneControllerActionsCallbackInterface.OnZoomMouse;
                @ZoomMouse.performed -= m_Wrapper.m_SceneControllerActionsCallbackInterface.OnZoomMouse;
                @ZoomMouse.canceled -= m_Wrapper.m_SceneControllerActionsCallbackInterface.OnZoomMouse;
            }
            m_Wrapper.m_SceneControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RotationControl.started += instance.OnRotationControl;
                @RotationControl.performed += instance.OnRotationControl;
                @RotationControl.canceled += instance.OnRotationControl;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @ZoomMouse.started += instance.OnZoomMouse;
                @ZoomMouse.performed += instance.OnZoomMouse;
                @ZoomMouse.canceled += instance.OnZoomMouse;
            }
        }
    }
    public SceneControllerActions @SceneController => new SceneControllerActions(this);
    public interface ISceneControllerActions
    {
        void OnRotationControl(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnZoomMouse(InputAction.CallbackContext context);
    }
}
