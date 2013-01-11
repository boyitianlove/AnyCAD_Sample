using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AnyCAD.Platform;

namespace AnyCAD.Basic
{
    public partial class FormMain : Form
    {
        Platform.Application theApplication = new Platform.Application();
        Platform.View theView;
        BrepTools shapeMaker = new BrepTools();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            theApplication.LoadPlugins();
            Size size = panel3d.Size;
            theView = theApplication.Create3dView("OSG", panel3d.Handle.ToInt32(), size.Width, size.Height);
            theView.RequestDraw();

            this.timerDraw.Enabled = true;
        }

        private void panel3d_Paint(object sender, PaintEventArgs e)
        {
            if (theView == null)
                return;

            theView.Redraw();
        }

        private void timerDraw_Tick(object sender, EventArgs e)
        {
            theView.RequestDraw();
            theView.Redraw();
        }

        private void ShowTopoShape(TopoShape topoShape, int id)
        {
            PrsNodeManager nodeManager = theView.GetNodeManager();
            Entity entity = new Entity();
            entity.SetTopoShape(topoShape);
            PrsNode node = nodeManager.CreateSceneNode(entity, id, false);
            if (node != null)
            {
                nodeManager.AddSceneNode(node);
            }
        }

        private void ClearScene()
        {
            PrsNodeManager nodeManager = theView.GetNodeManager();
            nodeManager.RemoveAllSceneNode();
        }

        private void sphereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopoShape sphere = shapeMaker.MakeSphere(new Vector3(0, 0, 0), 40);
            ShowTopoShape(sphere, 100);
        }

        private void boxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopoShape box = shapeMaker.MakeBox(new Vector3(40, -20, 0), new Vector3(0, 0, 1), new Vector3(30, 40, 60));
            ShowTopoShape(box, 101);
        }

        private void cylinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopoShape cylinder = shapeMaker.MakeCylinder(new Vector3(80, 0, 0), new Vector3(0, 0, 1), 20, 100, 315);
            ShowTopoShape(cylinder, 102);
        }

        private void coneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopoShape cylinder = shapeMaker.MakeCone(new Vector3(120, 0, 0), new Vector3(0, 0, 1), 20, 100, 40, 315);
            ShowTopoShape(cylinder, 103);
        }

        private void extrudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int size = 20;
            // Create the outline edge
            TopoShape arc = shapeMaker.MakeArc3Pts(new Vector3(-size, 0, 0), new Vector3(size, 0, 0), new Vector3(0, size, 0));
            TopoShape line1 = shapeMaker.MakeLine(new Vector3(-size, -size, 0), new Vector3(-size, 0, 0));
            TopoShape line2 = shapeMaker.MakeLine(new Vector3(size, -size, 0), new Vector3(size, 0, 0));
            TopoShape line3 = shapeMaker.MakeLine(new Vector3(-size, -size, 0), new Vector3(size, -size, 0));

            TopoShapeGroup shapeGroup = new TopoShapeGroup();
            shapeGroup.Add(line1);
            shapeGroup.Add(arc);
            shapeGroup.Add(line2);
            shapeGroup.Add(line3);

            TopoShape wire = shapeMaker.MakeWire(shapeGroup);
            TopoShape face = shapeMaker.MakeFace(wire);

            // Extrude
            TopoShape extrude = shapeMaker.Extrude(face, 100, new Vector3(0, 0, 1));
            ShowTopoShape(extrude, 104);
        }

        private void revoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int size = 10;
            // Create the outline edge
            TopoShape arc = shapeMaker.MakeArc3Pts(new Vector3(-size, 0, 0), new Vector3(size, 0, 0), new Vector3(0, size, 0));
            TopoShape line1 = shapeMaker.MakeLine(new Vector3(-size, -size, 0), new Vector3(-size, 0, 0));
            TopoShape line2 = shapeMaker.MakeLine(new Vector3(size, -size, 0), new Vector3(size, 0, 0));
            TopoShape line3 = shapeMaker.MakeLine(new Vector3(-size, -size, 0), new Vector3(size, -size, 0));

            TopoShapeGroup shapeGroup = new TopoShapeGroup();
            shapeGroup.Add(line1);
            shapeGroup.Add(arc);
            shapeGroup.Add(line2);
            shapeGroup.Add(line3);

            TopoShape wire = shapeMaker.MakeWire(shapeGroup);

            TopoShape revole = shapeMaker.Revol(wire, new Vector3(size * 3, 0, 0), new Vector3(0, 1, 0), 145);

            ShowTopoShape(revole, 105);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearScene();
        }
    }
}
