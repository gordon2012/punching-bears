using UnityEngine;
using System.Collections;
using SocketIO;

public class Network : MonoBehaviour {

    public GameObject playerPrefab;

    static SocketIOComponent socket;

	// Use this for initialization
	void Start () {
        socket = GetComponent<SocketIOComponent>();
        socket.On("open", OnConnected);
        socket.On("spawn", OnSpawned);
	}

	
	// Update is called once per frame
	void Update () {
	
	}

    void OnConnected(SocketIOEvent e)
    {
        Debug.Log("connected");
        socket.Emit("move");
    }

    private void OnSpawned(SocketIOEvent e)
    {
        Debug.Log("spawned");
        Instantiate(playerPrefab);
    }
}
