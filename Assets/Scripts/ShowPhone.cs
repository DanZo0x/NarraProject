using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPhone : MonoBehaviour
{
    bool _isOpenning = false;
    bool _isClosing = false;
    Vector2 _currentScale;
    RectTransform _rect;
    float _timer = 0;
    private void Awake()
    {
        _rect = GetComponent<RectTransform>();
    }

    private void Update()
    {
        if (_isOpenning)
        {
            _rect.localScale = Vector2.Lerp(_rect.localScale, _currentScale * 2, _timer / 3);
            _timer += Time.deltaTime;
        }
        if (_isClosing)
        {
            _rect.localScale = Vector2.Lerp(_rect.localScale, _currentScale / 2, _timer / 3);
            _timer += Time.deltaTime;
        }
        if (_timer > 3)
        {
            _isClosing = false;
            _isOpenning = false;
            _timer = 0;
        }
    }
    public void Open()
    {
        _currentScale = _rect.localScale;
        _isOpenning = true;
        _isClosing = false;
        _timer = 0;
    }
    public void Close()
    {
        _currentScale = _rect.localScale;
        _isOpenning = false;
        _isClosing = true;
        _timer = 0;
    }
}
