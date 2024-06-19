using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSwitch : MonoBehaviour
{

    private List<GameObject> foods = new List<GameObject>();
    private int index;

    void Start()
    {
        foreach(Transform obj in transform) 
            foods.Add(obj.gameObject);

        SetActiveFruit(0);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.RightArrow))
            NextFood();
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            PreviousFood();
    }

    private void SetActiveFruit(int i)
    {
        foods[index].SetActive(false);

        if (i >= foods.Count)
            index = 0;
        else if (i <= 0)
            index = foods.Count-1;
        else
            index = i;

        foods[index].SetActive(true);
    }

    private void NextFood()
    {
        SetActiveFruit(index + 1);
    }

    private void PreviousFood()
    {
        SetActiveFruit(index - 1);
    }
}
