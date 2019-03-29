using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroySingleton<T> : MonoBehaviour where T : DontDestroySingleton<T> {
    static public T Instance { get; private set; }

    private void Awake () {
        if (Instance == null) {
            Instance = (T) this;
            DontDestroyOnLoad (gameObject);
            OnAwake ();
        } else {
            Destroy (gameObject);
        }
    }
    private void Start () {
        if (Instance == (T) this) {
            OnStart ();
        }
    }
    
    /// <summary>
    /// Dont Use Awake()
    /// </summary>
    virtual protected void OnAwake () {
        
    }
    /// <summary>
    /// Dont Use Start()
    /// </summary>
    virtual protected void OnStart () {

    }
}
