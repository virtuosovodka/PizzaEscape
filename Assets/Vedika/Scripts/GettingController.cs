using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using TMPro;

/*
 * https://docs.unity3d.com/Manual/xr_input.html
 * https://sneakydaggergames.medium.com/vr-in-unity-managing-controller-input-and-hand-presence-part-1-controller-set-up-792682dd024d
 *
 * have to test in real vr but will probably work
 */
public class GettingController : MonoBehaviour
{
    // Start is called before the first frame update
    private InputDevice targetDevice;
    public TextMeshProUGUI text;
        
    void Start()
    {
        text.text = "hello";
        List<InputDevice> devices = new List<InputDevice>();

        InputDeviceCharacteristics rightControllerCharacteristics =
            InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);
        InputDevices.GetDevices(devices);

        foreach (var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }
    }

    // Update is called once per frame
    void Update()
    {
        targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue);
        if (primaryButtonValue == true)
        {
            text.text = "pressing primary button";
        }

        targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue);
        if (triggerValue > .1f)
        {
            text.text = "trigger pressed: " + triggerValue;
        }

        targetDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool secondaryButtonValue);
        if (secondaryButtonValue == true)
        {
            text.text = "pressing primary button";
        }
    }
}