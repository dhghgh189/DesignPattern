using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Presenter : MonoBehaviour
{
    [SerializeField] private Model model;
    [SerializeField] private Slider hpBar;
    [SerializeField] private TMP_Text txtHp; 

    private void Start()
    {
        if (model != null)
        {
            model.OnChangedHp += UpdateHpBar;
        }
        UpdateHpBar();
    }

    public void Heal(int amount)
    {
        if (model == null)
            return;

        model.CurrentHp += amount;
    }

    public void TakeDamage(int amount)
    {
        if (model == null)
            return;

        model.CurrentHp -= amount;
    }

    public void UpdateHpBar()
    {
        if (model == null)
            return;

        if (hpBar == null || model.MaxHp == 0)
            return;

        hpBar.value = model.CurrentHp / model.MaxHp;
        txtHp.text = $"{model.CurrentHp}";
    }

    private void OnDestroy()
    {
        if (model != null)
        {
            model.OnChangedHp -= UpdateHpBar;
        }
    }
}
