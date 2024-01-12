using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ShakeObjects : MonoBehaviour
{
    public List<Transform> objectsReactingToBasses, objectsReactingToNB, objectsReactingToMiddles, objectsReactingToHighs;

    [SerializeField] float t = 0.1f;
    void FixedUpdate()
    {
        makeObjectsShakeScale();
    }
    void makeObjectsShakeScale()
    {
        foreach (Transform obj in objectsReactingToBasses){
            obj.localScale = Vector3.Lerp(obj.localScale, new Vector3(1, AudioManager.instance.getFrequenciesinDiapason(0, 7, 10), 1), t);
    }
        foreach (Transform obj in objectsReactingToNB){
            obj.localScale = Vector3.Lerp(obj.localScale, new Vector3(1, AudioManager.instance.getFrequenciesinDiapason(7, 15, 100), 1), t);
        }
        foreach (Transform obj in objectsReactingToMiddles){
            obj.localScale = Vector3.Lerp(obj.localScale, new Vector3(1, AudioManager.instance.getFrequenciesinDiapason(15, 30, 200), 1), t); 
        }
        foreach (Transform obj in objectsReactingToHighs){
            obj.localScale = Vector3.Lerp(obj.localScale, new Vector3(1, AudioManager.instance.getFrequenciesinDiapason(30, 32, 1000), 1), t);
        }
    }
}