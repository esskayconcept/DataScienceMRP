using System;
using System.Collections;
using System.Drawing.Drawing2D;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

/// <summary>
/// To Do
/// 
/// Filter
/// WMA
/// LR
/// LRS
/// 
/// </summary>

namespace StockNet
{
    public partial class frmStockNet : Form
    {
        private double[,] CorrelationCoefficients;

        private Graph CurrentGraph;

        public frmStockNet()
        {
            InitializeComponent();
        }

        private void frmStockNet_Load(object sender, EventArgs e)
        {
            cboCorrelationAttribute.SelectedIndex = 0;

            frmStockNet_Resize(sender, e);

            CurrentGraph = new Graph();
            CurrentGraph.DrawingCanvas = pnlGraph;
            CurrentGraph.GraphToolTip = toolTipStockNet;
        }

        private void frmStockNet_Resize(object sender, EventArgs e)
        {
            pnlHeatmap.Height = pnlHeatmap.Width = Height - 100;
            pnlHeatmap.Invalidate();
        }

        #region Graphics Parameters

        private int LeftMargin = 20;
        private int RightMargin = 100;
        private int BottomMargin = 20;
        private int TopMargin = 10;

        private int RightPoint;
        DataTable dtData;
        double HorizontalScale;

        ArrayList arrYearPoints;
        ArrayList arrGrids;

        int NodeCircleRadius = 20;

        #endregion

        #region Data Loading

        private void cmdDataPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fldg = new FolderBrowserDialog();

            if (fldg.ShowDialog() == DialogResult.OK)
            {
                txtDataPath.Text = fldg.SelectedPath;
            }
        }

        //Main Data Loading Routine
        private void cmdPathRefresh_Click(object sender, EventArgs e)
        {
            #region Setup

            prgbar.Visible = true;
            Cursor = Cursors.WaitCursor;
            cmdPathRefresh.Enabled = false;

            #endregion

            #region Data Structure

            DataTable dtData = new DataTable();

            dtData.Columns.Add("Date", typeof(DateTime));
            dtData.Columns.Add("Open", typeof(double));
            dtData.Columns.Add("High", typeof(double));
            dtData.Columns.Add("Low", typeof(double));
            dtData.Columns.Add("Close", typeof(double));
            dtData.Columns.Add("Volume", typeof(double));
            dtData.Columns.Add("AdjClose", typeof(double));
            dtData.Columns.Add("CloseRatio", typeof(double), "AdjClose / Close");
            dtData.Columns.Add("AdjOpen", typeof(double), "Open * CloseRatio");
            dtData.Columns.Add("AdjHigh", typeof(double), "High * CloseRatio");
            dtData.Columns.Add("AdjLow", typeof(double), "Low * CloseRatio");
            dtData.Columns.Add("Range", typeof(double), "AdjHigh - AdjLow");
            dtData.Columns.Add("DailyReturn", typeof(double), "AdjClose / AdjOpen-1");
            dtData.Columns.Add("DailyMaxReturn", typeof(double), "AdjHigh / AdjLow-1");
            dtData.Columns.Add("CloseLineValue", typeof(double), "(2 * AdjClose - (AdjHigh + AdjLow)) / Range");
            dtData.Columns.Add("DAD", typeof(double), "CloseLineValue * Volume");
            dtData.Columns.Add("AD", typeof(double));
            dtData.Columns.Add("MA", typeof(double));
            dtData.Columns.Add("WMA", typeof(double));
            dtData.Columns.Add("BaseDayPrice", typeof(double));
            dtData.Columns.Add("Return", typeof(double), "AdjClose / BaseDayPrice-1");
            dtData.Columns.Add("LinearRegreession", typeof(double));
            dtData.Columns.Add("LinearRegreessionSlope", typeof(double));

            #endregion

            string[] Files = Directory.GetFiles(txtDataPath.Text);

            #region Initialize

            prgbar.Value = 0;
            prgbar.Maximum = Files.Length;

            DateTime MaxStartDate = new DateTime(1900, 1, 1);
            DateTime MinEndDate = DateTime.Today;
            int Count = 0;

            lvwStocks.Items.Clear();
            CurrentGraph.Nodes.Clear();
            lvwNodes.Items.Clear();
            cboSourceNode.Items.Clear();
            cboTargetNode.Items.Clear();
            
            #endregion

            #region Loop through the files to load data

            foreach (string s in Files)
            {
                ListViewItem itm = new ListViewItem();

                Count++;

                itm.Text = Count.ToString();

                string[] StockDetails = Path.GetFileNameWithoutExtension(s).Split('_');

                itm.SubItems.Add(StockDetails[0]);
                itm.SubItems.Add(StockDetails[1]);

                #region Load Individual Stock Data

                DataTable dtStockData = dtData.Clone();

                string[] sLines = File.ReadAllLines(s);

                double AD = 0.0;

                for (int i = 1; i < sLines.Length; i++)
                {
                    string[] sDetails = sLines[i].Split(',');

                    DataRow dr = dtStockData.NewRow();

                    DateTime dt = DateTime.Parse(sDetails[0]);

                    if (i == 1)
                    {
                        if (dt > MaxStartDate) MaxStartDate = dt;
                        itm.SubItems.Add(dt.ToString("dd-MMM-yyyy"));
                    }

                    if (i == sLines.Length - 1)
                    {
                        if (dt < MinEndDate) MinEndDate = dt;
                        itm.SubItems.Add(dt.ToString("dd-MMM-yyyy"));
                    }

                    dr["Date"] = dt;
                    dr["Open"] = double.Parse(sDetails[1]);

                    double High = double.Parse(sDetails[2]);
                    double Low = double.Parse(sDetails[3]);

                    dr["High"] = High;
                    dr["Low"] = Low;

                    if (High - Low == 0.0) dr["High"] = DBNull.Value;

                    dr["Close"] = double.Parse(sDetails[4]);
                    dr["Volume"] = double.Parse(sDetails[5]);
                    dr["AdjClose"] = double.Parse(sDetails[6]);

                    dtStockData.Rows.Add(dr);

                    object objDAD = dr["DAD"];

                    double DAD = 0.0;

                    if (objDAD != DBNull.Value) DAD = (double)objDAD;

                    AD += DAD;
                    dr["AD"] = AD;
                }

                itm.Tag = dtStockData;

                SetMA(dtStockData);
                SetReturn(dtStockData);

                #endregion

                lvwStocks.Items.Add(itm);

                ListViewItem itmNodes = new ListViewItem();

                itmNodes.Text = Count.ToString();
                
                itmNodes.SubItems.Add(StockDetails[0]);
                itmNodes.SubItems.Add(StockDetails[1]);
                itmNodes.SubItems.Add("0");
                itmNodes.SubItems.Add("");
                itmNodes.SubItems.Add("0");

                string FullText = StockDetails[0] + ":" + StockDetails[1];

                CurrentGraph.AddNode(FullText);

                cboSourceNode.Items.Add(FullText);
                cboTargetNode.Items.Add(FullText);

                lvwNodes.Items.Add(itmNodes);

                prgbar.Value++;
            }

            #endregion

            #region Set Filter Range

            lblMinStartDate.Text = MaxStartDate.ToString("dd-MMM-yyyy");
            dateTimePickerStartDate.MinDate = MaxStartDate;
            dateTimePickerStartDate.Value = MaxStartDate;

            lblMaxEndDate.Text = MinEndDate.ToString("dd-MMM-yyyy");
            dateTimePickerEndDate.MinDate = MinEndDate;
            dateTimePickerEndDate.Value = MinEndDate;

            #endregion

            if (lvwStocks.Items.Count > 0) lvwStocks.Items[0].Selected = true;
            
            #region Clean up

            Cursor = Cursors.Default;
            cmdPathRefresh.Enabled = true;
            prgbar.Visible = false;

            #endregion
        }
        
        private DataTable GetData(string Stock)
        {
            string[] StockDetail = Stock.Split(':');

            foreach (ListViewItem itm in lvwStocks.Items)
            {
                if(itm.SubItems[1].Text==StockDetail[0] && itm.SubItems[2].Text == StockDetail[1])
                {
                    DataTable dtData = (DataTable)itm.Tag;

                    dtData = new DataView(dtData,
                    "[Date]>='" + dateTimePickerStartDate.Value.ToString("dd-MMM-yyyy") + "' AND [Date]<='" + dateTimePickerEndDate.Value.ToString("dd-MMM-yyyy") + "'",
                    "[Date]", DataViewRowState.CurrentRows).ToTable();

                    return dtData;
                }
            }

            return null;
        }

        #endregion

        #region Period Refresh routines

        private delegate void PeriodHandler(DataTable dt);

        private void SetPeriod(PeriodHandler SetIndicator)
        {
            Cursor = Cursors.WaitCursor;
            cmdRefresh.Enabled = false;
            prgbar.Visible = true;

            prgbar.Maximum = lvwStocks.Items.Count;
            prgbar.Value = 0;

            foreach (ListViewItem itm in lvwStocks.Items)
            {
                SetIndicator((DataTable)(itm.Tag));
                prgbar.Value++;
            }

            Cursor = Cursors.Default;
            cmdRefresh.Enabled = true;
            prgbar.Visible = false;

            lvwStocks_SelectedIndexChanged(null, null);
        }

        private void SetReturn(DataTable dt)
        {
            int Period = (int)nbrReturnPeriod.Value;

            for (int i = 0; i < Period; i++)
            {
                dt.Rows[i]["BaseDayPrice"] = DBNull.Value;
            }

            for (int i = Period; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["BaseDayPrice"] = (double)dt.Rows[i - Period]["AdjClose"];
            }
        }

        private void SetMA(DataTable dt)
        {
            int Period = (int)nbrMAPeriod.Value;

            double LastValue = 0;
            double Sum = 0.0;

            for (int i = 0; i < Period; i++)
            {
                dt.Rows[i]["MA"] = DBNull.Value;
                Sum += (double)dt.Rows[i]["AdjClose"];
            }

            dt.Rows[Period - 1]["MA"] = Sum / Period;

            for (int i = Period; i < dt.Rows.Count; i++)
            {
                LastValue = (double)dt.Rows[i - Period]["AdjClose"];
                Sum += (double)dt.Rows[i]["AdjClose"] - LastValue;
                dt.Rows[i]["MA"] = Sum / Period;
            }
        }

        private void cmdRefershReturn_Click(object sender, EventArgs e)
        {
            SetPeriod(SetReturn);
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {   
            SetPeriod(SetMA);
        }

        #endregion

        #region Chart Utility

        private int GetX(int i)
        {
            return (int)(LeftMargin + HorizontalScale * i);
        }

        private int SetGridLines(Graphics g, object sender)
        {
            Panel pnl = (Panel)sender;

            g.Clear(Color.White);

            int BottomPoint = pnl.Height - BottomMargin;

            g.DrawLine(Pens.Red, LeftMargin, BottomPoint, RightPoint, BottomPoint);

            g.DrawLine(Pens.Gray, LeftMargin, TopMargin, LeftMargin, BottomPoint);
            g.DrawLine(Pens.Gray, RightPoint, TopMargin, RightPoint, BottomPoint);

            if (arrGrids != null)
            {
                foreach (object o in arrGrids)
                {
                    int grdPoint = (int)o;
                    g.DrawLine(Pens.Gray, grdPoint, TopMargin, grdPoint, BottomPoint);
                }
            }

            return BottomPoint;
        }

        private Point SetPoint(int BottomPoint, double VerticalScale,  double MinValue, DataRow dr, string DataColumn, Point pLast, GraphicsPath p, int X)
        {
            int Y = (int)(BottomPoint - VerticalScale * ((double)dr[DataColumn] - MinValue));

            Point pNewPoint = new Point(X, Y);

            p.AddLine(pLast, pNewPoint);

            return pNewPoint;
        }

        private void RepaintAll()
        {
            pnlTimeLine.Invalidate();
            pnlOscilatorCanvas.Invalidate();
            pnlAggreagtor.Invalidate();
            pnlPriceCanvas.Invalidate();
        }

        private void ShowGrids(Graphics g, double VerticalScale, double Range, double MinValue, int BottomPoint)
        {
            int NoOfGaps = 5;

            double VerticalGap = Range / NoOfGaps;

            Font fnt = pnlPriceCanvas.Font;

            string strMinValue = MinValue.ToString("N2");

            float TickWordOffset = g.MeasureString(strMinValue, fnt).Height / 2;

            for (int i = 0; i < NoOfGaps; i++)
            {
                double GapValue = VerticalGap * (i + 1);

                int YGap = BottomPoint - (int)(VerticalScale * GapValue);

                string TickValue = (GapValue + MinValue).ToString("N2");

                g.DrawString(TickValue, pnlPriceCanvas.Font, Brushes.Black, RightPoint + 5, YGap - TickWordOffset);

                g.DrawLine(Pens.Gray, LeftMargin, YGap, RightPoint + 5, YGap);
            }

            g.DrawString(strMinValue, pnlPriceCanvas.Font, Brushes.Black, RightPoint + 5, BottomPoint - TickWordOffset);
        }

        #endregion

        #region Redraw on Resize

        private void pnlPriceCanvas_Resize(object sender, EventArgs e)
        {
            pnlPriceCanvas.Invalidate();
        }

        private void pnlAggreagtor_Resize(object sender, EventArgs e)
        {
            pnlAggreagtor.Invalidate();
        }

        #endregion

        private void lvwStocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwStocks.SelectedItems.Count > 0)
            {
                #region Get the Years

                dbgrdData.DataSource = lvwStocks.SelectedItems[0].Tag;

                dtData = (DataTable)dbgrdData.DataSource;

                dtData = new DataView(dtData,
                                    "[Date]>='" + dateTimePickerStartDate.Value.ToString("dd-MMM-yyyy") + "' AND [Date]<='" + dateTimePickerEndDate.Value.ToString("dd-MMM-yyyy") + "'",
                                    "[Date]", DataViewRowState.CurrentRows).ToTable();

                int CurrentYear = dateTimePickerStartDate.Value.Year;

                arrYearPoints = new ArrayList();

                for (int i = 0; i < dtData.Rows.Count; i++)
                {
                    DataRow dr = dtData.Rows[i];

                    DateTime date = Convert.ToDateTime(dr["Date"]);

                    int TheYear = date.Year;

                    if (TheYear > CurrentYear)
                    {
                        arrYearPoints.Add(i - 1);
                        CurrentYear = TheYear;
                    }
                }

                #endregion

                pnlTimeLine_Resize(pnlTimeLine, e);

                RepaintAll();
            }   
        }

        #region Time Line Paint

        private void pnlTimeLine_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int BottomPoint = SetGridLines(g, sender);

            #region Stamp Years

            if (arrGrids != null)
            {
                Font fnt = pnlTimeLine.Font;

                for (int i = 0; i < arrGrids.Count; i++)
                {
                    int grdPoint = (int)arrGrids[i];

                    string TheYear = Convert.ToDateTime(dtData.Rows[(int)arrYearPoints[i]]["Date"]).Year.ToString();

                    SizeF txtsz = g.MeasureString(TheYear, fnt);

                    g.DrawString(TheYear, fnt, Brushes.Black, grdPoint - txtsz.Width, BottomPoint + 3);
                    g.DrawLine(Pens.Gray, grdPoint, BottomPoint, grdPoint, BottomPoint + txtsz.Height);
                }
            }

            #endregion

            #region Volume

            if (dtData != null)
            {
                double MaxValue = (double)dtData.Compute("MAX([Volume])", "");

                double VerticalScale = (BottomPoint - TopMargin) / MaxValue;

                for (int i = 0; i < dtData.Rows.Count; i++)
                {
                    DataRow dr = dtData.Rows[i];

                    int Y = (int)(BottomPoint - VerticalScale * (double)dr["Volume"]);
                    int X = GetX(i);

                    g.DrawLine(Pens.Black, X, BottomPoint, X, Y);
                }
            }

            #endregion
        }

        private void pnlTimeLine_Resize(object sender, EventArgs e)
        {
            RightPoint = pnlTimeLine.Width - RightMargin;

            if (dtData != null && dtData.Rows.Count > 0)
            {
                HorizontalScale = 1.0 * (RightPoint - LeftMargin) / dtData.Rows.Count;

                arrGrids = new ArrayList();

                foreach (object o in arrYearPoints)
                {
                    arrGrids.Add((int)(HorizontalScale * (int)o + LeftMargin));
                }
            }
        }

        #endregion
               
        #region Price 

        private void chkMA_CheckedChanged(object sender, EventArgs e)
        {
            pnlPriceCanvas.Invalidate();
        }

        private void pnlPriceCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int BottomPoint = SetGridLines(g, sender);

            if (dtData != null)
            {
                double MaxValue = (double)dtData.Compute("MAX([AdjClose])", "");
                double MinValue = (double)dtData.Compute("MIN([AdjClose])", "");

                double Range = (MaxValue - MinValue);

                double VerticalScale = (BottomPoint - TopMargin) / Range;

                ShowGrids(g, VerticalScale, Range, MinValue, BottomPoint);

                GraphicsPath p = new GraphicsPath();
                GraphicsPath pMA = new GraphicsPath();

                Point pLast = new Point(LeftMargin, BottomPoint);
                Point pLastMA = new Point(LeftMargin, BottomPoint);

                for (int i = 0; i < dtData.Rows.Count; i++)
                {
                    DataRow dr = dtData.Rows[i];

                    int X = GetX(i);

                    pLast = SetPoint(BottomPoint, VerticalScale, MinValue, dr, "AdjClose", pLast, p, X);

                    if (chkMA.Checked && dr["MA"] != DBNull.Value)
                    {
                        pLastMA = SetPoint(BottomPoint, VerticalScale, MinValue, dr, "MA", pLastMA, pMA, X);
                    }
                }

                g.DrawPath(new Pen(Color.Black, 2), p);
                if (chkMA.Checked) g.DrawPath(new Pen(Color.Blue, 2), pMA);
            }
        }


        #endregion

        private void pnlAggreagtor_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int BottomPoint = SetGridLines(g, sender);

            if (dtData != null)
            {
                double MaxValue = (double)dtData.Compute("MAX([AD])", "");
                double MinValue = (double)dtData.Compute("MIN([AD])", "");

                double Range = (MaxValue - MinValue);

                double VerticalScale = (BottomPoint - TopMargin) / Range;

                ShowGrids(g, VerticalScale, Range, MinValue, BottomPoint);

                GraphicsPath p = new GraphicsPath();

                Point pLast = new Point(LeftMargin, BottomPoint);

                for (int i = 0; i < dtData.Rows.Count; i++)
                {
                    DataRow dr = dtData.Rows[i];

                    int X = GetX(i);

                    pLast = SetPoint(BottomPoint, VerticalScale, MinValue, dr, "AD", pLast, p, X);
                }

                g.DrawPath(new Pen(Color.Black, 2), p);
            }
        }

        #region Oscillation

        private void chkDailyReturn_CheckedChanged(object sender, EventArgs e)
        {
            pnlOscilatorCanvas.Invalidate();
        }

        private void chkMaxDailyReturn_CheckedChanged(object sender, EventArgs e)
        {
            pnlOscilatorCanvas.Invalidate();
        }

        private void chkReturn_CheckedChanged(object sender, EventArgs e)
        {
            pnlOscilatorCanvas.Invalidate();
        }

        private void pnlOscilatorCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int BottomPoint = SetGridLines(g, sender);

            if (dtData != null)
            {
                double MaxValue = double.MinValue;
                double MinValue = double.MaxValue;

                if (chkDailyReturn.Checked)
                {
                    MaxValue = Math.Max(MaxValue, (double)dtData.Compute("MAX([DailyReturn])", ""));
                    MinValue = Math.Min(MinValue, (double)dtData.Compute("MIN([DailyReturn])", ""));
                }

                if (chkMaxDailyReturn.Checked)
                {
                    MaxValue = Math.Max(MaxValue, (double)dtData.Compute("MAX([DailyMaxReturn])", ""));
                    MinValue = Math.Min(MinValue, (double)dtData.Compute("MIN([DailyMaxReturn])", ""));
                }

                if (chkReturn.Checked)
                {
                    MaxValue = Math.Max(MaxValue, (double)dtData.Compute("MAX([Return])", ""));
                    MinValue = Math.Min(MinValue, (double)dtData.Compute("MIN([Return])", ""));
                }

                double Range = (MaxValue - MinValue);

                double VerticalScale = (BottomPoint - TopMargin) / Range;

                ShowGrids(g, VerticalScale, Range, MinValue, BottomPoint);

                GraphicsPath pDR = new GraphicsPath();
                GraphicsPath pMxDR = new GraphicsPath();
                GraphicsPath pRDR = new GraphicsPath();

                Point pLastDR = new Point(LeftMargin, BottomPoint);
                Point pLastDRMx = new Point(LeftMargin, BottomPoint);
                Point pLastDRR = new Point(LeftMargin, BottomPoint);

                for (int i = 0; i < dtData.Rows.Count; i++)
                {
                    DataRow dr = dtData.Rows[i];
                    int X = GetX(i);

                    object objDR = dr["DailyReturn"];

                    if (chkDailyReturn.Checked && objDR != DBNull.Value)
                    {
                        pLastDR = SetPoint(BottomPoint, VerticalScale, MinValue, dr, "DailyReturn", pLastDR, pDR, X);
                    }

                    object objMaxDR = dr["DailyMaxReturn"];

                    if (chkMaxDailyReturn.Checked && objMaxDR != DBNull.Value)
                    {
                        pLastDRMx = SetPoint(BottomPoint, VerticalScale, MinValue, dr, "DailyMaxReturn", pLastDRMx, pMxDR, X);
                    }

                    object objDRR = dr["Return"];

                    if (chkReturn.Checked && objDRR != DBNull.Value)
                    {
                        pLastDRR = SetPoint(BottomPoint, VerticalScale, MinValue, dr, "Return", pLastDRR, pRDR, X);
                    }
                }

                if (chkDailyReturn.Checked) g.DrawPath(new Pen(chkDailyReturn.ForeColor, 2), pDR);
                if (chkMaxDailyReturn.Checked) g.DrawPath(new Pen(chkMaxDailyReturn.ForeColor, 2), pMxDR);
                if (chkReturn.Checked) g.DrawPath(new Pen(chkReturn.ForeColor, 2), pRDR);
            }
        }

        #endregion
        
        #region Correlation

        private void CalculateCorrelations(ListView lvwStocks)
        {
            int n = lvwStocks.Items.Count;

            CorrelationCoefficients = new double[n, n];

            Cursor = Cursors.WaitCursor;

            prgbarCorreation.Maximum = n * n;
            prgbarCorreation.Value = 0;

            for (int i = 0; i < n; i++)
            {
                ListViewItem itmFirst = lvwStocks.Items[i];

                string FirstStock = itmFirst.SubItems[1].Text + ":" + itmFirst.SubItems[2].Text;

                for (int j = 0; j < n; j++)
                {
                    double MirrorValue = CorrelationCoefficients[j, i];

                    if (MirrorValue == 0)
                    {
                        ListViewItem itmSecond = lvwStocks.Items[j];

                        string SecondStock = itmSecond.SubItems[1].Text + ":" + itmSecond.SubItems[2].Text;

                        CorrelationCoefficients[i, j] = CorreationCoefficient(FirstStock, SecondStock);
                    }
                    else
                    {
                        CorrelationCoefficients[i, j] = MirrorValue;
                    }

                    prgbarCorreation.Value++;
                }
            }

            Cursor = Cursors.Default;

            prgbarCorreation.Value = 0;
        }

        private double CorreationCoefficient(string FirstStock, string SecondStock)
        {
            DataTable FirststockData = GetData(FirstStock);
            DataTable SecondstockData = GetData(SecondStock);

            //Assume both the data has exactly same dates 
            double r1r2Sum = 0.0;
            double r1Sum = 0.0;
            double r2Sum = 0.0;
            double r1SqSum = 0.0;
            double r2SqSum = 0.0;

            double n = Math.Min(FirststockData.Rows.Count, SecondstockData.Rows.Count);

            for (int i = 0; i < n; i++)
            {
                object or1 = FirststockData.Rows[i]["Return"];
                object or2 = SecondstockData.Rows[i]["Return"];

                if (or1 == DBNull.Value) or1 = 0.0;
                if (or2 == DBNull.Value) or2 = 0.0;

                double r1 = (double)or1;
                double r2 = (double)or2;

                r1r2Sum += r1 * r2;
                r1Sum += r1;
                r2Sum += r2;
                r1SqSum += r1 * r1;
                r2SqSum += r2 * r2;
            }

            r1r2Sum /= n;
            r1Sum /= n;
            r2Sum /= n;
            r1SqSum /= n;
            r2SqSum /= n;

            return (r1r2Sum - r1Sum * r2Sum) / Math.Sqrt((r1SqSum - r1Sum * r1Sum) * (r2SqSum - r2Sum * r2Sum));
        }

        private void cmdCorrelation_Click(object sender, EventArgs e)
        {
            CalculateCorrelations(lvwStocks);
            pnlHeatmap.Invalidate();
        }

        private void chkShowCorrelation_CheckedChanged(object sender, EventArgs e)
        {
            pnlHeatmap.Invalidate();
        }        

        #endregion

        #region Heatmp Display

        private void optShowHeatMap_CheckedChanged(object sender, EventArgs e)
        {
            pnlHeatmap.Invalidate();
        }

        private void optShowAdjacencyMatrix_CheckedChanged(object sender, EventArgs e)
        {
            pnlHeatmap.Invalidate();
        }

        private void pnlHeatmap_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int HeaderWidth = 100;
            
            Font fnt = pnlHeatmap.Font;

            if (CorrelationCoefficients != null)
            {
                int StockCount = (int)Math.Sqrt(CorrelationCoefficients.Length); ;
                float Gap = (pnlHeatmap.Width - HeaderWidth) / StockCount;

                float EndSide = (int)(HeaderWidth + StockCount * Gap);
                g.DrawLine(Pens.Black, 0, HeaderWidth, EndSide, HeaderWidth);
                g.DrawLine(Pens.Black, HeaderWidth, 0, HeaderWidth, EndSide);

                double Threshhold = (double)nbrThreshhold.Value;

                for (int i = 0; i < StockCount; i++)
                {
                    float HW = (int)(HeaderWidth + i * Gap);

                    for (int j = 0; j < StockCount; j++)
                    {
                        float Position = HeaderWidth + j * Gap;

                        double Value = CorrelationCoefficients[j, i];

                        int clroffset = (int)(127 * (2 - Math.Abs(Value)));

                        Color clr = Color.White;

                        if (optShowHeatMap.Checked)
                        {
                            if (Value > 0)
                                clr = Color.FromArgb(255, clroffset, clroffset);
                            else
                                clr = Color.FromArgb(clroffset, 255, clroffset);
                        }
                        else
                        {
                            if (Value > Threshhold & i != j)
                                clr = Color.Pink;
                        }
                        
                        g.FillRectangle(new System.Drawing.SolidBrush(clr), HW + 1, Position + 1, Gap - 2, Gap - 2);

                        if(chkShowCorrelation.Checked )
                        {
                            string sValue = Value.ToString("N2");

                            SizeF wrdSize = g.MeasureString(sValue, fnt);

                            g.DrawString(sValue, fnt, Brushes.Black, HW + 2, Position + (Gap - wrdSize.Height) / 2);
                        }
                    }

                    g.DrawLine(Pens.Black, HW + Gap, 0, HW + Gap, EndSide);

                    g.DrawLine(Pens.Black, 0, HW + Gap, EndSide, HW + Gap);

                    string Ticker = lvwStocks.Items[i].SubItems[1].Text;

                    float Offset = HW;

                    SizeF WordMeasure = g.MeasureString(Ticker, fnt);

                    g.DrawString(Ticker, fnt, Brushes.Black, 50, Offset + WordMeasure.Height / 2);

                    // Save the graphics state.
                    GraphicsState state = g.Save();
                    g.ResetTransform();

                    // Rotate.
                    g.RotateTransform(-90);

                    // Translate to desired position. Be sure to append
                    // the rotation so it occurs after the rotation.
                    g.TranslateTransform(Offset + WordMeasure.Height / 2, HeaderWidth - 5, MatrixOrder.Append);

                    // Draw the text at the origin.
                    g.DrawString(Ticker, fnt, Brushes.Black, 0, 0);

                    // Restore the graphics state.
                    g.Restore(state);
                }
            }
        }

        private void pnlHeatmap_MouseUp(object sender, MouseEventArgs e)
        {
            int HeaderWidth = 100;

            int StockCount = (int)Math.Sqrt(CorrelationCoefficients.Length);

            double Gap = (pnlHeatmap.Width - HeaderWidth) / StockCount;

            int ColIndex = (int)((e.X - HeaderWidth) / Gap);
            int RowIndex = (int)((e.Y - HeaderWidth) / Gap);

            MessageBox.Show(lvwStocks.Items[RowIndex].SubItems[1].Text + ":" + lvwStocks.Items[ColIndex].SubItems[1].Text + " = " + CorrelationCoefficients[RowIndex, ColIndex].ToString());
        }

        #endregion

        #region Save / Load an Export Option of the Enitre Analysis

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog svdlg = new SaveFileDialog();

            if (svdlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter wrtr = new StreamWriter(svdlg.FileName);

                int n = CurrentGraph.Nodes.Count;

                for (int i = 0; i < n; i++)
                {
                    string Coefficients = "";

                    for (int j = 0; j < n; j++)
                    {
                        Coefficients += CorrelationCoefficients[i, j].ToString() + ",";
                    }

                    wrtr.WriteLine(Coefficients.TrimEnd(','));
                }

                wrtr.Close();
            }
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog opndlg = new OpenFileDialog();

            if (opndlg.ShowDialog() == DialogResult.OK)
            {
                string[] AllLines = File.ReadAllLines(opndlg.FileName);

                int n = AllLines.Length;

                CorrelationCoefficients = new double[n, n];

                for (int i = 0; i < AllLines.Length; i++)
                {
                    string[] values = AllLines[i].Split(',');

                    for (int j = 0; j < values.Length; j++)
                    {
                        CorrelationCoefficients[i, j] = double.Parse(values[j]);
                    }
                }

                pnlHeatmap.Invalidate();
            }
        }

        private void cmdExportResult_Click(object sender, EventArgs e)
        {
            CurrentGraph.ExportNodeDetails();
        }
        
        #endregion

        #region Graph Building
        
        private void nbrThreshhold_ValueChanged(object sender, EventArgs e)
        {
            cmdRefreshNode_Click(null, null);
            pnlHeatmap.Invalidate();
        }

        private void cmdRefreshNode_Click(object sender, EventArgs e)
        {
            if (CorrelationCoefficients != null)
            {
                foreach(Node nd in CurrentGraph.Nodes)
                {
                    nd.ConnectionIndices.Clear();
                }

                double Threshhold = (double)nbrThreshhold.Value;

                for (int i = 0; i < lvwNodes.Items.Count; i++)
                {
                    ListViewItem itm = lvwNodes.Items[i];

                    for (int j = 0; j < lvwNodes.Items.Count; j++)
                    {
                        double R = CorrelationCoefficients[i, j];

                        if (R > Threshhold & i != j)
                        {
                            CurrentGraph.Nodes[i].AddConnection(j);
                        }
                    }

                    itm.SubItems[3].Text = CurrentGraph.Nodes[i].Degree.ToString();
                }

                CurrentGraph.Recalculate();

                for (int i = 0; i < lvwNodes.Items.Count; i++)
                {
                    Node nd = CurrentGraph.Nodes[i];

                    ListViewItem itm = lvwNodes.Items[i];
                    ListViewItem.ListViewSubItemCollection sbitms = itm.SubItems;

                    sbitms[4].Text = nd.Eccentricity.ToString();
                    sbitms[5].Text = nd.Closeness.ToString();
                }
                
                pnlDegreeDistribution.Invalidate();

                lblNoOfNodes.Text = CurrentGraph.Nodes.Count.ToString();
                lblIsAllConnected.Text = CurrentGraph.IsAllConnected.ToString();
                lblNoOfEdges.Text = CurrentGraph.NoOfEdges.ToString();
                lblPossibleEdges.Text = CurrentGraph.NoOfPossibleEdges.ToString();
                lblDensity.Text = CurrentGraph.Density.ToString("N3");
                lblDiameter.Text = CurrentGraph.Diameter.ToString();
                lblRadius.Text = CurrentGraph.Radius.ToString();
            }   
        }

        private void pnlDegreeDistribution_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int BottomPoint = pnlDegreeDistribution.Height - BottomMargin;
            int RightPoint = pnlDegreeDistribution.Width - 10;

            g.DrawLine(Pens.Black, LeftMargin, BottomPoint, RightPoint, BottomPoint);
            g.DrawLine(Pens.Black, LeftMargin, TopMargin, LeftMargin, BottomPoint);

            int[] DegreeCount = CurrentGraph.DegreeCount;
            int[] CumulativeDegreeCount = CurrentGraph.CumulativeDegreeCount;

            if (DegreeCount != null && DegreeCount.Length > 0)
            {
                float HorizontalScale = (RightPoint - LeftMargin) / CurrentGraph.MaxDegree;
                float VerticalScale = (BottomPoint - TopMargin) / CurrentGraph.MaxDegreeCount;

                if (chkCumulative.Checked)
                    VerticalScale = (BottomPoint - TopMargin) / CumulativeDegreeCount[CumulativeDegreeCount.Length - 1];

                PointF pLast = new PointF(LeftMargin, BottomPoint - DegreeCount[0] * VerticalScale);

                PointF pLastApprox = new PointF(LeftMargin + HorizontalScale, BottomPoint - CurrentGraph.MaxDegreeCount * VerticalScale);

                PointF pLastCum = new PointF(LeftMargin, BottomPoint - CumulativeDegreeCount[0] * VerticalScale);

                GraphicsPath p = new GraphicsPath();

                GraphicsPath pApprox = new GraphicsPath();

                GraphicsPath pCum = new GraphicsPath();

                double ApproxExponent = (double)nbrApproximateExponent.Value;

                for(int i = 1; i < DegreeCount.Length; i++)
                {
                    float VApprox = (float)(CurrentGraph.MaxDegreeCount / (Math.Pow(i, ApproxExponent)));

                    float X = LeftMargin + i * HorizontalScale;

                    PointF newPoint = new PointF(X, BottomPoint - DegreeCount[i] * VerticalScale);
                    PointF newApproxPoint = new PointF(X, BottomPoint - VApprox * VerticalScale);
                    PointF newCumPoint = new PointF(X, BottomPoint - CumulativeDegreeCount[i] * VerticalScale);

                    p.AddLine(pLast, newPoint);
                    pApprox.AddLine(pLastApprox, newApproxPoint);
                    pCum.AddLine(pLastCum, newCumPoint);

                    pLast = newPoint;
                    pLastApprox = newApproxPoint;
                    pLastCum = newCumPoint;
                }
                
                if (chkCumulative.Checked)
                    g.DrawPath(Pens.Green, pCum);
                else
                {
                    g.DrawPath(Pens.Red, p);
                    g.DrawPath(Pens.Blue, pApprox);
                }
            }
        }
        
        private void cmdShowPath_Click(object sender, EventArgs e)
        {
            List<int> NodePath = CurrentGraph.Nodes[cboSourceNode.SelectedIndex].GetShortestPath(CurrentGraph.Nodes[cboTargetNode.SelectedIndex]);

            string p = "";

            foreach(int i in NodePath)
            {
                p += CurrentGraph.Nodes[i].Text.Split(':')[0] + "-";
            }

            lblPath.Text = p.TrimEnd('-');            
        }
        
        private void cmdShowAllPath_Click(object sender, EventArgs e)
        {
            List<List<int>> AllPath = CurrentGraph.Nodes[cboSourceNode.SelectedIndex].AllPaths;

            string s = "";

            foreach (List<int> il in AllPath)
            {
                foreach (int i in il)
                {
                    s += CurrentGraph.Nodes[i].Text.Split(':')[0] + "-";
                }

                s = s.TrimEnd('-');

                s += Environment.NewLine;
            }

            MessageBox.Show(s);
        }

        private void lvwNodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlDegree.Invalidate();
        }

        private void pnlDegree_Paint(object sender, PaintEventArgs e)
        {
            if (lvwNodes.SelectedItems.Count > 0)
            {
                Node nd = CurrentGraph.Nodes[lvwNodes.SelectedIndices[0]];

                Point MidPoint = new Point(pnlDegree.Width / 2, pnlDegree.Height / 2);

                Graphics g = e.Graphics;

                double ThetaDiv = -2 * Math.PI / nd.Degree;

                int radius = 150;

                for (int i = 0; i < nd.Degree; i++)
                {
                    double Theta = ThetaDiv * i;

                    Point NodeMidPoint = new Point(MidPoint.X + (int)(radius * Math.Cos(Theta)), MidPoint.Y + (int)(radius * Math.Sin(Theta)));

                    g.DrawLine(Pens.Black, MidPoint, NodeMidPoint);

                    DrawNode(CurrentGraph.Nodes[nd.ConnectionIndices[i]], NodeMidPoint, g);
                }

                DrawNode(nd, MidPoint, g);
            }
        }

        private void DrawNode(Node nd, Point MidPoint, Graphics g)
        {
            Font fnt = pnlDegree.Font;

            Rectangle r = new Rectangle(MidPoint.X - NodeCircleRadius, MidPoint.Y - NodeCircleRadius, NodeCircleRadius * 2, NodeCircleRadius * 2);

            g.FillEllipse(Brushes.Yellow, r);
            g.DrawEllipse(Pens.Black, r);

            string Ticker = nd.Ticker;

            SizeF TickerSize = g.MeasureString(Ticker, fnt);

            g.DrawString(Ticker, fnt, Brushes.Black, MidPoint.X - TickerSize.Width / 2, MidPoint.Y - TickerSize.Height / 2);
        }

        #endregion

        #region Clustering Routines

        private void ShowMatrixToGrid(double[,] d, DataGridView dbgrdview)
        {
            int r = d.GetLength(0);
            int c = d.GetLength(1);

            dbgrdview.ColumnCount = c;

            dbgrdview.Rows.Clear();

            for (int i = 0; i < r; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dbgrdview);

                for (int j = 0; j < c; j++)
                {
                    row.Cells[j].Value = d[i, j];
                }

                dbgrdview.Rows.Add(row);
            }
        }

        private double[,] Expansion(double[,] d)
        {
            int n = d.GetLength(0);

            double[,] m = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    m[i, j] = 0;

                    for (int k = 0; k < n; k++)
                    {
                        m[i, j] = m[i, j] + d[i, k] * d[j, k];
                    }
                }
            }

            return m;
        }

        private double[,] Inflation(double[,] d)
        {
            int n = d.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                double Sum = 0;

                for (int j = 0; j < n; j++)
                {
                    d[j, i] = d[j, i] * d[j, i];
                    Sum += d[j, i];
                }

                for (int j = 0; j < n; j++)
                {
                    d[j, i] /= Sum;
                }
            }

            return d;
        }

        private void SetClusters()
        {
            double[,] d = (double[,])dbgrdviewInflationMatrix.Tag;

            int n = d.GetLength(0);

            Color[] clr = new Color[5];

            clr[0] = Color.Pink;
            clr[1] = Color.LightBlue;
            clr[2] = Color.Green;
            clr[3] = Color.Orange;
            clr[4] = Color.Cyan;

            int currentColorCodeIndex = 0;

            for (int i = 0; i < n; i++)
            {
                List<Node> ClusterNodes = new List<Node>();

                for (int j = 0; j < n; j++)
                {
                    if (d[i, j] > 0.9)
                    {
                        Node nd = CurrentGraph.Nodes[j];
                        ClusterNodes.Add(nd);
                    }
                }

                if (ClusterNodes.Count > 1)
                {
                    foreach (Node nd in ClusterNodes)
                    {
                        nd.CluserColor = clr[currentColorCodeIndex];
                    }

                    currentColorCodeIndex++;
                }

                if (currentColorCodeIndex == clr.Length) currentColorCodeIndex = 0;
            }

            pnlGraph.Invalidate();
        }

        #endregion
        
        #region Clustering Events

        private void cmdInitializeMatrices_Click(object sender, EventArgs e)
        {
            ShowMatrixToGrid(CurrentGraph.AdjacencyMatrix, dbgrdviewAdjacencyMatrix);

            double[,] d = CurrentGraph.TransitionMatrix;
            ShowMatrixToGrid(d, dbgrdviewTransitionMatrix);

            double[,] m = Expansion(d);
            ShowMatrixToGrid(m, dbgrdviewExapansionMatrix);

            double[,] i = Inflation(m);
            dbgrdviewInflationMatrix.Tag = i;
            ShowMatrixToGrid(i, dbgrdviewInflationMatrix);
        }

        private void cmdVisualizeCluster_Click(object sender, EventArgs e)
        {
            SetClusters();
            tabControlStockNet.SelectedIndex = 2;
        }

        private void cmdIterate_Click(object sender, EventArgs e)
        {
            double[,] d = (double[,])dbgrdviewInflationMatrix.Tag;

            double[,] m = Expansion(d);
            ShowMatrixToGrid(m, dbgrdviewExapansionMatrix);

            double[,] i = Inflation(m);
            dbgrdviewInflationMatrix.Tag = i;
            ShowMatrixToGrid(i, dbgrdviewInflationMatrix);
        }

        #endregion

        private void chkCumulative_CheckedChanged(object sender, EventArgs e)
        {
            pnlDegreeDistribution.Invalidate();
        }
    }
}