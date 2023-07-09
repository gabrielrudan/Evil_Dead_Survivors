using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{

    public Image _heathBar;
    public GameObject _player;

    private float _maxhealth;
    private float _health;
    private float _lastHealth;
    private float _currentHealth;
    private float _damage;
    private float _healing;
    private float _healingAmount = 100f;

    public TextMeshProUGUI txtVida;

    // Start is called before the first frame update
    void Start()
    {
        _maxhealth = _player.GetComponent<Vida>().GetVidaMaxima();
        _health = _player.GetComponent<Vida>().GetVida();
        _currentHealth = _health;
        _lastHealth = _health;
        _healing = _player.GetComponent<Cura>().GetCura();

        txtVida.text = _health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        _health = _player.GetComponent<Vida>().GetVida();
        _currentHealth = _health;

        if (_currentHealth < _lastHealth)
        {
            OnDamage(_health);
        }

        _currentHealth = _lastHealth;

        if (Input.GetKeyDown(KeyCode.JoystickButton3))
        {
            print("Curando");
            OnHealing(_healing);
        }
    }

    private void OnDamage(float current)
    {
        txtVida.text = current.ToString();

    }

    private void OnHealing(float heal)
    {
        if(_health < _maxhealth)
        {
            float _life = _health + heal;
            _player.GetComponent<Vida>().SetVida((int)_life);
        }
        else
        {
            print("Full life");
        }
    }


}
