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
                },
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""7db4c78e-af32-4520-8892-01131971252e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
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
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""1b34bcfe-6ded-46a6-b22c-32bcd1d67beb"",
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
                    ""id"": ""2c262563-6822-463b-95b6-120d8d4b5437"",
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
                    ""id"": ""fb0b2f8f-789d-49f7-a721-b56c5f1236fc"",
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
                    ""id"": ""81b1f391-ccca-4c86-8ba0-733404ec4dcd"",
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
                    ""id"": ""776450c4-2e60-427d-8af4-5dc1aea65ef1"",
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
                    ""id"": ""7188a6ef-ba5d-404b-809c-b98a28499b96"",
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
                    ""id"": ""e506e6c5-bfac-4f1a-826f-ff403c595589"",
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
                    ""id"": ""8728805c-b73a-403c-88c0-a4de3ebe7771"",
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
                    ""id"": ""e5f944a7-40e3-4bc5-874d-51fc6b12bfea"",
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
                    ""id"": ""dcacfb8e-957c-4428-a0b3-b4e93edf6c80"",
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
                    ""id"": ""9d9aa797-c0b5-45fa-998f-04b841379531"",
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
                    ""id"": ""0ceacc1d-52f3-4697-b7a2-0fc714c28db4"",
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
                    ""id"": ""44adc01b-6a18-4014-88b2-f668a19e9913"",
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
                    ""id"": ""b4d49ce0-3cf4-41e7-8b68-34c3c9cbf75d"",
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
                    ""id"": ""ac4a944b-983e-4be9-aeb6-ac8170e54ac0"",
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
                    ""id"": ""a2afbf96-f10f-43e9-9e4b-ad3899fc2589"",
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
                    ""id"": ""6665fde6-5020-4f93-a999-b3392f694db2"",
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
                    ""id"": ""edc51c79-617f-4fd7-a817-a7b8b96451d2"",
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
                    ""id"": ""835a0e08-25ff-4f46-9b68-f6c00e9af08d"",
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
                    ""id"": ""816694b3-f22d-4482-9faf-0bfb79ab4a42"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
            ""name"": ""Rock Paper Scissors"",
            ""id"": ""921a32ab-2e30-44f7-b059-88802c5782d6"",
            ""actions"": [
                {
                    ""name"": ""Rock"",
                    ""type"": ""Button"",
                    ""id"": ""909d61a2-6181-42ee-a1e5-235bf468b8dc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Paper"",
                    ""type"": ""Button"",
                    ""id"": ""175b388e-d3d3-4acb-812a-786cf87f92c1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scissors"",
                    ""type"": ""Button"",
                    ""id"": ""5bfeb480-3a44-48a2-841d-c04a9252d396"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a34ef172-c95f-4d34-86c7-039e67a1d81c"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d720d83-f728-4cf3-ba9f-0bcf7344662e"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8c81a40-29a8-4443-8ad3-d7fab7463046"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Paper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6ecfd42-00b9-4c0c-8072-b38871912ec7"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Paper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87e69a74-1e95-46b4-a024-d62892aa2ea8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scissors"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80f71cb3-97ea-416e-b007-675b8426269d"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scissors"",
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
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""ed446c23-b291-46ec-944d-6997123407ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""UpRelease"",
                    ""type"": ""Button"",
                    ""id"": ""a17403a8-46e9-4bee-a371-c39261e290df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""Invert"",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""DownRelease"",
                    ""type"": ""Button"",
                    ""id"": ""83b869ad-97cd-4d4d-92f3-9d3f1a6c11a5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""Invert"",
                    ""interactions"": ""Press(behavior=1)""
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
                    ""id"": ""16901d58-c4bc-4f64-abfb-e2e5abc6c2fe"",
                    ""path"": ""<Gamepad>/Dpad/Up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
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
                },
                {
                    ""name"": """",
                    ""id"": ""e6ee947b-ccf6-4377-9176-06cd97a23355"",
                    ""path"": ""<Gamepad>/Dpad/Down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a766ede-07a2-4a75-a914-6c4313bf78ca"",
                    ""path"": ""<Keyboard>/W"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96511f95-2c9f-4532-b382-8bfed1355c7f"",
                    ""path"": ""<Keyboard>/UpArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6696df8-f5ab-4af6-833a-6e5efdc09d6a"",
                    ""path"": ""<Gamepad>/dpad/Up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""tempName"",
                    ""id"": ""11ad365b-b745-4616-9667-b9254a1f1db9"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": """",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3526b931-5f4f-4744-a8b1-9cc2cb7b5c5e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c73612a-7834-42ce-acf2-a90ea1aa6897"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49cb2449-c438-4222-8509-2ec55058b82d"",
                    ""path"": ""<Keyboard>/DownArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Tic Tac Toe"",
            ""id"": ""a861c41e-e1c2-4436-951d-edc73e4c7088"",
            ""actions"": [
                {
                    ""name"": ""confirm"",
                    ""type"": ""Button"",
                    ""id"": ""e1b3c56f-7b0e-4613-b89e-f60bc1d23e0b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""left"",
                    ""type"": ""Button"",
                    ""id"": ""3bdb671e-efae-4849-bce9-ca29fe1e2c4a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""right"",
                    ""type"": ""Button"",
                    ""id"": ""94212bb1-492d-44c9-b4fd-f9ced19ed84a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""up"",
                    ""type"": ""Button"",
                    ""id"": ""0d13add8-edd6-4020-89c2-d8627397429b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""down"",
                    ""type"": ""Button"",
                    ""id"": ""4a136f0c-befd-40ea-8ef4-4abc5140fc56"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c5e9ee2d-e1fc-4294-b940-008d720951e7"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""000d505d-e727-4906-b1b1-f4d36fad29b9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fffd81a4-2fec-41bb-b28d-56f7e30819b8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4cf5aaf-3694-4c12-92f1-7e929d747f98"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa880c19-e614-4b00-9669-8b7730fa5921"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56609d2a-adb8-4ce1-928d-44f2a46fa04c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5295272-d203-4fa4-b057-4f49b26f2b77"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""373241c1-997b-45ae-94fb-c75945648720"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9810a6f-995d-40df-8233-ef6742344c04"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6971ca51-d7b6-4a06-966b-72543dbe5776"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07670ae2-ef5d-41fc-8e69-9c192a168543"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be022e6b-ab9a-42d9-800a-516218f93e7a"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd2b5212-4c0c-4f76-9a29-0a82b1169681"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f582dc40-f13f-488f-b5d7-7dc82652e8e1"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""down"",
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
        m_UI_Confirm = m_UI.FindAction("Confirm", throwIfNotFound: true);
        m_UI_Back = m_UI.FindAction("Back", throwIfNotFound: true);
        m_UI_BackDone = m_UI.FindAction("BackDone", throwIfNotFound: true);
        m_UI_NewCharacter = m_UI.FindAction("New Character", throwIfNotFound: true);
        m_UI_Navigate = m_UI.FindAction("Navigate", throwIfNotFound: true);
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
        // Rock Paper Scissors
        m_RockPaperScissors = asset.FindActionMap("Rock Paper Scissors", throwIfNotFound: true);
        m_RockPaperScissors_Rock = m_RockPaperScissors.FindAction("Rock", throwIfNotFound: true);
        m_RockPaperScissors_Paper = m_RockPaperScissors.FindAction("Paper", throwIfNotFound: true);
        m_RockPaperScissors_Scissors = m_RockPaperScissors.FindAction("Scissors", throwIfNotFound: true);
        // Pong
        m_Pong = asset.FindActionMap("Pong", throwIfNotFound: true);
        m_Pong_Up = m_Pong.FindAction("Up", throwIfNotFound: true);
        m_Pong_Down = m_Pong.FindAction("Down", throwIfNotFound: true);
        m_Pong_UpRelease = m_Pong.FindAction("UpRelease", throwIfNotFound: true);
        m_Pong_DownRelease = m_Pong.FindAction("DownRelease", throwIfNotFound: true);
        // Tic Tac Toe
        m_TicTacToe = asset.FindActionMap("Tic Tac Toe", throwIfNotFound: true);
        m_TicTacToe_confirm = m_TicTacToe.FindAction("confirm", throwIfNotFound: true);
        m_TicTacToe_left = m_TicTacToe.FindAction("left", throwIfNotFound: true);
        m_TicTacToe_right = m_TicTacToe.FindAction("right", throwIfNotFound: true);
        m_TicTacToe_up = m_TicTacToe.FindAction("up", throwIfNotFound: true);
        m_TicTacToe_down = m_TicTacToe.FindAction("down", throwIfNotFound: true);
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
    private readonly InputAction m_UI_Confirm;
    private readonly InputAction m_UI_Back;
    private readonly InputAction m_UI_BackDone;
    private readonly InputAction m_UI_NewCharacter;
    private readonly InputAction m_UI_Navigate;
    public struct UIActions
    {
        private @PrepScreen m_Wrapper;
        public UIActions(@PrepScreen wrapper) { m_Wrapper = wrapper; }
        public InputAction @Confirm => m_Wrapper.m_UI_Confirm;
        public InputAction @Back => m_Wrapper.m_UI_Back;
        public InputAction @BackDone => m_Wrapper.m_UI_BackDone;
        public InputAction @NewCharacter => m_Wrapper.m_UI_NewCharacter;
        public InputAction @Navigate => m_Wrapper.m_UI_Navigate;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
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
                @Navigate.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
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
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
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

    // Rock Paper Scissors
    private readonly InputActionMap m_RockPaperScissors;
    private IRockPaperScissorsActions m_RockPaperScissorsActionsCallbackInterface;
    private readonly InputAction m_RockPaperScissors_Rock;
    private readonly InputAction m_RockPaperScissors_Paper;
    private readonly InputAction m_RockPaperScissors_Scissors;
    public struct RockPaperScissorsActions
    {
        private @PrepScreen m_Wrapper;
        public RockPaperScissorsActions(@PrepScreen wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rock => m_Wrapper.m_RockPaperScissors_Rock;
        public InputAction @Paper => m_Wrapper.m_RockPaperScissors_Paper;
        public InputAction @Scissors => m_Wrapper.m_RockPaperScissors_Scissors;
        public InputActionMap Get() { return m_Wrapper.m_RockPaperScissors; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RockPaperScissorsActions set) { return set.Get(); }
        public void SetCallbacks(IRockPaperScissorsActions instance)
        {
            if (m_Wrapper.m_RockPaperScissorsActionsCallbackInterface != null)
            {
                @Rock.started -= m_Wrapper.m_RockPaperScissorsActionsCallbackInterface.OnRock;
                @Rock.performed -= m_Wrapper.m_RockPaperScissorsActionsCallbackInterface.OnRock;
                @Rock.canceled -= m_Wrapper.m_RockPaperScissorsActionsCallbackInterface.OnRock;
                @Paper.started -= m_Wrapper.m_RockPaperScissorsActionsCallbackInterface.OnPaper;
                @Paper.performed -= m_Wrapper.m_RockPaperScissorsActionsCallbackInterface.OnPaper;
                @Paper.canceled -= m_Wrapper.m_RockPaperScissorsActionsCallbackInterface.OnPaper;
                @Scissors.started -= m_Wrapper.m_RockPaperScissorsActionsCallbackInterface.OnScissors;
                @Scissors.performed -= m_Wrapper.m_RockPaperScissorsActionsCallbackInterface.OnScissors;
                @Scissors.canceled -= m_Wrapper.m_RockPaperScissorsActionsCallbackInterface.OnScissors;
            }
            m_Wrapper.m_RockPaperScissorsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rock.started += instance.OnRock;
                @Rock.performed += instance.OnRock;
                @Rock.canceled += instance.OnRock;
                @Paper.started += instance.OnPaper;
                @Paper.performed += instance.OnPaper;
                @Paper.canceled += instance.OnPaper;
                @Scissors.started += instance.OnScissors;
                @Scissors.performed += instance.OnScissors;
                @Scissors.canceled += instance.OnScissors;
            }
        }
    }
    public RockPaperScissorsActions @RockPaperScissors => new RockPaperScissorsActions(this);

    // Pong
    private readonly InputActionMap m_Pong;
    private IPongActions m_PongActionsCallbackInterface;
    private readonly InputAction m_Pong_Up;
    private readonly InputAction m_Pong_Down;
    private readonly InputAction m_Pong_UpRelease;
    private readonly InputAction m_Pong_DownRelease;
    public struct PongActions
    {
        private @PrepScreen m_Wrapper;
        public PongActions(@PrepScreen wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_Pong_Up;
        public InputAction @Down => m_Wrapper.m_Pong_Down;
        public InputAction @UpRelease => m_Wrapper.m_Pong_UpRelease;
        public InputAction @DownRelease => m_Wrapper.m_Pong_DownRelease;
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
                @UpRelease.started -= m_Wrapper.m_PongActionsCallbackInterface.OnUpRelease;
                @UpRelease.performed -= m_Wrapper.m_PongActionsCallbackInterface.OnUpRelease;
                @UpRelease.canceled -= m_Wrapper.m_PongActionsCallbackInterface.OnUpRelease;
                @DownRelease.started -= m_Wrapper.m_PongActionsCallbackInterface.OnDownRelease;
                @DownRelease.performed -= m_Wrapper.m_PongActionsCallbackInterface.OnDownRelease;
                @DownRelease.canceled -= m_Wrapper.m_PongActionsCallbackInterface.OnDownRelease;
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
                @UpRelease.started += instance.OnUpRelease;
                @UpRelease.performed += instance.OnUpRelease;
                @UpRelease.canceled += instance.OnUpRelease;
                @DownRelease.started += instance.OnDownRelease;
                @DownRelease.performed += instance.OnDownRelease;
                @DownRelease.canceled += instance.OnDownRelease;
            }
        }
    }
    public PongActions @Pong => new PongActions(this);

    // Tic Tac Toe
    private readonly InputActionMap m_TicTacToe;
    private ITicTacToeActions m_TicTacToeActionsCallbackInterface;
    private readonly InputAction m_TicTacToe_confirm;
    private readonly InputAction m_TicTacToe_left;
    private readonly InputAction m_TicTacToe_right;
    private readonly InputAction m_TicTacToe_up;
    private readonly InputAction m_TicTacToe_down;
    public struct TicTacToeActions
    {
        private @PrepScreen m_Wrapper;
        public TicTacToeActions(@PrepScreen wrapper) { m_Wrapper = wrapper; }
        public InputAction @confirm => m_Wrapper.m_TicTacToe_confirm;
        public InputAction @left => m_Wrapper.m_TicTacToe_left;
        public InputAction @right => m_Wrapper.m_TicTacToe_right;
        public InputAction @up => m_Wrapper.m_TicTacToe_up;
        public InputAction @down => m_Wrapper.m_TicTacToe_down;
        public InputActionMap Get() { return m_Wrapper.m_TicTacToe; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TicTacToeActions set) { return set.Get(); }
        public void SetCallbacks(ITicTacToeActions instance)
        {
            if (m_Wrapper.m_TicTacToeActionsCallbackInterface != null)
            {
                @confirm.started -= m_Wrapper.m_TicTacToeActionsCallbackInterface.OnConfirm;
                @confirm.performed -= m_Wrapper.m_TicTacToeActionsCallbackInterface.OnConfirm;
                @confirm.canceled -= m_Wrapper.m_TicTacToeActionsCallbackInterface.OnConfirm;
                @left.started -= m_Wrapper.m_TicTacToeActionsCallbackInterface.OnLeft;
                @left.performed -= m_Wrapper.m_TicTacToeActionsCallbackInterface.OnLeft;
                @left.canceled -= m_Wrapper.m_TicTacToeActionsCallbackInterface.OnLeft;
                @right.started -= m_Wrapper.m_TicTacToeActionsCallbackInterface.OnRight;
                @right.performed -= m_Wrapper.m_TicTacToeActionsCallbackInterface.OnRight;
                @right.canceled -= m_Wrapper.m_TicTacToeActionsCallbackInterface.OnRight;
                @up.started -= m_Wrapper.m_TicTacToeActionsCallbackInterface.OnUp;
                @up.performed -= m_Wrapper.m_TicTacToeActionsCallbackInterface.OnUp;
                @up.canceled -= m_Wrapper.m_TicTacToeActionsCallbackInterface.OnUp;
                @down.started -= m_Wrapper.m_TicTacToeActionsCallbackInterface.OnDown;
                @down.performed -= m_Wrapper.m_TicTacToeActionsCallbackInterface.OnDown;
                @down.canceled -= m_Wrapper.m_TicTacToeActionsCallbackInterface.OnDown;
            }
            m_Wrapper.m_TicTacToeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @confirm.started += instance.OnConfirm;
                @confirm.performed += instance.OnConfirm;
                @confirm.canceled += instance.OnConfirm;
                @left.started += instance.OnLeft;
                @left.performed += instance.OnLeft;
                @left.canceled += instance.OnLeft;
                @right.started += instance.OnRight;
                @right.performed += instance.OnRight;
                @right.canceled += instance.OnRight;
                @up.started += instance.OnUp;
                @up.performed += instance.OnUp;
                @up.canceled += instance.OnUp;
                @down.started += instance.OnDown;
                @down.performed += instance.OnDown;
                @down.canceled += instance.OnDown;
            }
        }
    }
    public TicTacToeActions @TicTacToe => new TicTacToeActions(this);
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
        void OnConfirm(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
        void OnBackDone(InputAction.CallbackContext context);
        void OnNewCharacter(InputAction.CallbackContext context);
        void OnNavigate(InputAction.CallbackContext context);
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
    public interface IRockPaperScissorsActions
    {
        void OnRock(InputAction.CallbackContext context);
        void OnPaper(InputAction.CallbackContext context);
        void OnScissors(InputAction.CallbackContext context);
    }
    public interface IPongActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnUpRelease(InputAction.CallbackContext context);
        void OnDownRelease(InputAction.CallbackContext context);
    }
    public interface ITicTacToeActions
    {
        void OnConfirm(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
    }
}
