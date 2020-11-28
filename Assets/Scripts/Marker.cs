using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Countries;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Animator))]

public class Marker : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private CountryType _countryType;
    [SerializeField] private Menu _menu;

    private Country _country;
    
    private float t0 = 0f;
    private bool longClick = false;

    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    
    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
       _country = CountryData.GetCountryByEnum(_countryType);
    }
    
    private void OnMouseUp()
    {
        if ((Time.time - t0) > 0.4f)
        {
            Debug.Log("Долгое нажатие");
            GameEvents.current.MarkerLongCLick();
        }
    }
    public void OnMouseDown()
    {
        t0 = Time.time;
        _spriteRenderer.enabled = false;
        _animator.SetBool("Clicked", true);
        _menu.SetCountry(_country);
        
        foreach (var tmpText in _prefab.GetComponentsInChildren<TMP_Text>().ToList())
        {
            if (tmpText.name == "TextOfCountry")
            {
                tmpText.text = _country.Name;
            }
        }
        Instantiate(_prefab, gameObject.transform.parent);
    }
    private void OnMouseEnter()
    {
        _animator.Play("OnMarkerEnter");
    }
    
      
}
public enum CountryType
{
    Russia,
    USA,
    China,
}
