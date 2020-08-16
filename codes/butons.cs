using System.Collections;
using System.Collections.Generic;
// Touchable component

using UnityEngine;
using UnityEngine.UI;


public class ImagelessButton : MonoBehaviour
{
    private RectTransform _transform;
    void Awake()
    {
        _transform = transform as RectTransform;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (RectTransformUtility.RectangleContainsScreenPoint(_transform, Input.mousePosition))
            {
            }
        }
    }
}
