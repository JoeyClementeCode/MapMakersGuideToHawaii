using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace team2
{
    public class DropdownHolder : MonoBehaviour
    {
        public TextMeshProUGUI headerBox;
        public TextMeshProUGUI bodyBox;
        

        public void SetText(string header, string body)
        {
            headerBox.text = header;
            bodyBox.text = body;
        }
    }
}
