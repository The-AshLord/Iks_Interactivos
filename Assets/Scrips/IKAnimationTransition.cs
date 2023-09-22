using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.UI;

public class IKAnimationTransition : MonoBehaviour
{

    public Rig weightRigLeft;
    public Rig weightRigRight;

    public Slider weightSlider;


    void Update()
    {
        weightRigLeft.weight = weightSlider.value;
        weightRigRight.weight = weightSlider.value;
    }
}
