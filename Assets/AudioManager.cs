using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG. Tweening;
using System.Linq;
public class AudioManager : MonoBehaviour
{
public static AudioManager instance;
public float[] spectrumWidth;
AudioSource audioSource;
    void Awake()
    {
        spectrumWidth = new float[64];
        audioSource = GetComponent<AudioSource>();
        instance = this;
    }
    void FixedUpdate()
    {
        audioSource.GetSpectrumData(spectrumWidth, 0, FFTWindow.Blackman);
    }
    public float getFrequenciesinDiapason(int start, int end, int mult)
    {
        return spectrumWidth.ToList().GetRange(start, end).Average() * mult;
    }
}