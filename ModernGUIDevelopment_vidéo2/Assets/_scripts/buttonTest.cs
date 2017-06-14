using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonTest : MonoBehaviour {

    

    public void doSomeThing(Slider slider)
    {
        Debug.Log(slider.value.ToString());
    }
}
