using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ShakeObjects : MonoBehaviour
{
    public List<Transform> objectsReactingToBasses, objectsReactingToNB, objectsReactingToMiddles, objectsReactingToHighs, check;
    private float _bassVar;
    private float _NBVar;
    private float _MiddlesVar;
    private float _HighVar;

    [SerializeField] float t = 0.1f;
    void FixedUpdate()
    {
        makeObjectsShakeScale();
    }
    void makeObjectsShakeScale()
    {
        foreach (Transform obj in objectsReactingToBasses){
            _bassVar = AudioManager.instance.getFrequenciesinDiapason(0, 7, 10) + Random.Range(90,100);
            print("Bass Value:"+_bassVar);
            obj.localScale = Vector3.Lerp(obj.localScale, new Vector3(_bassVar, _bassVar, _bassVar), t);
    }
        foreach (Transform obj in objectsReactingToNB){
            _NBVar = AudioManager.instance.getFrequenciesinDiapason(7, 15, 100) + Random.Range(90, 100);
            print("NB Value:"+_NBVar);
            obj.localScale = Vector3.Lerp(obj.localScale, new Vector3(_NBVar, _NBVar, _NBVar), t);
        }
        foreach (Transform obj in objectsReactingToMiddles){
            _MiddlesVar = AudioManager.instance.getFrequenciesinDiapason(15, 30, 200) + Random.Range(90, 100);
            print("Middle Value:"+_MiddlesVar);
            obj.localScale = Vector3.Lerp(obj.localScale, new Vector3(_MiddlesVar, _MiddlesVar, _MiddlesVar), t); 
        }
        foreach (Transform obj in objectsReactingToHighs){
            _HighVar = AudioManager.instance.getFrequenciesinDiapason(30, 32, 1000) + Random.Range(90, 100);
            print("High Value:"+_HighVar);
            obj.localScale = Vector3.Lerp(obj.localScale, new Vector3(_HighVar, _HighVar, _HighVar), t);
        }
        foreach (Transform obj in check)
        {
            obj.localScale = Vector3.Lerp(obj.localScale, new Vector3(AudioManager.instance.getFrequenciesinDiapason(0, 7, 10), AudioManager.instance.getFrequenciesinDiapason(0, 7, 10), AudioManager.instance.getFrequenciesinDiapason(0, 7, 10)), t);
        }
    }
}