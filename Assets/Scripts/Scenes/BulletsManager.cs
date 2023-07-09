using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BulletsManager : MonoBehaviour
{

    public GameObject _player;

    private float _maxhealth;
    private float _health;
    private float _lastHealth;
    private float _currentHealth;
    private float _damage;

    public TextMeshProUGUI txtVida;

    void Start()
    {
        
    }

    void Update()
    {

        
        WeaponManager weaponManager = _player.GetComponent<WeaponManager>();

        if(weaponManager.equippedWeapon != null)
        {
            _maxhealth = weaponManager.currentWeapon.GetComponent<Balas>().GetQuantidadeMaximaDeBalas();
            _health = weaponManager.currentWeapon.GetComponent<Balas>().GetQuantidadeBalas();
            _currentHealth = _health;
            _lastHealth = _health;

            txtVida.text = _health.ToString();
        }

        if(weaponManager.equippedWeapon != null)
        {
            _health = weaponManager.currentWeapon.GetComponent<Balas>().GetQuantidadeBalas();
            _currentHealth = _health;

            if (_currentHealth < _lastHealth)
            {
                OnDamage(_health);
            }

            _currentHealth = _lastHealth;
        }
    }

    private void OnDamage(float current)
    {
        txtVida.text = current.ToString();
    }
}
