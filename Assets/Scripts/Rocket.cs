using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using DG.Tweening.Core.Easing;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Rocket : MonoBehaviour
{
    [SerializeField] private EaseCurve _curve;
    [SerializeField] private Transform _transform;
    [SerializeField] private Button _button;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private float _appearanceTime = 1f;
    
    
    private void Start()
    {
        _button.onClick.AddListener(PlayerVFX);
    }

    private void PlayerVFX()
    {
        _spriteRenderer.DOFade(1, _appearanceTime);
       
    }
    
    
}
