using UnityEngine;
using UnityEngine.Events;
using Zinnia.Action;
using Valve.VR;

public class VRTK_SteamVR_Adapter : BooleanAction
{
    // TODO: Require script Steam VR Behavior Boolean, get reference
    #region SteamVR
    /// <summary>
    /// The <see cref="SteamVR_Behaviour_Boolean"/> from SteamVR
    /// </summary>
    public SteamVR_Behaviour_Boolean steamvr_boolean_action;
    #endregion

    // private UnityEvent internalEvent = new UnityEvent();

    void Start() {
        if (steamvr_boolean_action != null) {
        //     // steamvr_boolean_action.onChange.AddListener((a,b,c) => internalEvent.Invoke(c));
        //     ValueChanged = internalEvent;
            steamvr_boolean_action.onChangeEvent += ((a,b,c) => changeState(c));
            // ValueChanged.AddListener(uab => printStatus(uab));
            

        //     // Activated = internalEvent;
        //     // ActivationStateChanged = internalEvent;
        //     // ValueChanged = internalEvent;
        //     // ValueChanged.AddListener(printStatus);
        //     // ActivationStateChanged.AddListener(printStatus);

        //     // ValueChanged.AddListener(printStatus);

        //     // AddSource(steamvr_boolean_action);
        }

        // Activated.AddListener(uab => print(uab));
        // ActivationStateChanged.AddListener(uab => print(uab));
    }

    public void changeState(bool state) {
        Receive(state);
        print( "the state is: " + state);
    }


    // protected virtual void Update()
    // {
    //     Receive(steamvr_boolean_action.booleanAction.state);
    // }
}
