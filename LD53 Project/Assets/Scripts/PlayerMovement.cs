//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Scripts/PlayerMovement.inputactions
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

public partial class @PlayerMovement: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerMovement()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerMovement"",
    ""maps"": [
        {
            ""name"": ""tileMovement"",
            ""id"": ""262051ad-343f-41e1-a85f-33682dfcf7c2"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""791678e8-7fd2-48a6-9bfe-f35de979f003"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveBox"",
                    ""type"": ""Button"",
                    ""id"": ""a54a00de-1346-4866-b385-5592eec0e0a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PullBox"",
                    ""type"": ""Button"",
                    ""id"": ""2b8f1996-e9b0-4ab3-8d0e-75fcfcc4d72c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""e68817c9-01f3-48f8-ada4-8de162105d93"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press"",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""90a76b09-1479-486b-b6c6-3b0d3d395316"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8d633205-b2db-4718-9d48-df3f059110a8"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e0fe2f4a-b929-494c-abd4-e99ac6d23449"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""63b47e22-2b26-4f4e-bcb6-a6eeb3b5fad0"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9393212d-f7ee-4290-ad57-79b59b2c2bac"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveBox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71824801-4950-4342-81b4-d4d738098834"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PullBox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // tileMovement
        m_tileMovement = asset.FindActionMap("tileMovement", throwIfNotFound: true);
        m_tileMovement_Movement = m_tileMovement.FindAction("Movement", throwIfNotFound: true);
        m_tileMovement_MoveBox = m_tileMovement.FindAction("MoveBox", throwIfNotFound: true);
        m_tileMovement_PullBox = m_tileMovement.FindAction("PullBox", throwIfNotFound: true);
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

    // tileMovement
    private readonly InputActionMap m_tileMovement;
    private List<ITileMovementActions> m_TileMovementActionsCallbackInterfaces = new List<ITileMovementActions>();
    private readonly InputAction m_tileMovement_Movement;
    private readonly InputAction m_tileMovement_MoveBox;
    private readonly InputAction m_tileMovement_PullBox;
    public struct TileMovementActions
    {
        private @PlayerMovement m_Wrapper;
        public TileMovementActions(@PlayerMovement wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_tileMovement_Movement;
        public InputAction @MoveBox => m_Wrapper.m_tileMovement_MoveBox;
        public InputAction @PullBox => m_Wrapper.m_tileMovement_PullBox;
        public InputActionMap Get() { return m_Wrapper.m_tileMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TileMovementActions set) { return set.Get(); }
        public void AddCallbacks(ITileMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_TileMovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TileMovementActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @MoveBox.started += instance.OnMoveBox;
            @MoveBox.performed += instance.OnMoveBox;
            @MoveBox.canceled += instance.OnMoveBox;
            @PullBox.started += instance.OnPullBox;
            @PullBox.performed += instance.OnPullBox;
            @PullBox.canceled += instance.OnPullBox;
        }

        private void UnregisterCallbacks(ITileMovementActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @MoveBox.started -= instance.OnMoveBox;
            @MoveBox.performed -= instance.OnMoveBox;
            @MoveBox.canceled -= instance.OnMoveBox;
            @PullBox.started -= instance.OnPullBox;
            @PullBox.performed -= instance.OnPullBox;
            @PullBox.canceled -= instance.OnPullBox;
        }

        public void RemoveCallbacks(ITileMovementActions instance)
        {
            if (m_Wrapper.m_TileMovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITileMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_TileMovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TileMovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TileMovementActions @tileMovement => new TileMovementActions(this);
    public interface ITileMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnMoveBox(InputAction.CallbackContext context);
        void OnPullBox(InputAction.CallbackContext context);
    }
}
