using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(RawImage))]
public class ParalaxBackground : MonoBehaviour
{
    [SerializeField] private float _paralaxSpeed;
    
    private RawImage _image;
    private float _imagePositionX;
    private void Start()
    {
        _image = GetComponent<RawImage>();
        _imagePositionX = _image.uvRect.x;
    }
    
    private void Update()
    {
        _imagePositionX += _paralaxSpeed * Time.deltaTime;
        _image.uvRect = new Rect(_imagePositionX, 0,_image.uvRect.width,_image.uvRect.height);
    }
}
