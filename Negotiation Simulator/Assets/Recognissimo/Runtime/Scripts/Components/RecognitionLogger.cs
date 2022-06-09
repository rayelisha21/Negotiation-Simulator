using UnityEngine;
using Recognissimo.Core; // PartialResult, Result
using TMPro;

public class RecognitionLogger : MonoBehaviour
    {
        public TMP_Text wordtext;

        public void OnPartialResult(PartialResult partialResult)
            {
                //Debug.Log($"<color=yellow>{partialResult.partial}</color>");
                wordtext.text = partialResult.partial;
            }

        public void OnResult(Result result)
            {
                //Debug.Log($"<color=green>{result.text}</color>");
                wordtext.text = result.text;
            }
    }
