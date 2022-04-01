using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalHealthTextBehaviour : MonoBehaviour
{
    [SerializeField]
    public Text _healthText;
    [SerializeField]
    public GoalBehaviour _goal;

    // Update is called once per frame
    void Update()
    {
        float health = _goal.Health;

        if (health < 0) health = 0;

        _healthText.text = "Health: " + health;
    }
}
