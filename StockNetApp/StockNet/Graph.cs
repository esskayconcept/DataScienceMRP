using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace StockNet
{
    public class Node
    {
        public int Index;
        public string Text;

        public string Ticker
        {
            get
            {
                return Text.Split(':')[0];
            }
        }

        public string Exchange
        {
            get
            {
                return Text.Split(':')[1];
            }
        }

        public Graph ParentGraph;

        public List<int> ConnectionIndices;
        
        public Node()
        {
            ConnectionIndices = new List<int>();
        }
        
        public void AddConnection(int ConnectionNodeIndex)
        {
            if (!ConnectionIndices.Contains(ConnectionNodeIndex))
            {
                ConnectionIndices.Add(ConnectionNodeIndex);
            }
        }

        public int Degree
        {
            get
            {
                return ConnectionIndices.Count;
            }
        }

        private List<int> GetShortestPath(ArrayList TraversedPaths, int TargetNodeIndex, List<int> TraversedPoints)
        {
            ArrayList paths = new ArrayList();

            foreach (object o in TraversedPaths)
            {
                List<int> NodePaths = (List<int>)o;

                int LastNode = NodePaths[NodePaths.Count - 1];

                if (TraversedPoints.Contains(TargetNodeIndex)) return NodePaths;

                foreach (int n in ParentGraph.Nodes[LastNode].ConnectionIndices)
                {
                    if (!TraversedPoints.Contains(n))
                    {
                        List<int> NewPath = new List<int>();

                        foreach (int i in NodePaths)
                        {
                            NewPath.Add(i);
                        }

                        NewPath.Add(n);

                        paths.Add(NewPath);

                        TraversedPoints.Add(n);

                        if (n == TargetNodeIndex) return NewPath;
                    }
                }
            }

            if (paths.Count == 0) return new List<int>();

            return GetShortestPath(paths, TargetNodeIndex, TraversedPoints);
        }

        public List<int> GetShortestPath(Node TargetNode)
        {
            ArrayList StartPaths = new ArrayList();

            List<int> Nodes = new List<int>();
            Nodes.Add(Index);

            if (Degree == 0) return Nodes;
            if (TargetNode.Degree == 0) return Nodes;

            StartPaths.Add(Nodes);

            List<int> Traversed = new List<int>();
            Traversed.Add(Index);

            List<int> NodePath = GetShortestPath(StartPaths, TargetNode.Index, Traversed);

            if (NodePath[NodePath.Count - 1] != TargetNode.Index)
            {
                return Nodes;
            }

            return NodePath;
        }

        private double _Eccentricity;

        private List<List<int>> _AllPaths;

        public List<List<int>> AllPaths
        {
            get
            { 
                return _AllPaths;
            }
        }

        private double _Closeness;

        public void Recalculate()
        {
            _AllPaths = new List<List<int>>();

            if (Degree > 0)
            {
                foreach(Node n in ParentGraph.Nodes)
                {
                    if (n.Index != Index && n.Degree>0)
                    {
                        List<int> p = GetShortestPath(n);

                        if (p[p.Count - 1] == n.Index)
                        {
                            _AllPaths.Add(p);
                        }
                    }
                }
            }

             _Eccentricity = 0;
            _Closeness = 0;

            foreach (List<int> il in _AllPaths)
            {
                int c = il.Count;

                _Eccentricity = Math.Max(_Eccentricity, c);

                _Closeness += 1.0 / c;
            }

            if (_Eccentricity == 0) _Eccentricity = double.PositiveInfinity;
        }

        public double Eccentricity
        {
            get
            {
                return _Eccentricity;
            }
        }
        
        public double Closeness
        {
            get
            {
                return _Closeness;
            }
        }
        
        public Point NodePoint;

        public void DrawNode(Graphics g)
        {
            Font fnt = ParentGraph.DrawingCanvas.Font;

            Point MidPoint = NodePoint;

            int NodeCircleRadius = ParentGraph.NodeCircleRadius;

            Rectangle r = new Rectangle(MidPoint.X - NodeCircleRadius, MidPoint.Y - NodeCircleRadius, NodeCircleRadius * 2, NodeCircleRadius * 2);

            g.FillEllipse(Brushes.Yellow, r);
            g.DrawEllipse(Pens.Black, r);

            SizeF TickerSize = g.MeasureString(Ticker, fnt);

            g.DrawString(Ticker, fnt, Brushes.Black, MidPoint.X - TickerSize.Width / 2, MidPoint.Y - TickerSize.Height / 2);
        }

        public string ToolTip
        {
            get
            {
                string tltp = Text + Environment.NewLine;
                tltp += "Degree : " + Degree.ToString() + Environment.NewLine;
                tltp += "Eccentricty : " + Eccentricity.ToString();

                return tltp;
            }
        }
    }

    public class Graph
    {
        public List<Node> Nodes;

        public Graph()
        {
            Nodes = new List<Node>();
        }

        public Node AddNode(string NodeText)
        {
            Node nd = new Node();
            nd.Text = NodeText;
            nd.Index = Nodes.Count;
            nd.ParentGraph = this;
            Nodes.Add(nd);
            return nd;
        }

        private bool _IsAllConnected;
        private int _NoOfEdges;
        private int _NoOfPossibleEdges;
        private double _Density;
        private int _Diameter;
        private int _Radius;
        private int[] _DegreeCount;
        private int _MaxDegreeCount;
        private int _MaxDegree;

        public int NodeCircleRadius = 20;

        public Control _DrawingCanvas;

        public Control DrawingCanvas
        {
            get
            {
                return _DrawingCanvas;
            }
            set
            {
                _DrawingCanvas = value;
                _DrawingCanvas.MouseMove += DrawingCanvas_MouseMove;
                _DrawingCanvas.MouseDown += DrawingCanvas_MouseDown;
                _DrawingCanvas.MouseUp += DrawingCanvas_MouseUp;
                _DrawingCanvas.Paint += DrawingCanvas_Paint;
            }
        }

        public ToolTip GraphToolTip;

        public void Recalculate()
        {
            _IsAllConnected = true;

            _NoOfEdges = 0;

            int n = Nodes.Count;

            _Diameter = 0;

            _Radius = n;

            foreach (Node nd in Nodes)
            {
                int D = nd.Degree;

                nd.Recalculate();

                if (D == 0)
                    _IsAllConnected = false;
                else
                {
                    int e = (int)nd.Eccentricity;

                    _Diameter = Math.Max(_Diameter, e);
                    _Radius = Math.Min(_Radius, e);
                }

                _NoOfEdges += D;
            }

            _NoOfEdges /= 2;

            _NoOfPossibleEdges = n * (n - 1) / 2;

            _Density = 1.0 * NoOfEdges / NoOfPossibleEdges;

            _DegreeCount = new int[n];

            foreach (Node nd in Nodes)
            {
                _DegreeCount[nd.Degree]++;
            }

            _MaxDegree = 0;
            _MaxDegreeCount = 0;

            for (int i = 0; i < _DegreeCount.Length; i++)
            {
                int D = _DegreeCount[i];

                if (D > 0)
                {
                    _MaxDegree = i;
                    _MaxDegreeCount = Math.Max(_MaxDegreeCount, D);
                }
            }

            //Set the initial Poistion
            ResetGraphDrawing();
        }

        public void ResetGraphDrawing()
        {
            int CircularRange = Diameter - Radius;

            Point MidPoint = new Point(DrawingCanvas.Width / 2, DrawingCanvas.Height / 2);

            int RadiusBlockLength = (Math.Min(MidPoint.X, MidPoint.Y) - NodeCircleRadius * 2) / (CircularRange + 2);

            for (int i = Radius; i <= Diameter; i++)
            {   
                SetNode(RadiusBlockLength, i, MidPoint);
            }
            
            SetNode(RadiusBlockLength, 0, MidPoint);
        }

        public void SetNode(int RadiusBlockLength, int Index, Point MidPoint)
        {
            List<Node> LevelNodes = new List<Node>();

            double d = Index;

            if (d == 0) d = double.PositiveInfinity;

            foreach (Node nd in Nodes)
            {  
                if (nd.Eccentricity == d)
                {
                    LevelNodes.Add(nd);
                }
            }

            double ThetaDiv = -2 * Math.PI / LevelNodes.Count;

            if (d == double.PositiveInfinity) d = Diameter + 1;

            int r = RadiusBlockLength * ((int)d - Radius + 1);

            for (int j = 0; j < LevelNodes.Count; j++)
            {
                double Theta = ThetaDiv * j + Index * 5;

                LevelNodes[j].NodePoint = new Point(MidPoint.X + (int)(r * Math.Cos(Theta)), MidPoint.Y + (int)(r * Math.Sin(Theta)));
            }
        }

        public bool IsAllConnected
        {
            get
            {
                return _IsAllConnected;
            }
        }

        public int NoOfEdges
        {
            get
            {
                return _NoOfEdges;
            }
        }

        public int NoOfPossibleEdges
        {
            get
            {
                return _NoOfPossibleEdges;
            }
        }

        public double Density
        {
            get
            {
                return _Density;
            }
        }

        public int Diameter
        {
            get
            {
                return _Diameter;
            }
        }

        public int Radius
        {
            get
            {
                return _Radius;
            }
        }

        public int[] DegreeCount
        {
            get
            {
                return _DegreeCount;
            }
        }

        public int MaxDegreeCount
        {
            get
            {
                return _MaxDegreeCount;
            }
        }

        public int MaxDegree
        {
            get
            {
                return _MaxDegree;
            }
        }

        private int DragNode = -1;
        
        private void DrawGraph(Graphics g)
        {
            foreach (Node n in Nodes)
            {
                foreach (int i in n.ConnectionIndices)
                {
                    g.DrawLine(Pens.Black, Nodes[i].NodePoint, n.NodePoint);
                }
            }

            foreach (Node n in Nodes)
            {
                n.DrawNode(g);
            }
        }

        private void DrawingCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            DrawingCanvas.Cursor = Cursors.Arrow;

            if (DragNode > -1)
            {
                DrawingCanvas.Cursor = Cursors.SizeAll;
            }
            else
            {
                foreach (Node n in Nodes)
                {
                    if (Math.Abs(e.X - n.NodePoint.X) < NodeCircleRadius && Math.Abs(e.Y - n.NodePoint.Y) < NodeCircleRadius)
                    {
                        DrawingCanvas.Cursor = Cursors.Hand;
                        if (GraphToolTip != null) GraphToolTip.SetToolTip(DrawingCanvas, n.ToolTip);
                        return;
                    }
                }

                GraphToolTip.SetToolTip(DrawingCanvas, "");
            }
        }

        private void DrawingCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                GraphToolTip.SetToolTip(DrawingCanvas, "");

                foreach (Node n in Nodes)
                {
                    if (Math.Abs(e.X - n.NodePoint.X) < NodeCircleRadius && Math.Abs(e.Y - n.NodePoint.Y) < NodeCircleRadius)
                    {
                        DragNode = n.Index;
                        return;
                    }
                }
            }
        }

        private void DrawingCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (DragNode > -1)
                {
                    Nodes[DragNode].NodePoint = new Point(e.X, e.Y);
                    DrawingCanvas.Invalidate();
                }
            }

            DragNode = -1;//Always reset to empty
        }

        private void DrawingCanvas_Paint(object sender, PaintEventArgs e)
        {
            DrawGraph(e.Graphics);
        }

        public void ExportNodeDetails(string FilePath)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Ticker,Exchange,Degree,Eccentricity");

            foreach (Node nd in Nodes)
            {
                double E = nd.Eccentricity;

                string se = "";

                if (!double.IsPositiveInfinity(E)) se = E.ToString();

                sb.AppendLine(nd.Ticker + "," + nd.Exchange + "," + nd.Degree.ToString() + "," + se);
            }

            File.WriteAllText(FilePath, sb.ToString());
        }

        public void ExportNodeDetails()
        {
            SaveFileDialog fldlg = new SaveFileDialog();

            fldlg.Filter = "Comma Separated Files (*.csv)|*.csv|All Files (*.*)|*.*";

            if(fldlg.ShowDialog() == DialogResult.OK)
            {
                ExportNodeDetails(fldlg.FileName);
            }
        }
    }
}
