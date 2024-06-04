﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssetStudio
{
    public sealed class Animation : Behaviour
    {
        public List<PPtr<AnimationClip>> m_Animations;

        public Animation(ObjectReader reader) : base(reader)
        {
            var m_Animation = new PPtr<AnimationClip>(reader);
            int numAnimations = reader.ReadInt32();
            m_Animations = new List<PPtr<AnimationClip>>();
            for (int i = 0; i < numAnimations; i++)
            {
                m_Animations.Add(new PPtr<AnimationClip>(reader));
            }
        }
    }
}
