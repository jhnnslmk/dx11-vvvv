﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using VVVV.PluginInterfaces.V2;
using VVVV.PluginInterfaces.V1;

using SlimDX.Direct3D11;
using SlimDX;

using FeralTic.DX11.Resources;
using FeralTic.DX11;
using FeralTic.DX11.Geometry;

namespace VVVV.DX11.Nodes
{
    [PluginInfo(Name = "Isocahedron", Category = "DX11.Geometry", Version = "", Author = "vux")]
    public class DX11IsocahedronNode : DX11BasePrimitiveNode
    {
        /*[Input("Size",DefaultValues= new double[] { 1,1,1})]
        IDiffSpread<Vector3> FSize;*/

        protected override DX11IndexedGeometry GetGeom(DX11RenderContext context, int slice)
        {
            Isocahedron iso = new Isocahedron();
            iso.Size = new Vector3(1, 1, 1);

            return context.Primitives.Isocahedron(iso);
        }

        protected override bool Invalidate()
        {
            return false;// this.FSize.IsChanged;
        }
    }
}
