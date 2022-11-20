using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;

public class ArmSwingingMoveProvider : DeviceBasedContinuousMoveProvider
{
        

        protected override Vector2 ReadInput()
        {
            if (controllers.Count == 0)
                return Vector2.zero;

            // Accumulate all the controller inputs
            var input = Vector2.zero;
            var feature = CommonUsages.deviceVelocity;
            var featureActive = CommonUsages.triggerButton;

            for (var i = 0; i < controllers.Count; ++i)
            {
                var controller = controllers[i] as XRController;
                if (controller != null &&
                    controller.enableInputActions &&
                    controller.inputDevice.TryGetFeatureValue(feature, out var controllerVelocity))
                {
                    controller.inputDevice.TryGetFeatureValue(featureActive, out var triggerActive);
                    if (triggerActive)
                    {
                        Vector2 controllerInput = new Vector2(controllerVelocity.x, controllerVelocity.z)
                        input -= GetDeadzoneAdjustedValue(controllerInput);
                    }
                    
                }
            }

            return input;
        }
}

