using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobGraph : MonoBehaviour
{
    public RectTransform standardGraph;
    public RectTransform resizableGraph;

    private float width;
    private void Start()
    {
        width = standardGraph.rect.width;
        //width = standardGraph.sizeDelta.x;
    }

    private void Update()
    {
        UpdateGraph();
    }

    private void UpdateGraph()
    {
        var rate = ESSManager.instance.curHawkCount / (float)(ESSManager.instance.curHawkCount + ESSManager.instance.curDoveCount);

        resizableGraph.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, rate * width);

        //var tempSize = resizableGraph.sizeDelta;
        //tempSize.x = width * rate;
        //resizableGraph.sizeDelta = tempSize;

    }
}
