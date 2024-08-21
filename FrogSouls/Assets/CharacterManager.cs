using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ali
{
    public class CharacterManager : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
