using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Material _material;

    private readonly string _colorName = "_GlowColor";
    private Color32 _defaultColor;


    private void Start()
    {
        _material = GetComponent<SpriteRenderer>().material;

        Color32 color = new Color32(255, 255, 0, 0);

        _material.SetColor(_colorName, color);
        _defaultColor = color;

        
    }

    private void Update()
    {
        Color32 newColor = new Color32(0, 255, 255, 0);
        Color32 lerpedColor;

        lerpedColor = Color32.Lerp(_defaultColor, newColor, Mathf.PingPong(Time.time, 1));

        _material.SetColor(_colorName, lerpedColor);
       
    }
    

}