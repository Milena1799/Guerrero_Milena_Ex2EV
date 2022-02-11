// GENERATED AUTOMATICALLY FROM 'Assets/Controller/InputController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputController"",
    ""maps"": [
        {
            ""name"": ""Moverse"",
            ""id"": ""588e2273-af43-4289-aaac-0992a6ec5426"",
            ""actions"": [
                {
                    ""name"": ""Caminar"",
                    ""type"": ""Value"",
                    ""id"": ""f1862489-332c-4914-9d8d-cdf90604efcb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GiroIzq"",
                    ""type"": ""Button"",
                    ""id"": ""c2749b43-0891-4080-a48b-db3cd3c6effe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GiroDer"",
                    ""type"": ""Button"",
                    ""id"": ""ac6a0e0c-5a27-4152-bd94-674087a6efb8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Correr"",
                    ""type"": ""Button"",
                    ""id"": ""d96194e4-f411-420d-9123-eb915040d3ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Button"",
                    ""id"": ""853cb03c-e280-4b65-94c4-d2f6975c1eb2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""019cb10a-bbf9-4179-b46c-d48c0047998f"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Caminar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""039b32e1-ca95-4be9-825c-de221aff6786"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GiroIzq"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a29072af-c619-4967-b172-d69c4d4abbaa"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GiroDer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10b5d703-85b6-4d41-9a21-3d3c115e353e"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Correr"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc2c4690-7b9d-49d1-b8c9-612df0503e51"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camara"",
            ""id"": ""508fa3f4-e8af-43ff-9f14-5b6f1739612e"",
            ""actions"": [
                {
                    ""name"": ""camara"",
                    ""type"": ""Value"",
                    ""id"": ""9b40d644-bf22-4bea-8b71-9a196e95aed1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1ab8f192-53d6-4134-8e9f-6bb84123e5a2"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""camara"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Moverse
        m_Moverse = asset.FindActionMap("Moverse", throwIfNotFound: true);
        m_Moverse_Caminar = m_Moverse.FindAction("Caminar", throwIfNotFound: true);
        m_Moverse_GiroIzq = m_Moverse.FindAction("GiroIzq", throwIfNotFound: true);
        m_Moverse_GiroDer = m_Moverse.FindAction("GiroDer", throwIfNotFound: true);
        m_Moverse_Correr = m_Moverse.FindAction("Correr", throwIfNotFound: true);
        m_Moverse_Roll = m_Moverse.FindAction("Roll", throwIfNotFound: true);
        // Camara
        m_Camara = asset.FindActionMap("Camara", throwIfNotFound: true);
        m_Camara_camara = m_Camara.FindAction("camara", throwIfNotFound: true);
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

    // Moverse
    private readonly InputActionMap m_Moverse;
    private IMoverseActions m_MoverseActionsCallbackInterface;
    private readonly InputAction m_Moverse_Caminar;
    private readonly InputAction m_Moverse_GiroIzq;
    private readonly InputAction m_Moverse_GiroDer;
    private readonly InputAction m_Moverse_Correr;
    private readonly InputAction m_Moverse_Roll;
    public struct MoverseActions
    {
        private @InputController m_Wrapper;
        public MoverseActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Caminar => m_Wrapper.m_Moverse_Caminar;
        public InputAction @GiroIzq => m_Wrapper.m_Moverse_GiroIzq;
        public InputAction @GiroDer => m_Wrapper.m_Moverse_GiroDer;
        public InputAction @Correr => m_Wrapper.m_Moverse_Correr;
        public InputAction @Roll => m_Wrapper.m_Moverse_Roll;
        public InputActionMap Get() { return m_Wrapper.m_Moverse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoverseActions set) { return set.Get(); }
        public void SetCallbacks(IMoverseActions instance)
        {
            if (m_Wrapper.m_MoverseActionsCallbackInterface != null)
            {
                @Caminar.started -= m_Wrapper.m_MoverseActionsCallbackInterface.OnCaminar;
                @Caminar.performed -= m_Wrapper.m_MoverseActionsCallbackInterface.OnCaminar;
                @Caminar.canceled -= m_Wrapper.m_MoverseActionsCallbackInterface.OnCaminar;
                @GiroIzq.started -= m_Wrapper.m_MoverseActionsCallbackInterface.OnGiroIzq;
                @GiroIzq.performed -= m_Wrapper.m_MoverseActionsCallbackInterface.OnGiroIzq;
                @GiroIzq.canceled -= m_Wrapper.m_MoverseActionsCallbackInterface.OnGiroIzq;
                @GiroDer.started -= m_Wrapper.m_MoverseActionsCallbackInterface.OnGiroDer;
                @GiroDer.performed -= m_Wrapper.m_MoverseActionsCallbackInterface.OnGiroDer;
                @GiroDer.canceled -= m_Wrapper.m_MoverseActionsCallbackInterface.OnGiroDer;
                @Correr.started -= m_Wrapper.m_MoverseActionsCallbackInterface.OnCorrer;
                @Correr.performed -= m_Wrapper.m_MoverseActionsCallbackInterface.OnCorrer;
                @Correr.canceled -= m_Wrapper.m_MoverseActionsCallbackInterface.OnCorrer;
                @Roll.started -= m_Wrapper.m_MoverseActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_MoverseActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_MoverseActionsCallbackInterface.OnRoll;
            }
            m_Wrapper.m_MoverseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Caminar.started += instance.OnCaminar;
                @Caminar.performed += instance.OnCaminar;
                @Caminar.canceled += instance.OnCaminar;
                @GiroIzq.started += instance.OnGiroIzq;
                @GiroIzq.performed += instance.OnGiroIzq;
                @GiroIzq.canceled += instance.OnGiroIzq;
                @GiroDer.started += instance.OnGiroDer;
                @GiroDer.performed += instance.OnGiroDer;
                @GiroDer.canceled += instance.OnGiroDer;
                @Correr.started += instance.OnCorrer;
                @Correr.performed += instance.OnCorrer;
                @Correr.canceled += instance.OnCorrer;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
            }
        }
    }
    public MoverseActions @Moverse => new MoverseActions(this);

    // Camara
    private readonly InputActionMap m_Camara;
    private ICamaraActions m_CamaraActionsCallbackInterface;
    private readonly InputAction m_Camara_camara;
    public struct CamaraActions
    {
        private @InputController m_Wrapper;
        public CamaraActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @camara => m_Wrapper.m_Camara_camara;
        public InputActionMap Get() { return m_Wrapper.m_Camara; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CamaraActions set) { return set.Get(); }
        public void SetCallbacks(ICamaraActions instance)
        {
            if (m_Wrapper.m_CamaraActionsCallbackInterface != null)
            {
                @camara.started -= m_Wrapper.m_CamaraActionsCallbackInterface.OnCamara;
                @camara.performed -= m_Wrapper.m_CamaraActionsCallbackInterface.OnCamara;
                @camara.canceled -= m_Wrapper.m_CamaraActionsCallbackInterface.OnCamara;
            }
            m_Wrapper.m_CamaraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @camara.started += instance.OnCamara;
                @camara.performed += instance.OnCamara;
                @camara.canceled += instance.OnCamara;
            }
        }
    }
    public CamaraActions @Camara => new CamaraActions(this);
    public interface IMoverseActions
    {
        void OnCaminar(InputAction.CallbackContext context);
        void OnGiroIzq(InputAction.CallbackContext context);
        void OnGiroDer(InputAction.CallbackContext context);
        void OnCorrer(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
    }
    public interface ICamaraActions
    {
        void OnCamara(InputAction.CallbackContext context);
    }
}
