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
        // The global application object
        Platform.Application theApplication = new Platform.Application();
        // BREP tool to create geometries.
        BrepTools shapeMaker = new BrepTools();
        // Default 3d View
        Platform.View3d theView;


        public FormMain()
        {
            InitializeComponent();
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.OnMouseWheel);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Initialize the Application.
            theApplication.Initialize();
            Size size = panel3d.Size;

            // Create the 3d View
            theView = theApplication.CreateView(panel3d.Handle.ToInt32(), size.Width, size.Height);

            theView.RequestDraw();

            this.timerDraw.Enabled = true;
        }
        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            Size size = panel3d.Size;
            if(theView != null)
                theView.OnSize(size.Width, size.Height);
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

        private SceneNode ShowTopoShape(TopoShape topoShape, int id)
        {
            // Add the TopoShape to Scene.
            TopoShapeConvert convertor = new TopoShapeConvert();
            SceneNode faceNode = convertor.ToFaceNode(topoShape, 0.5f);
            faceNode.SetId(id);
            theView.GetSceneManager().AddNode(faceNode);
            return faceNode;
        }

        private void ClearScene()
        {
            theView.GetSceneManager().ClearNodes();
        }

        private void sphereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopoShape sphere = shapeMaker.MakeSphere(new Vector3(0, 0, 0), 40);
            ShowTopoShape(sphere, 100);
        }

        private void boxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopoShape box = shapeMaker.MakeBox(new Vector3(40, -20, 0), new Vector3(0, 0, 1), new Vector3(30, 40, 60));
             
            SceneNode sceneNode = ShowTopoShape(box, 101);

            FaceStyle style = new FaceStyle();
            style.SetColor(new ColorValue(0.5f, 0.3f, 0, 1));
            sceneNode.SetFaceStyle(style);
        }

        private void cylinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopoShape cylinder = shapeMaker.MakeCylinder(new Vector3(80, 0, 0), new Vector3(0, 0, 1), 20, 100, 315);
            SceneNode sceneNode = ShowTopoShape(cylinder, 102);
            FaceStyle style = new FaceStyle();
            style.SetColor(new ColorValue(0.1f, 0.3f, 0.8f, 1));
            sceneNode.SetFaceStyle(style);
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

            // Check find....
            SceneNode findNode = theView.GetSceneManager().FindNode(104);
            theView.GetSceneManager().SelectNode(findNode);
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

        private void sTLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "STL (*.stl)|*.stl|All Files(*.*)|*.*";

            if (DialogResult.OK == dlg.ShowDialog())
            {
                TopoShape shape =  shapeMaker.LoadFile(dlg.FileName);
                if( shape != null)
                    ShowTopoShape(shape, 1000);

            }
        }

        private void Pane3d_MouseDown(object sender, MouseEventArgs e)
        {
            ViewUtility.OnMouseDownEvent(theView, e);
        }

        private void Pane3d_MouseMove(object sender, MouseEventArgs e)
        {
            ViewUtility.OnMouseMoveEvent(theView, e);
        }

        private void Pane3d_MouseUp(object sender, MouseEventArgs e)
        {
            ViewUtility.OnMouseUpEvent(theView, e);
        }
        private void OnMouseWheel(object sender, MouseEventArgs e)
        {
            ViewUtility.OnMouseWheelEvent(theView, e);
        }


    }
}
