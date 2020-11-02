using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDown : MonoBehaviour
{
    public void SelectedIndex()
    {
        MainMenuButton.SceneNo = GetComponent<Dropdown>().value;
    }
}
