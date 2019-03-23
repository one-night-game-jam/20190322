using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace UIs
{
    public class LinkButton : MonoBehaviour
    {
        [SerializeField]
        Button button;

        [SerializeField]
        string url;

        void Start()
        {
            button.OnClickAsObservable()
                .Subscribe(_ => Application.OpenURL(url))
                .AddTo(this);
        }
    }
}