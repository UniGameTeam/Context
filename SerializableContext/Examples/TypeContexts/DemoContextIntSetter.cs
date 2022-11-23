﻿using UnityEngine;

namespace UniModules.UniGame.SerializableContext.Examples.TypeContexts
{
    using Runtime;
    using global::UniGame.Context.Runtime;
    using UniRx;
    using UnityEngine.UI;

    public class DemoContextIntSetter : MonoBehaviour
    {

        public Button button;
        
        public IntContextValue intValue;
        
        // Start is called before the first frame update
        private void Start()
        {
            button.onClick.
                AsObservable().
                Subscribe(x => intValue.SetValue(intValue.Value+1)).
                AddTo(this);
        }

    }
}
