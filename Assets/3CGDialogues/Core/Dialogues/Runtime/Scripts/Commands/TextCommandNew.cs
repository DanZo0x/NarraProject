using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TCG.Core.Dialogues
{
    public class TextCommandNew : TextCommand
    {
        public Material shader;

        public override void OnEnter()
        {
            _ApplyTextureToMesh(shader);
        }
    }
}
