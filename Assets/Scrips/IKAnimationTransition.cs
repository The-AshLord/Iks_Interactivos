using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.UI;

public class IKAnimationTransition : MonoBehaviour
{
    [SerializeField] TwoBoneIKConstraint izquierda;
    [SerializeField] TwoBoneIKConstraint derecha;
    [SerializeField] Slider Slider;

    // Start is called before the first frame update
    void Start()
    {
        derecha.data.targetPositionWeight = Slider.value;
        izquierda.data.targetPositionWeight = Slider.value;
    }


    public void changeLegs()
    {
        izquierda.data.targetPositionWeight = Slider.value;
        derecha.data.targetPositionWeight = Slider.value;
    }
}
