using System.Collections;
using TMPro;
using UnityEngine;
using TimeRace.Resources;
using UnityEngine.UI;

namespace TimeRace.UI
{
    public class FinalDialogController : BaseDialogController
    {
        void Awake()
        {
            ResourceBase = Resource.Language["pt-BR"].Final;
        }
    }
}