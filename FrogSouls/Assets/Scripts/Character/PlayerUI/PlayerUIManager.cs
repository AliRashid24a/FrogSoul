using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

namespace Ali
{
    public class PlayerUIManager : MonoBehaviour
    {
        public static PlayerUIManager instance;
        [Header("NETWORK JOIN")]
        [SerializeField] bool startGameAsClient;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Update()
        {
            if (startGameAsClient)
            {
                startGameAsClient = false;
                // First shutdown network as we started as a host in the title screen
                NetworkManager.Singleton.Shutdown();
                // Then restart as a client
                NetworkManager.Singleton.StartClient();
            }
        }
    }
}

