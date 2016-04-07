using UnityEngine;
using System.Collections;
using SocketIO;

public class Network : MonoBehaviour {

    static SocketIOComponent socket;

	// Use this for initialization
	void Start () {
        socket = GetComponent<SocketIOComponent>();
        socket.On("open", OnConnected);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnConnected(SocketIOEvent e)
    {
        Debug.Log("connected");
        socket.Emit("move");
    }
}
