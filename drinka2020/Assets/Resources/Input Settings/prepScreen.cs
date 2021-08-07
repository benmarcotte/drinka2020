// GENERATED AUTOMATICALLY FROM 'Assets/Resources/Input Settings/prepScreen.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PrepScreen : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PrepScreen()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""prepScreen"",
    ""maps"": [
        {
            ""name"": ""UI"",
            ""id"": ""fa45122a-50eb-4675-b3c5-739e6d4f8a66"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""a51f5bc9-6c59-47b2-9c1b-6a7ed166b397"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""a0b01daf-91c3-420f-a42f-8178f50b3d3b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""34bff369-699e-4f67-8555-f458d14a86c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackDone"",
                    ""type"": ""Button"",
                    ""id"": ""c4343c79-54d1-47e8-bdb0-fde592008025"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=2.55)""
                },
                {
                    ""name"": ""New Character"",
                    ""type"": ""Button"",
                    ""id"": ""14b5d8c0-1025-4f39-826c-66ade5f09eaa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""2a30af12-9f17-4998-8735-b2737909797f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b850736a-c7a5-45c0-aa1a-25c84e5a89e8"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fc28ebe1-0bbc-491a-a5b5-f24b1bff51a6"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9f7d2999-50f2-48fa-b64c-ec54fcaf1075"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""79391828-f062-4504-9f34-824300945e38"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""030e783c-9777-450f-9161-9cec3ee289e0"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""b6c37e58-bb31-4be1-ab6f-0c58720c2641"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""71ac32d2-8f4a-40cd-a317-f9d920199702"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ba870fe7-ac96-4cc5-a260-e7aea372e882"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bc125e5a-51c8-455e-aec6-ee58d618a4f9"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f000eacf-7ae2-4a3f-bea9-0c1bde21df7f"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""923dd3af-d6c5-4ed5-a147-cde5bc5600bd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8d9f4aed-92ee-4c9d-b761-0286cf981dbf"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e804cfb3-983b-4a32-b758-b2f7f1c6e933"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d0aa660c-c243-40c9-8797-f602e9a8669d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3f809c3c-3b72-45a0-a601-4b9736f24ac6"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bffe51c2-8342-47f2-8da5-3b1877f46ac8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9831b05d-fb00-4521-b054-468ab8529a21"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7cb40a6d-d54a-48fe-ae2a-c0e43d660d04"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""519fbb13-0b40-49d9-baef-c86d8fcea375"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c68e8345-47c7-48b0-b4f3-538382b8ab70"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4ca1a66-4e11-4a9f-b32c-8085e691446f"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c065ab2-adf7-4292-86d8-044ac241db26"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f50909e2-fff6-466a-815b-55e79c0d8a6f"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b34a345-e425-4863-9542-1e953c62b76a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""BackDone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e2c1ba1-e2db-448d-90c6-58def1dcdd29"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""BackDone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""046c0af5-76b1-4b7e-a5cb-57197c86dcaf"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""New Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8aab706f-706e-42e9-bc9c-2c79048f4b1f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""New Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""War"",
            ""id"": ""b5e83f45-d947-43a3-957e-848855753631"",
            ""actions"": [
                {
                    ""name"": ""Draw"",
                    ""type"": ""Button"",
                    ""id"": ""6d570b57-324d-47b5-8963-5fd6d2ae4480"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0b8298b3-3054-4155-9649-15f8540279a3"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Draw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d920708-23c0-4c04-b903-3e9aa8b49a00"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Draw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b55ad7d-6dda-4a04-bc07-c85882579655"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Draw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ca93003-0f73-410a-b8c3-c21f1a8681cf"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Draw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5d0d4e6-3b45-4168-89d7-39a95b5843fd"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Draw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Quickdraw"",
            ""id"": ""e54ebe2e-36dd-487e-a18f-b9a1ca7c36b4"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""772ce9ce-bd70-44d3-a35b-e3b2b7e1988d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""85b6f78e-d7d8-485f-b78e-2b0aa6153330"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87e3baa8-3c81-42ab-8849-4b24f46661c6"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e20e225-57e0-4485-8ba4-b76fae6e7ff5"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7558bcf4-02f5-45eb-968e-6fc383568a14"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec849df6-ab07-4109-b430-41f29c546e9d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Sequences"",
            ""id"": ""19b23280-69c8-4911-9ceb-7e3f0b19827f"",
            ""actions"": [
                {
                    ""name"": ""South"",
                    ""type"": ""Button"",
                    ""id"": ""7fa38ccb-51e0-4e32-9be4-500540701576"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""North"",
                    ""type"": ""Button"",
                    ""id"": ""723f57e1-467c-4278-a935-c4e2c3f23b79"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""East"",
                    ""type"": ""Button"",
                    ""id"": ""85cff938-6732-4df9-af61-a56c10a81789"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""West"",
                    ""type"": ""Button"",
                    ""id"": ""44bc7d19-13fb-4134-b5dd-4fc863b18109"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LB"",
                    ""type"": ""Button"",
                    ""id"": ""fb1d9f24-f1b3-4d61-abdb-351aca8dcbbd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RB"",
                    ""type"": ""Button"",
                    ""id"": ""7a9bf0b3-d61c-4c8a-8634-f55bdf9fbaeb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b563824e-4ff3-4dad-8956-cdfb144603f6"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""South"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8100d4d1-4d37-4dca-bdb0-5db7ae13cef1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""South"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0e66ba1-6b0a-4688-8669-abb18b9468db"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""North"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44a97b1d-3a9f-4839-a179-c1636886b9ed"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""North"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""245eb526-e42a-4e7a-97f3-9732b661d067"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""East"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91deadb5-76e7-4a0e-a2d0-e2bc5d6393c8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""East"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1f0f58e-79d0-4487-b828-56414d4f02e4"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""West"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""392d7652-b931-4d61-9d47-59facfeccb76"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""West"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b3762b4-b69e-44e4-8878-a885234ad6e6"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6be449fc-fa0e-48bc-a209-e9736f44ddac"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""LB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a3df5aa-637d-461a-97e7-fb8021f632e1"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""RB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa84bc0c-2546-4c66-b505-00f41af62e25"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""RB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Tug of War"",
            ""id"": ""4b8c06c6-18f6-4ff5-ba1c-56658c659568"",
            ""actions"": [
                {
                    ""name"": ""Pull"",
                    ""type"": ""Button"",
                    ""id"": ""2cf7ba78-0198-42b1-9304-e3c1b863052f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""24f0d070-71e4-42a0-94db-f086c3489ac4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pull"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""201f995f-eea4-49f6-9b67-e67d7e38f6f6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pull"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Pong"",
            ""id"": ""4bfa3601-196f-4404-aff9-c4b42b4e13e7"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""27cf0eb2-fb43-49d7-a8b3-4c21d4b0b6af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""ed446c23-b291-46ec-944d-6997123407ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7b64629a-d6d8-40df-834f-6976640334fc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3799e348-51fe-482b-ac74-ef01dbcb1edf"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""debf1a01-9d8e-4224-86b5-97ebb2a79625"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56581f4d-fd75-41dc-99e5-17b9b0aafb07"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""508ffa8c-4efd-485f-a38c-82b73121623d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dca8f01c-bc76-4253-887f-96a8b34d56f3"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45f25118-d087-49d8-85b7-67257d1553c0"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c66ffd8-0687-4eea-9cec-402370d6cf84"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Navigate = m_UI.FindAction("Navigate", throwIfNotFound: true);
        m_UI_Confirm = m_UI.FindAction("Confirm", throwIfNotFound: true);
        m_UI_Back = m_UI.FindAction("Back", throwIfNotFound: true);
        m_UI_BackDone = m_UI.FindAction("BackDone", throwIfNotFound: true);
        m_UI_NewCharacter = m_UI.FindAction("New Character", throwIfNotFound: true);
        // War
        m_War = asset.FindActionMap("War", throwIfNotFound: true);
        m_War_Draw = m_War.FindAction("Draw", throwIfNotFound: true);
        // Quickdraw
        m_Quickdraw = asset.FindActionMap("Quickdraw", throwIfNotFound: true);
        m_Quickdraw_Shoot = m_Quickdraw.FindAction("Shoot", throwIfNotFound: true);
        // Sequences
        m_Sequences = asset.FindActionMap("Sequences", throwIfNotFound: true);
        m_Sequences_South = m_Sequences.FindAction("South", throwIfNotFound: true);
        m_Sequences_North = m_Sequences.FindAction("North", throwIfNotFound: true);
        m_Sequences_East = m_Sequences.FindAction("East", throwIfNotFound: true);
        m_Sequences_West = m_Sequences.FindAction("West", throwIfNotFound: true);
        m_Sequences_LB = m_Sequences.FindAction("LB", throwIfNotFound: true);
        m_Sequences_RB = m_Sequences.FindAction("RB", throwIfNotFound: true);
        // Tug of War
        m_TugofWar = asset.FindActionMap("Tug of War", throwIfNotFound: true);
        m_TugofWar_Pull = m_TugofWar.FindAction("Pull", throwIfNotFound: true);
        // Pong
        m_Pong = asset.FindActionMap("Pong", throwIfNotFound: true);
        m_Pong_Up = m_Pong.FindAction("Up", throwIfNotFound: true);
        m_Pong_Down = m_Pong.FindAction("Down", throwIfNotFound: true);
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

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Navigate;
    private readonly InputAction m_UI_Confirm;
    private readonly InputAction m_UI_Back;
    private readonly InputAction m_UI_BackDone;
    private readonly InputAction m_UI_NewCharacter;
    public struct UIActions
    {
        private @PrepScreen m_Wrapper;
        public UIActions(@PrepScreen wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_UI_Navigate;
        public InputAction @Confirm => m_Wrapper.m_UI_Confirm;
        public InputAction @Back => m_Wrapper.m_UI_Back;
        public InputAction @BackDone => m_Wrapper.m_UI_BackDone;
        public InputAction @NewCharacter => m_Wrapper.m_UI_NewCharacter;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Confirm.started -= m_Wrapper.m_UIActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnConfirm;
                @Back.started -= m_Wrapper.m_UIActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnBack;
                @BackDone.started -= m_Wrapper.m_UIActionsCallbackInterface.OnBackDone;
                @BackDone.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnBackDone;
                @BackDone.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnBackDone;
                @NewCharacter.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNewCharacter;
                @NewCharacter.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNewCharacter;
                @NewCharacter.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNewCharacter;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
                @BackDone.started += instance.OnBackDone;
                @BackDone.performed += instance.OnBackDone;
                @BackDone.canceled += instance.OnBackDone;
                @NewCharacter.started += instance.OnNewCharacter;
                @NewCharacter.performed += instance.OnNewCharacter;
                @NewCharacter.canceled += instance.OnNewCharacter;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // War
    private readonly InputActionMap m_War;
    private IWarActions m_WarActionsCallbackInterface;
    private readonly InputAction m_War_Draw;
    public struct WarActions
    {
        private @PrepScreen m_Wrapper;
        public WarActions(@PrepScreen wrapper) { m_Wrapper = wrapper; }
        public InputAction @Draw => m_Wrapper.m_War_Draw;
        public InputActionMap Get() { return m_Wrapper.m_War; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WarActions set) { return set.Get(); }
        public void SetCallbacks(IWarActions instance)
        {
            if (m_Wrapper.m_WarActionsCallbackInterface != null)
            {
                @Draw.started -= m_Wrapper.m_WarActionsCallbackInterface.OnDraw;
                @Draw.performed -= m_Wrapper.m_WarActionsCallbackInterface.OnDraw;
                @Draw.canceled -= m_Wrapper.m_WarActionsCallbackInterface.OnDraw;
            }
            m_Wrapper.m_WarActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Draw.started += instance.OnDraw;
                @Draw.performed += instance.OnDraw;
                @Draw.canceled += instance.OnDraw;
            }
        }
    }
    public WarActions @War => new WarActions(this);

    // Quickdraw
    private readonly InputActionMap m_Quickdraw;
    private IQuickdrawActions m_QuickdrawActionsCallbackInterface;
    private readonly InputAction m_Quickdraw_Shoot;
    public struct QuickdrawActions
    {
        private @PrepScreen m_Wrapper;
        public QuickdrawActions(@PrepScreen wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_Quickdraw_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_Quickdraw; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(QuickdrawActions set) { return set.Get(); }
        public void SetCallbacks(IQuickdrawActions instance)
        {
            if (m_Wrapper.m_QuickdrawActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_QuickdrawActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_QuickdrawActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_QuickdrawActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_QuickdrawActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public QuickdrawActions @Quickdraw => new QuickdrawActions(this);

    // Sequences
    private readonly InputActionMap m_Sequences;
    private ISequencesActions m_SequencesActionsCallbackInterface;
    private readonly InputAction m_Sequences_South;
    private readonly InputAction m_Sequences_North;
    private readonly InputAction m_Sequences_East;
    private readonly InputAction m_Sequences_West;
    private readonly InputAction m_Sequences_LB;
    private readonly InputAction m_Sequences_RB;
    public struct SequencesActions
    {
        private @PrepScreen m_Wrapper;
        public SequencesActions(@PrepScreen wrapper) { m_Wrapper = wrapper; }
        public InputAction @South => m_Wrapper.m_Sequences_South;
        public InputAction @North => m_Wrapper.m_Sequences_North;
        public InputAction @East => m_Wrapper.m_Sequences_East;
        public InputAction @West => m_Wrapper.m_Sequences_West;
        public InputAction @LB => m_Wrapper.m_Sequences_LB;
        public InputAction @RB => m_Wrapper.m_Sequences_RB;
        public InputActionMap Get() { return m_Wrapper.m_Sequences; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SequencesActions set) { return set.Get(); }
        public void SetCallbacks(ISequencesActions instance)
        {
            if (m_Wrapper.m_SequencesActionsCallbackInterface != null)
            {
                @South.started -= m_Wrapper.m_SequencesActionsCallbackInterface.OnSouth;
                @South.performed -= m_Wrapper.m_SequencesActionsCallbackInterface.OnSouth;
                @South.canceled -= m_Wrapper.m_SequencesActionsCallbackInterface.OnSouth;
                @North.started -= m_Wrapper.m_SequencesActionsCallbackInterface.OnNorth;
                @North.performed -= m_Wrapper.m_SequencesActionsCallbackInterface.OnNorth;
                @North.canceled -= m_Wrapper.m_SequencesActionsCallbackInterface.OnNorth;
                @East.started -= m_Wrapper.m_SequencesActionsCallbackInterface.OnEast;
                @East.performed -= m_Wrapper.m_SequencesActionsCallbackInterface.OnEast;
                @East.canceled -= m_Wrapper.m_SequencesActionsCallbackInterface.OnEast;
                @West.started -= m_Wrapper.m_SequencesActionsCallbackInterface.OnWest;
                @West.performed -= m_Wrapper.m_SequencesActionsCallbackInterface.OnWest;
                @West.canceled -= m_Wrapper.m_SequencesActionsCallbackInterface.OnWest;
                @LB.started -= m_Wrapper.m_SequencesActionsCallbackInterface.OnLB;
                @LB.performed -= m_Wrapper.m_SequencesActionsCallbackInterface.OnLB;
                @LB.canceled -= m_Wrapper.m_SequencesActionsCallbackInterface.OnLB;
                @RB.started -= m_Wrapper.m_SequencesActionsCallbackInterface.OnRB;
                @RB.performed -= m_Wrapper.m_SequencesActionsCallbackInterface.OnRB;
                @RB.canceled -= m_Wrapper.m_SequencesActionsCallbackInterface.OnRB;
            }
            m_Wrapper.m_SequencesActionsCallbackInterface = instance;
            if (instance != null)
            {
                @South.started += instance.OnSouth;
                @South.performed += instance.OnSouth;
                @South.canceled += instance.OnSouth;
                @North.started += instance.OnNorth;
                @North.performed += instance.OnNorth;
                @North.canceled += instance.OnNorth;
                @East.started += instance.OnEast;
                @East.performed += instance.OnEast;
                @East.canceled += instance.OnEast;
                @West.started += instance.OnWest;
                @West.performed += instance.OnWest;
                @West.canceled += instance.OnWest;
                @LB.started += instance.OnLB;
                @LB.performed += instance.OnLB;
                @LB.canceled += instance.OnLB;
                @RB.started += instance.OnRB;
                @RB.performed += instance.OnRB;
                @RB.canceled += instance.OnRB;
            }
        }
    }
    public SequencesActions @Sequences => new SequencesActions(this);

    // Tug of War
    private readonly InputActionMap m_TugofWar;
    private ITugofWarActions m_TugofWarActionsCallbackInterface;
    private readonly InputAction m_TugofWar_Pull;
    public struct TugofWarActions
    {
        private @PrepScreen m_Wrapper;
        public TugofWarActions(@PrepScreen wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pull => m_Wrapper.m_TugofWar_Pull;
        public InputActionMap Get() { return m_Wrapper.m_TugofWar; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TugofWarActions set) { return set.Get(); }
        public void SetCallbacks(ITugofWarActions instance)
        {
            if (m_Wrapper.m_TugofWarActionsCallbackInterface != null)
            {
                @Pull.started -= m_Wrapper.m_TugofWarActionsCallbackInterface.OnPull;
                @Pull.performed -= m_Wrapper.m_TugofWarActionsCallbackInterface.OnPull;
                @Pull.canceled -= m_Wrapper.m_TugofWarActionsCallbackInterface.OnPull;
            }
            m_Wrapper.m_TugofWarActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pull.started += instance.OnPull;
                @Pull.performed += instance.OnPull;
                @Pull.canceled += instance.OnPull;
            }
        }
    }
    public TugofWarActions @TugofWar => new TugofWarActions(this);

    // Pong
    private readonly InputActionMap m_Pong;
    private IPongActions m_PongActionsCallbackInterface;
    private readonly InputAction m_Pong_Up;
    private readonly InputAction m_Pong_Down;
    public struct PongActions
    {
        private @PrepScreen m_Wrapper;
        public PongActions(@PrepScreen wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_Pong_Up;
        public InputAction @Down => m_Wrapper.m_Pong_Down;
        public InputActionMap Get() { return m_Wrapper.m_Pong; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PongActions set) { return set.Get(); }
        public void SetCallbacks(IPongActions instance)
        {
            if (m_Wrapper.m_PongActionsCallbackInterface != null)
            {
                @Up.started -= m_Wrapper.m_PongActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_PongActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_PongActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_PongActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_PongActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_PongActionsCallbackInterface.OnDown;
            }
            m_Wrapper.m_PongActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
            }
        }
    }
    public PongActions @Pong => new PongActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IUIActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
        void OnBackDone(InputAction.CallbackContext context);
        void OnNewCharacter(InputAction.CallbackContext context);
    }
    public interface IWarActions
    {
        void OnDraw(InputAction.CallbackContext context);
    }
    public interface IQuickdrawActions
    {
        void OnShoot(InputAction.CallbackContext context);
    }
    public interface ISequencesActions
    {
        void OnSouth(InputAction.CallbackContext context);
        void OnNorth(InputAction.CallbackContext context);
        void OnEast(InputAction.CallbackContext context);
        void OnWest(InputAction.CallbackContext context);
        void OnLB(InputAction.CallbackContext context);
        void OnRB(InputAction.CallbackContext context);
    }
    public interface ITugofWarActions
    {
        void OnPull(InputAction.CallbackContext context);
    }
    public interface IPongActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
    }
}
